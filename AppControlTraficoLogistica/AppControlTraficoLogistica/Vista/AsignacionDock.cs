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
    public partial class AsignacionDock : MaterialForm
    {
        private int Id;
        private int dock1;
        private bool cambio = false;

        #region Id camion a modificar
        public int? CamionId()
        {

            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            DataTable dt = oCamionesLogisticaDB.VerFlagPorteria();
            DataRow row = dt.Rows[0];

            Id = Convert.ToInt32(row["id"]);
            return Id;
        }

        #endregion


        public AsignacionDock()
        {
            InitializeComponent();
        }


        #region Metodo para evitar que cierre el asignacion de dock sin haber asignado dock
        private void AsignacionDock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambio == false)
            {
                DialogResult res = MessageBox.Show("Debes asignar en dock al camion que viene", "Asignar dock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (res == DialogResult.OK)
                    e.Cancel = true;
            }
        }
        #endregion

        #region Metodo para verificar si selecciono algun dock

        private void cmbDock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dock1 = cmbDock1.SelectedIndex;

            switch (dock1)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    cambio = true;
                    break;
                default:
                    cambio = false;
                    break;
            }
        }

        #endregion

        #region Click en boton asignar camion

        private void btnAsignarDock1_Click(object sender, EventArgs e)
        {
            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();


            try
            {

                oCamionesLogisticaDB.enviarDock(true, false, cmbDock1.Text, CamionId());
                this.Close();

                MessageBox.Show($"Se le asigino el {cmbDock1.Text} al camion ", "Dock asignado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar info extra: " + ex.Message);
            }
        }


        #endregion


    }
}
