using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlTraficoPorteria
{
    public partial class NuevoCamion : MaterialForm
    {
        public NuevoCamion()
        {
            InitializeComponent();
            dtpArribo.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpArribo.Format = DateTimePickerFormat.Custom;
            dtpArribo.Value = DateTime.Now;

        }

        #region Metodo para ver usuario Logueado

        public string? UsuarioLogeado()
        {

            CamionesDB oCamionesDB = new CamionesDB();
            DataTable dt = oCamionesDB.VerUsuarioLogeado();
            DataRow row = dt.Rows[0];

            string usuarioLogeado = Convert.ToString(row["Nombre"]);
            return usuarioLogeado;
        }

        #endregion

        #region Clic Agregar

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if (validarTextBoxs())
            {
                CamionesDB oCamionesDB = new CamionesDB();
                try
                {
                    oCamionesDB.Agregar(txtTrasporte1.Text, txtPatenteTractor1.Text, txtPatenteSemi1.Text, txtNombreChofer1.Text,
                        txtApellidoChofer1.Text, txtDniChofer1.Text, txtProveedor1.Text, Convert.ToDateTime(dtpArribo.Value), true, UsuarioLogeado());
                        //dtpArribo.Value.Year + "-" + dtpArribo.Value.Month + "-" + dtpArribo.Value.Day + "-" + dtpArribo.Value.Hour + "-" + dtpArribo.Value.Minute + "-" + dtpArribo.Value.Second,
                        //dtpIngreso.Value.Year + "-" + dtpIngreso.Value.Month + "-" + dtpIngreso.Value.Day + "-" + dtpIngreso.Value.Date,
                        // true
                        //);

                    MessageBox.Show("Se agrego un camion a la fila", "Nuevo camion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
                }

                try
                {
                    oCamionesDB.AgregarHistorial(txtTrasporte1.Text, txtPatenteTractor1.Text, txtPatenteSemi1.Text, txtNombreChofer1.Text,
                        txtApellidoChofer1.Text, txtDniChofer1.Text, txtProveedor1.Text, Convert.ToDateTime(dtpArribo.Value), UsuarioLogeado());
                        //dtpArribo.Value.Year + "-" + dtpArribo.Value.Month + "-" + dtpArribo.Value.Day,
                        //dtpIngreso.Value.Year + "-" + dtpIngreso.Value.Month + "-" + dtpIngreso.Value.Day);


                    this.Close();



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al guardar: Historial " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos para poder agregar un camion nuevo", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Clic Cancelar 

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Metodo para validar texbox
        public bool validarTextBoxs()
        {

            bool ok = true;

            if(txtTrasporte1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTrasporte1, "Ingrese trasporte");
            }
            if(txtPatenteTractor1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPatenteTractor1, "Ingrese patente tractor");
            }
            if(txtPatenteSemi1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPatenteSemi1, "Ingrese patente semi");
            }
            if(txtProveedor1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProveedor1, "Ingrese proveedor");
            }
            if(txtNombreChofer1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreChofer1, "Ingrese nombre de chofer");
            }
            if(txtApellidoChofer1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellidoChofer1, "Ingrese apellido chofer");
            }
            if(txtDniChofer1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDniChofer1, "Ingrese dni chofer");
            }

           return ok;
        }



        #endregion

        #region Validar que no hayan espacios en patentes camion

        private void txtPatenteTractor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            
        }

        #endregion

        #region Validar que no hayan espacios en patentes acoplado

        private void txtPatenteSemi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            
        }



        #endregion

    }
}
