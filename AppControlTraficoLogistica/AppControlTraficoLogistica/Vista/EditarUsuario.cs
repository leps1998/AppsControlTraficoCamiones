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
    public partial class EditarUsuario : MaterialForm
    {
        public EditarUsuario()
        {
            InitializeComponent();
            Refrescar();
        }

        #region Metodo refrescar
        public void Refrescar()
        {
            CamionesLogisticaDB oCamionesDB = new CamionesLogisticaDB();
            dgvUsuarios.DataSource = oCamionesDB.VerUsuarios();
        }
        #endregion

        private void btnElimi_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        #region Helper para regresar ID

        public int? GetId()
        {
            try
            {
                int rowIndex = dgvUsuarios.CurrentRow.Index;
                int id = Convert.ToInt32(dgvUsuarios.Rows[rowIndex].Cells[0].Value);
                return id;

            }
            catch
            {

                return null;
            }

        }

        #endregion

        private void btnElimi1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar usuario?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {
                int? Id = GetId();
                try
                {
                    CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
                    oCamionesLogisticaDB.EliminarUsuario((int)Id);
                    MessageBox.Show("Usuario eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Refrescar();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                CrearUsuario frmEdit = new CrearUsuario(Id);
                frmEdit.ShowDialog();
                Refrescar();
            }
        }
    }
}
