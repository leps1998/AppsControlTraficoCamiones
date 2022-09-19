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

namespace AppControlTraficoLogistica
{
    public partial class CompletarCamion : MaterialForm
    {

        private int? Id;
        private string Patente;
        

        #region Metodo para ver usuario Logueado

        public string? UsuarioLogeado()
        {

            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            DataTable dt = oCamionesLogisticaDB.VerUsuarioLogeado();
            DataRow row = dt.Rows[0];

            string usuarioLogeado = Convert.ToString(row["Nombre"]);
            return usuarioLogeado;
        }

        #endregion

        public void CamionPatente(string? unPatente)
        {
            Patente = unPatente;
        }

        public void CamionId(int? unId)
        {
            Id = unId;
        }


        public CompletarCamion(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if(this.Id != null)
            {
                LoadData();
            }
            
        }

        
        private void LoadData()
        {
            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            CamionDB oCamionDB = oCamionesLogisticaDB.Get((int)Id);
            txtPesoKgHojaRuta1.Text = oCamionDB.PesoKgHojaRuta.ToString();
            txtPesoPallets1.Text = oCamionDB.PesoPallets.ToString();
            
            
        }

        #region Click agregar

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            double pesoKgHojaRuta = 0.0;
            double pesoPallets = 0.0;
            bool estaOkParaProcesar = true;

            if (!Double.TryParse(txtPesoKgHojaRuta1.Text, out pesoKgHojaRuta))
            {
                estaOkParaProcesar = false;
            }

            if (!Double.TryParse(txtPesoPallets1.Text, out pesoPallets))
            {
                estaOkParaProcesar = false;
            }

            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            if (estaOkParaProcesar)
            {
                try
                {

                    oCamionesLogisticaDB.completarCamion(pesoKgHojaRuta, pesoPallets, Id, UsuarioLogeado());

                    this.Close();

                    MessageBox.Show($"Se completo la informacion del camion con patente: {Patente}", "Informacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al guardar info extra: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Error de dato verifique datos ingresados");

            //----------------------------------------------------------------

            double pesoKgHojaRutaH = 0.0;
            double pesoPalletsH = 0.0;
            bool estaOkParaProcesarH = true;

            if (!Double.TryParse(txtPesoKgHojaRuta1.Text, out pesoKgHojaRutaH))
            {
                estaOkParaProcesarH = false;
            }

            if (!Double.TryParse(txtPesoPallets1.Text, out pesoPalletsH))
            {
                estaOkParaProcesarH = false;
            }

            CamionesLogisticaDB oCamionesLogisticaDBH = new CamionesLogisticaDB();
            if (estaOkParaProcesar)
            {
                try
                {

                    oCamionesLogisticaDBH.completarCamionHisto(pesoKgHojaRutaH, pesoPalletsH, Id, UsuarioLogeado());

                    this.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al guardar info extra: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Error de dato verifique datos ingresados");
        }

        #endregion

        private void CompletarCamion_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Se va a modificar camion", "Modificar camion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        
    }
}
