using AppControlTraficoLogistica.Controlador;
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
using System.Xml.Linq;

namespace AppControlTraficoLogistica
{
    public partial class CrearUsuario : MaterialForm
    {
        private string Contraseña;
        private int? Id;

        public CrearUsuario(int? Id = null)
        {
            InitializeComponent();

            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            Usuario oUsuario = oCamionesLogisticaDB.GetUsuario((int)Id);
            txtNombre1.Text = oUsuario.Nombre;
            txtUsuario1.Text = oUsuario.Usuario1;
            
        }



        private void btnCrear1_Click(object sender, EventArgs e)
        {
            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();

            try
            {
                if (Id == null)
                {
                    if (txtContraseña1.Text == txtConfirmarContraseña1.Text)
                    {
                        Contraseña = txtConfirmarContraseña1.Text;

                        oCamionesLogisticaDB.AgregarUsuario(txtNombre1.Text, txtUsuario1.Text, Contraseña, cmbTipoUsuario1.Text);

                        MessageBox.Show(" Usuario creado ", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (txtContraseña1.Text == txtConfirmarContraseña1.Text)
                    {
                        Contraseña = txtConfirmarContraseña1.Text;
                    }

                    oCamionesLogisticaDB.Update(txtNombre1.Text, txtUsuario1.Text, Contraseña, cmbTipoUsuario1.Text, (int)Id);

                    MessageBox.Show(" Se modifico el usuario ", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar 1234" + ex.Message);
            }

        }


        private void txtConfirmarContraseña1_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == txtConfirmarContraseña1.Text)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
