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
    public partial class CargaBrutoNeto : MaterialForm
    {
        private int? Id;
        private double PesoKgHojaDeRuta;
        private double PesoTara;

        public void CamionId(int? unId)
        {
            Id = unId;
        }

        public void LoadPesos()
        {
            CamionesDB camionesDB = new CamionesDB();
            CamionDB camionDB = camionesDB.GetPesoKgHojaDeRutaTara((int)Id);
            PesoKgHojaDeRuta = Convert.ToDouble(camionDB.PesoKgHojaRuja);
            PesoTara = Convert.ToDouble(camionDB.PesoTara);
        }

        public CargaBrutoNeto()
        {
            InitializeComponent();
        }

        #region click en boton cargar
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();

            double pesoBruto = 0.0;
            double PesoNeto = 0.0;


            if (!Double.TryParse(txtPesoBruto1.Text, out pesoBruto))
            {

            }

            if (!Double.TryParse(txtPesoNeto1.Text, out PesoNeto))
            {

            }

            try
            {
                oCamionesDB.CargarPesoBrutoNeto(pesoBruto, PesoNeto, Id);

                this.Close();

                MessageBox.Show($"Se completo la informacion del camion ", "Informacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra: 1234 " + ex.Message);
            }

            double pesoBrutoH = 0.0;
            double PesoNetoH = 0.0;


            if (!Double.TryParse(txtPesoBruto1.Text, out pesoBrutoH))
            {

            }

            if (!Double.TryParse(txtPesoNeto1.Text, out PesoNetoH))
            {

            }

            CamionesDB oCamionesDBH = new CamionesDB();

            try
            {
                oCamionesDBH.CargarPesoBrutoNetoH(pesoBrutoH, PesoNetoH, Id);
            }
            catch (Exception)
            {

                
            }
        }

        #endregion

        #region Calculo de Peso Bruto

        public double PesoBruto(double n1, double n2, double n3)
        {
            double resultado = (n1 - n2) - n3;
            return resultado;

        }

        private void txtPesoBruto1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double texb1 = Double.Parse(txtPesoBruto1.Text.ToString());
                double texb2 = PesoTara;
                double texb3 = PesoKgHojaDeRuta;
                double resultado = PesoBruto(texb1, texb2, (double)texb3);
                txtPesoNeto1.Text = resultado.ToString();
            }
            catch (Exception)
            {


            }
        }



        #endregion

        #region Validar que no hayan espacios
        private void txtPesoBruto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        #endregion
    }
}
