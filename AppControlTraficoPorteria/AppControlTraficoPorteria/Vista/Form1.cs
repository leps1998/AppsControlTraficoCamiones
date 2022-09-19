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

namespace AppControlTraficoPorteria
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            
            label.Text = $"Usuario activo: {UsuarioLogeado()}";

            #region Color forma

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Blue100, TextShade.WHITE);

            #endregion
        }

        #region clic Camion

        private void btnCamion1_Click(object sender, EventArgs e)
        {
            Camion oNuevoCamion = new Camion();

            oNuevoCamion.ShowDialog();

            oNuevoCamion.Dispose();
        }

        #endregion

        #region clic Historial camiones
        private void btnHistorialCamines1_Click(object sender, EventArgs e)
        {
            HistorialCamiones oHistorialCamiones = new HistorialCamiones();

            oHistorialCamiones.ShowDialog();

            oHistorialCamiones.Dispose();

        }


        #endregion

        #region Metodo para ver usuario Logueado

        public string? UsuarioLogeado()
        {
            string usuarioLogeado = "";
            try
            {
                CamionesDB oCamionesDB = new CamionesDB();
                DataTable dt = oCamionesDB.VerUsuarioLogeado();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();
            oCamionesDB.CerrarSesion(false, UsuarioLogeado());
        }
    }
}
