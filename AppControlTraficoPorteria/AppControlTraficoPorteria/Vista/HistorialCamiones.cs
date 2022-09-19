using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace AppControlTraficoPorteria
{

    public partial class HistorialCamiones : MaterialForm
    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";
        public HistorialCamiones()
        {
            InitializeComponent();
        }

        #region Ajuste a pantalla

        private Rectangle dgv;
        private Rectangle lbl;
        private Rectangle olblBuscar;
        private Rectangle otxtBuscar;
        private Rectangle olblTipo;
        private Rectangle ocmbTipo;
        private Rectangle obtnRefresacar;
        private Rectangle obtnBuscar;
        private Rectangle olblFecha;
        private Rectangle odtpBuscar;
        private Rectangle optbBerry;
        private Rectangle originalFormSize;
        private Rectangle lblHasta;
        private Rectangle dtpHasta;

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void HistorialCamiones_Resize(object sender, EventArgs e)
        {
            resizeControl(dgv, dgvHistorialCamiones);
            resizeControl(lbl, lblHistorial1);
            resizeControl(olblBuscar, lblBuscar);
            resizeControl(otxtBuscar, txtBuscar);
            resizeControl(olblTipo, lblTipo1);
            resizeControl(ocmbTipo, cmbTipo1);
            resizeControl(obtnRefresacar, btnRefrescar1);
            resizeControl(obtnBuscar, btnBuscar1);
            resizeControl(olblFecha, lblFecha);
            resizeControl(odtpBuscar, dtpBuscarDesde);
            resizeControl(optbBerry, ptbBerry1);
            resizeControl(lblHasta, lblFechaHasta);
            resizeControl(dtpHasta, dtpBuscarHasta);
        }

        #endregion

        private void HistorialCamiones_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            dgv = new Rectangle(dgvHistorialCamiones.Location.X, dgvHistorialCamiones.Location.Y, dgvHistorialCamiones.Width, dgvHistorialCamiones.Height);
            lbl = new Rectangle(lblHistorial1.Location.X, lblHistorial1.Location.Y, lblHistorial1.Width, lblHistorial1.Height);
            olblBuscar = new Rectangle(lblBuscar.Location.X, lblBuscar.Location.Y, lblBuscar.Width, lblBuscar.Height);
            otxtBuscar = new Rectangle(txtBuscar.Location.X, txtBuscar.Location.Y, txtBuscar.Width, txtBuscar.Height);
            olblTipo = new Rectangle(lblTipo1.Location.X, lblTipo1.Location.Y, lblTipo1.Width, lblTipo1.Height);
            ocmbTipo = new Rectangle(cmbTipo1.Location.X, cmbTipo1.Location.Y, cmbTipo1.Width, cmbTipo1.Height);
            obtnRefresacar = new Rectangle(btnRefrescar1.Location.X, btnRefrescar1.Location.Y, btnRefrescar1.Width, btnRefrescar1.Height);
            obtnBuscar = new Rectangle(btnBuscar1.Location.X, btnBuscar1.Location.Y, btnBuscar1.Width, btnBuscar1.Height);
            olblFecha = new Rectangle(lblFecha.Location.X, lblFecha.Location.Y, lblFecha.Width, lblFecha.Height);
            odtpBuscar = new Rectangle(dtpBuscarDesde.Location.X, dtpBuscarDesde.Location.Y, dtpBuscarDesde.Width, dtpBuscarDesde.Height);
            optbBerry = new Rectangle(ptbBerry1.Location.X, ptbBerry1.Location.Y, ptbBerry1.Width, ptbBerry1.Height);
            lblHasta = new Rectangle(lblFechaHasta.Location.X, lblFechaHasta.Location.Y, lblFechaHasta.Width, lblFechaHasta.Height);
            dtpHasta = new Rectangle(dtpBuscarHasta.Location.X, dtpBuscarHasta.Location.Y, dtpBuscarHasta.Width, dtpBuscarHasta.Height);
            this.WindowState = FormWindowState.Maximized;
            Refrescar();
        }

        #region Busqueda

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (cmbTipo1.Text == "Transporte")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                    " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                    " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                    " PesoNeto, PesoPallets, Dock, Observaciones" +
                    " FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Patente Tractor")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM HistorialCamiones WHERE patenteTractor LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Patente Semi")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM HistorialCamiones WHERE PatenteSemi LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Destino")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM HistorialCamiones WHERE Destino LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Numero de remito")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM HistorialCamiones WHERE RemitoNro LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }

            }
        }

        private void cmbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo1.Text)
            {
                case "Arribo":
                case "Salida":
                    dtpBuscarDesde.Visible = true;
                    txtBuscar.Visible = false;
                    btnBuscar1.Visible = true;
                    lblBuscar.Visible = false;
                    lblFecha.Visible = true;
                    lblFechaHasta.Visible = true;
                    dtpBuscarHasta.Visible = true;
                    break;
                default:
                    dtpBuscarDesde.Visible = false;
                    txtBuscar.Visible = true;
                    btnBuscar1.Visible = false;
                    lblBuscar.Visible = true;
                    lblFecha.Visible = false;
                    lblFechaHasta.Visible = false;
                    dtpBuscarHasta.Visible = false;
                    break;
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            getCamionesFechas();
        }

        private void getCamionesFechas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (cmbTipo1.Text == "Arribo")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarArriboLogisticaCH", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvHistorialCamiones.DataSource = dt;
                }
                else if (cmbTipo1.Text == "Salida")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarSalidaPorteriaCH", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvHistorialCamiones.DataSource = dt;
                }


            }

        }

        #endregion

        #region Refrescar 
        public void Refrescar()
        {
            CamionesDB oCamionesDB = new CamionesDB();
            dgvHistorialCamiones.DataSource = oCamionesDB.VerHistorialCamiones();
        }


        #endregion

        #region Click boton refrescar


        private void btnRefrescar1_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        #endregion


    }
}
