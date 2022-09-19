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
    public partial class inicio : MaterialForm

    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";

        public inicio()
        {
            InitializeComponent();

            #region Color forma

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Blue100, TextShade.WHITE);

            #endregion
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            CamionesDB db = new CamionesDB();
            db.Loguear(txtUsuario.Text, txtContraseña.Text);

            txtContraseña.Clear();
        }

        #region Metodo para ver contraseña
        private void chbVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerContraseña.Checked == true)
            {
                txtContraseña.Password = false;

            }
            else
            {
                txtContraseña.Password = true;
            }
        }
        #endregion
    }
}
