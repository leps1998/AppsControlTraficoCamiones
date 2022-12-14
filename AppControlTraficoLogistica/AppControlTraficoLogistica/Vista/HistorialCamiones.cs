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
using AppControlTraficoLogistica.Controlador;

namespace AppControlTraficoLogistica
{
    public partial class HistorialCamiones : MaterialForm
    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";

        public HistorialCamiones( )
        {
            InitializeComponent();

        }


        #region Ajuste a pantalla

        private Rectangle dgv;
        private Rectangle lblC;
        private Rectangle olblBuscar;
        private Rectangle otxtBuscar;
        private Rectangle lblHasta;
        private Rectangle dtpHasta;
        private Rectangle ocmbTipo;
        private Rectangle obtnRefresacar;
        private Rectangle obtnBuscar;
        private Rectangle olblFecha;
        private Rectangle odtpBuscar;
        private Rectangle optbBerry;
        private Rectangle lblBuscarCamionA;
        private Rectangle originalFormSize;


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
            resizeControl(lblC, label1);
            resizeControl(olblBuscar, lblBuscar);
            resizeControl(otxtBuscar, txtBuscar);
            resizeControl(lblHasta, lblFechaHasta);
            resizeControl(dtpHasta, dtpBuscarHasta);
            resizeControl(ocmbTipo, cmbTipoBusqueda);
            resizeControl(obtnRefresacar, btnRefrescar1);
            resizeControl(obtnBuscar, btnBuscar1);
            resizeControl(olblFecha, lblFecha);
            resizeControl(odtpBuscar, dtpBuscarDesde);
            resizeControl(optbBerry, ptbBerry);
            resizeControl(lblBuscarCamionA, lblBuscarCamion);
        }


        #endregion

        private void HistorialCamiones_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            dgv = new Rectangle(dgvHistorialCamiones.Location.X, dgvHistorialCamiones.Location.Y, dgvHistorialCamiones.Width, dgvHistorialCamiones.Height);
            lblC = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            olblBuscar = new Rectangle(lblBuscar.Location.X, lblBuscar.Location.Y, lblBuscar.Width, lblBuscar.Height);
            otxtBuscar = new Rectangle(txtBuscar.Location.X, txtBuscar.Location.Y, txtBuscar.Width, txtBuscar.Height);
            ocmbTipo = new Rectangle(cmbTipoBusqueda.Location.X, cmbTipoBusqueda.Location.Y, cmbTipoBusqueda.Width, cmbTipoBusqueda.Height);
            obtnRefresacar = new Rectangle(btnRefrescar1.Location.X, btnRefrescar1.Location.Y, btnRefrescar1.Width, btnRefrescar1.Height);
            obtnBuscar = new Rectangle(btnBuscar1.Location.X, btnBuscar1.Location.Y, btnBuscar1.Width, btnBuscar1.Height);
            olblFecha = new Rectangle(lblFecha.Location.X, lblFecha.Location.Y, lblFecha.Width, lblFecha.Height);
            odtpBuscar = new Rectangle(dtpBuscarDesde.Location.X, dtpBuscarDesde.Location.Y, dtpBuscarDesde.Width, dtpBuscarDesde.Height);
            optbBerry = new Rectangle(ptbBerry.Location.X, ptbBerry.Location.Y, ptbBerry.Width, ptbBerry.Height);
            lblHasta = new Rectangle(lblFechaHasta.Location.X, lblFechaHasta.Location.Y, lblFechaHasta.Width, lblFechaHasta.Height);
            dtpHasta = new Rectangle(dtpBuscarHasta.Location.X, dtpBuscarHasta.Location.Y, dtpBuscarHasta.Width, dtpBuscarHasta.Height);
            lblBuscarCamionA = new Rectangle(lblBuscarCamion.Location.X, lblBuscarCamion.Location.Y, lblBuscarCamion.Width, lblBuscarCamion.Height);
            this.WindowState = FormWindowState.Maximized;
            Refrescar();
        }

        #region Metodo refrescar
        public void Refrescar()
        {
            CamionesLogisticaDB oCamionesDB = new CamionesLogisticaDB();
            dgvHistorialCamiones.DataSource = oCamionesDB.VerHistorialDeCamiones();
        }
        #endregion

        #region Buscar

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (cmbTipoBusqueda.Text == "Transporte")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Patente Tractor")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Patente Semi")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Destino")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Numero de remito")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM HistorialCamiones WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvHistorialCamiones.DataSource = dt;

                    connection.Close();
                }

            }
        }

        private void cmbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoBusqueda.Text)
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
                if (cmbTipoBusqueda.Text == "Arribo")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarArriboLogisticaCH", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvHistorialCamiones.DataSource = dt;
                }
                else if (cmbTipoBusqueda.Text == "Salida")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarSalidaLogisticaCH", connection);
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

        #region click boton refrescar
        private void btnRefrescar1_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        #endregion


    }
}


