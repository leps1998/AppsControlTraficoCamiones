using AppControlTraficoLogistica.Controlador;
using MaterialSkin;
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
    public partial class Form1 : MaterialForm
    {

        public Form1()    
        {
            
            InitializeComponent();

            

            label2.Text = $"Usuario activo: {UsuarioLogeado()}";

            if (TipoUsuarioLogeado() == "administrador")
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        #region Metodo para ver usuario Logueado

        public string? UsuarioLogeado()
        {
            string usuarioLogeado = "";
            try
            {
                CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
                DataTable dt = oCamionesLogisticaDB.VerUsuarioLogeado();
                DataRow row = dt.Rows[0];

                usuarioLogeado = Convert.ToString(row["Nombre"]);
                return usuarioLogeado;
            }
            catch (Exception)
            {

                
            }

            return usuarioLogeado;
          
        }

        #endregion

        #region Metodo para ver tipo de usuario logueado

        public string? TipoUsuarioLogeado()
        {
            string tipoUsuarioLogeado = "";
            try
            {
                CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
                DataTable dt = oCamionesLogisticaDB.VerUsuarioLogeado();
                DataRow? row = dt.Rows[0];

                tipoUsuarioLogeado = Convert.ToString(row["TipoUsuario"]);
                
            }
            catch (Exception)
            {

                
            }
            return tipoUsuarioLogeado;

        }

        #endregion


        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            oCamionesLogisticaDB.CerrarSesion(false, UsuarioLogeado());
        }


        private void crearUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
            crearUsuario.Dispose();
        }

        private void editarEliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.ShowDialog();
            editarUsuario.Dispose();
        }

        private void btnCamion1_Click(object sender, EventArgs e)
        {
            Camion oCamion = new Camion();
            oCamion.ShowDialog();
            oCamion.Dispose();
        }

        private void btnHistorialCamiones_Click(object sender, EventArgs e)
        {
            HistorialCamiones oHistorialCamiones = new HistorialCamiones();
            oHistorialCamiones.ShowDialog();
            oHistorialCamiones.Dispose();
        }


    }
}
