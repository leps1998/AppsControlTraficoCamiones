using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;

namespace AppControlTraficoPorteria
{
    
    public partial class CompletarInfoCamion : MaterialForm
    {
        private int? Id;
        private string? Patente;


        public void CamionPatente(string? unPatente)
        {
            Patente = unPatente;
        }

        public void CamionId(int? unId)
        {
            Id = unId;
        }

        public CompletarInfoCamion(int? Id = null)
        {
            InitializeComponent();

            dtpSalida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpSalida.Format = DateTimePickerFormat.Custom;
            dtpSalida.Value = DateTime.Now;

            this.Id = Id;
            if (this.Id != null)
            {
                LoadData();
            }


        }


        private void LoadData()
        {
            CamionesDB oCamionesDB = new CamionesDB();
            CamionDB oCamionDB = oCamionesDB.Get((int)Id);
            txtNRemito1.Text = oCamionDB.RemitoNro.ToString();
            txtHojaRuta1.Text = oCamionDB.HojaDeRuta.ToString();
            txtPrecintos1.Text = oCamionDB.Precintos.ToString();
            txtDestino1.Text = oCamionDB.Destino.ToString();
            txtObservaciones1.Text = oCamionDB.Observaciones.ToString();

            

        }



        private void CompletarInfoCamion_Load(object sender, EventArgs e)
        {

            MessageBox.Show($"Se va a modificar camion", "Modificar camion", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }


        #region clic boton completar

        private void btnCompletar1_Click(object sender, EventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();

                        
            try
            {

                oCamionesDB.AgregarInfoFinal(Convert.ToDateTime(dtpSalida.Value),txtNRemito1.Text, txtHojaRuta1.Text,
                    txtPrecintos1.Text, txtDestino1.Text, txtObservaciones1.Text, Id);

                this.Close();

                MessageBox.Show($"Se completo la informacion del camion ", "Informacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra: 1234 " + ex.Message);
            }
            


            CamionesDB oCamionesDBH = new CamionesDB();
            
            try
            {

                oCamionesDB.AgregarInfoFinalHistorial(Convert.ToDateTime(dtpSalida.Value),txtNRemito1.Text,
                    txtHojaRuta1.Text, txtPrecintos1.Text, txtDestino1.Text, txtObservaciones1.Text, Id);

                this.Close();


            }
            catch (Exception ex)
            {

            }
        }





        #endregion

 
    }
}
