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
    public partial class EditarCamion : MaterialForm
    {
        private int? Id;
        private double PesoKgHojaDeRuta;
        private double PesoTara;

        public void CamionId(int? unId)
        {
            Id = unId;
        }

        public EditarCamion(int? Id = null)
        {
            InitializeComponent();

            dtpSalida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpSalida.Format = DateTimePickerFormat.Custom;
            dtpSalida.Value = DateTime.Now;

            this.Id = Id;
            if (this.Id != null)
            {
                LoadData();
                LoadPesos();
                
            }
        }

        private void LoadData()
        {
            CamionesDB oCamionesDB = new CamionesDB();
            CamionDB oCamionDB = oCamionesDB.GetInfo((int)Id);
            txtTrasporte1.Text = oCamionDB.Transporte.ToString();
            txtPatenteTractor1.Text = oCamionDB.PatenteTractor.ToString();
            txtPatenteSemi1.Text = oCamionDB.PatenteSemi.ToString();
            txtNRemito1.Text = oCamionDB.RemitoNro.ToString();
            txtHojaRuta1.Text = oCamionDB.HojaDeRuta.ToString();
            txtPrecintos1.Text = oCamionDB.Precintos.ToString();
            txtDestino1.Text = oCamionDB.Destino.ToString();
            txtObservaciones1.Text = oCamionDB.Observaciones.ToString();
            txtProveedor1.Text = oCamionDB.Proveedor.ToString();
            txtNombreChofer1.Text = oCamionDB.NombreChofer.ToString();
            txtApellidoChofer1.Text = oCamionDB.ApellidoChofer.ToString();
            txtDniChofer1.Text = oCamionDB.DniChofer.ToString();
            txtPesoTara1.Text = oCamionDB.PesoTara.ToString();
            txtPesoBruto1.Text = oCamionDB.PesoBruto.ToString();
            

        }

        public void LoadPesos()
        {
            CamionesDB camionesDB = new CamionesDB();
            CamionDB camionDB = camionesDB.GetPesoKgHojaDeRutaTara((int)Id);
            PesoKgHojaDeRuta = Convert.ToDouble(camionDB.PesoKgHojaRuja);
            PesoTara = Convert.ToDouble(camionDB.PesoTara);
        }

        #region Calculo de Peso Bruto

        public double PesoBruto(double n1, double n2, double n3)
        {
            double resultado = (n1 - n2) - n3;
            return resultado;

        }

        private void txtPesoBruto1_TextChanged(object sender, EventArgs e)
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

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();

            double pesoBruto = 0.0;
            double pesoNeto = 0.0;
            double pesoTara = 0.0;


            if (!Double.TryParse(txtPesoBruto1.Text, out pesoBruto))
            {

            }

            if (!Double.TryParse(txtPesoNeto1.Text, out pesoNeto))
            {

            }

            if (!Double.TryParse(txtPesoTara1.Text, out pesoTara))
            {

            }


            try
            {
                oCamionesDB.EditarTotal(txtTrasporte1.Text, txtPatenteTractor1.Text, txtPatenteSemi1.Text, txtNRemito1.Text,
                    txtHojaRuta1.Text, txtPrecintos1.Text, txtDestino1.Text, txtObservaciones1.Text, txtProveedor1.Text,
                    txtNombreChofer1.Text, txtApellidoChofer1.Text, txtDniChofer1.Text, pesoTara, pesoBruto, pesoNeto, Convert.ToDateTime(dtpSalida.Value), Id);


                this.Close();

                MessageBox.Show($"Se completo la informacion del camion ", "Informacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra: 1234 " + ex.Message);
            }


            CamionesDB oCamionesDBH = new CamionesDB();

            double pesoBrutoH = 0.0;
            double pesoNetoH = 0.0;
            double pesoTaraH = 0.0;


            if (!Double.TryParse(txtPesoBruto1.Text, out pesoBruto))
            {

            }

            if (!Double.TryParse(txtPesoNeto1.Text, out pesoNeto))
            {

            }

            if (!Double.TryParse(txtPesoTara1.Text, out pesoTara))
            {

            }


            try
            {
                oCamionesDB.EditarTotalH(txtTrasporte1.Text, txtPatenteTractor1.Text, txtPatenteSemi1.Text, txtNRemito1.Text,
                    txtHojaRuta1.Text, txtPrecintos1.Text, txtDestino1.Text, txtObservaciones1.Text, txtProveedor1.Text,
                    txtNombreChofer1.Text, txtApellidoChofer1.Text, txtDniChofer1.Text, pesoTaraH, pesoBrutoH, pesoNetoH, Convert.ToDateTime(dtpSalida.Value), Id);


                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra: 1234 " + ex.Message);
            }
        }

        private void txtPatenteTractor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtPatenteSemi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtPesoTara1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtPesoBruto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    }
}
