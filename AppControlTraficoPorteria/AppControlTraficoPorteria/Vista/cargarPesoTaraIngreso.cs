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
    public partial class cargarPesoTaraIngreso : MaterialForm
    {

        private int? Id;

        public void CamionId(int? unId)
        {
            Id = unId;
        }

        public cargarPesoTaraIngreso()
        {
            InitializeComponent();
            dtpIngreso.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpIngreso.Format = DateTimePickerFormat.Custom;
            dtpIngreso.Value = DateTime.Now;
        }

        #region click en boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();

            double pesoTara = 0.0;

            if (!Double.TryParse(txtPesoTara1.Text, out pesoTara))
            {

            }


            try
            {
                
                oCamionesDB.CargarIngresoPesoTara(pesoTara, Convert.ToDateTime(dtpIngreso.Value), "", "", "", "", "",  Id);
                this.Close();

                MessageBox.Show($"Se completo la informacion del camion ", "Informacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra " + ex.Message);
            }

            double pesoTaraH = 0.0;

            if (!Double.TryParse(txtPesoTara1.Text, out pesoTaraH))
            {

            }


            CamionesDB oCamionesDBH = new CamionesDB();

            try
            {
                oCamionesDBH.CargarIngresoPesoTaraH(pesoTaraH, Convert.ToDateTime(dtpIngreso.Value), Id);
                this.Close();

                
            }
            catch (Exception)
            {

                
            }
        }

        #endregion



        #region Validar que no hayan espacios

        private void txtPesoTara1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            
        }

        #endregion
    }
}
