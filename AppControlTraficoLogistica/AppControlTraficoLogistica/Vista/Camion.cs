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
using System.Xml.Serialization;
using AppControlTraficoLogistica.Controlador;

namespace AppControlTraficoLogistica
{
    public partial class Camion : MaterialForm
    {

        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";


        public Camion()
        {
            InitializeComponent();

        }


        #region Ajuste de pantalla

        private Rectangle botonCompletarCamion;
        private Rectangle botonEditarCamion;
        private Rectangle dgv;
        private Rectangle lblC;
        private Rectangle olblBuscar;
        private Rectangle otxtBuscar;
        private Rectangle lblHasta;
        private Rectangle dtpHasta;


        private Rectangle cmbTipoBusquedaA;
        private Rectangle obtnRefresacar;
        private Rectangle obtnBuscar;
        private Rectangle olblFecha;
        private Rectangle odtpBuscar;
        private Rectangle optbBerry;


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

        private void Camion_Resize(object sender, EventArgs e)
        {
            resizeControl(botonCompletarCamion, btnCompletarCamion1);
            resizeControl(botonEditarCamion, btnEditarCamion1);
            resizeControl(dgv, dgvCamionesCurso);
            resizeControl(lblC, label1);
            resizeControl(olblBuscar, lblBuscar);
            resizeControl(otxtBuscar, txtBuscar);
            resizeControl(lblHasta, lblFechaHasta);
            resizeControl(dtpHasta, dtpBuscarHasta);


            resizeControl(obtnRefresacar, btnRefrescar1);
            resizeControl(obtnBuscar, btnBuscar1);
            resizeControl(olblFecha, lblFechaDesde);
            resizeControl(odtpBuscar, dtpBuscarDesde);
            resizeControl(optbBerry, ptbBerry);
            resizeControl(cmbTipoBusquedaA, cmbTipoBusqueda);
        }

        #endregion

        #region Timmer

        private void timer1_Tick(object sender, EventArgs e)
        {

            CamionesLogisticaDB oCamionesLogisticaDB = new CamionesLogisticaDB();
            
            int id;
            bool flagPorteria;
            string patente;

            try
            {
                DataTable dt = oCamionesLogisticaDB.VerFlagPorteria();
                DataRow row = dt.Rows[0];

                id = Convert.ToInt32(row["id"]);
                flagPorteria = Convert.ToBoolean(row["FlagPorteria"]);
                patente = Convert.ToString(row["PatenteTractor"]);



                if (flagPorteria)
                {
                    timer1.Enabled = false;
                    MessageBox.Show($"El camion con patente: {patente} esta esperando asignación de Dock", "Camion esperando", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    AsignacionDock oAsignacionDock = new AsignacionDock();
                    oAsignacionDock.ShowDialog();
                    oAsignacionDock.Dispose();
                
                }
            }
            catch (Exception)
            {


            }


            dgvCamionesCurso.ClearSelection();
            Refrescar();
            timer1.Enabled = true;
        }

        #endregion


        private void Camion_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            botonCompletarCamion = new Rectangle(btnCompletarCamion1.Location.X, btnCompletarCamion1.Location.Y, btnCompletarCamion1.Width, btnCompletarCamion1.Height);
            botonEditarCamion = new Rectangle(btnEditarCamion1.Location.X, btnEditarCamion1.Location.Y, btnEditarCamion1.Width, btnEditarCamion1.Height);
            dgv = new Rectangle(dgvCamionesCurso.Location.X, dgvCamionesCurso.Location.Y, dgvCamionesCurso.Width, dgvCamionesCurso.Height);
            lblC = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            olblBuscar = new Rectangle(lblBuscar.Location.X, lblBuscar.Location.Y, lblBuscar.Width, lblBuscar.Height);
            otxtBuscar = new Rectangle(txtBuscar.Location.X, txtBuscar.Location.Y, txtBuscar.Width, txtBuscar.Height);
            lblHasta = new Rectangle(lblFechaHasta.Location.X, lblFechaHasta.Location.Y, lblFechaHasta.Width, lblFechaHasta.Height);
            dtpHasta = new Rectangle(dtpBuscarHasta.Location.X, dtpBuscarHasta.Location.Y, dtpBuscarHasta.Width, dtpBuscarHasta.Height);
            obtnRefresacar = new Rectangle(btnRefrescar1.Location.X, btnRefrescar1.Location.Y, btnRefrescar1.Width, btnRefrescar1.Height);
            obtnBuscar = new Rectangle(btnBuscar1.Location.X, btnBuscar1.Location.Y, btnBuscar1.Width, btnBuscar1.Height);
            olblFecha = new Rectangle(lblFechaDesde.Location.X, lblFechaDesde.Location.Y, lblFechaDesde.Width, lblFechaDesde.Height);
            odtpBuscar = new Rectangle(dtpBuscarDesde.Location.X, dtpBuscarDesde.Location.Y, dtpBuscarDesde.Width, dtpBuscarDesde.Height);
            optbBerry = new Rectangle(ptbBerry.Location.X, ptbBerry.Location.Y, ptbBerry.Width, ptbBerry.Height);
            cmbTipoBusquedaA = new Rectangle(cmbTipoBusqueda.Location.X, cmbTipoBusqueda.Location.Y, cmbTipoBusqueda.Width, cmbTipoBusqueda.Height);
            this.WindowState = FormWindowState.Maximized;
            Refrescar();
        }

        #region Metodo refrescar
        public void Refrescar()
        {
            CamionesLogisticaDB oCamionesDB = new CamionesLogisticaDB();
            dgvCamionesCurso.DataSource = oCamionesDB.VerCamionesCurso();
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
                    " Usuario FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Patente Tractor")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Patente Semi")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Destino")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipoBusqueda.Text == "Numero de remito")
                {

                    cmd.CommandText = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                    " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                    " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones," +
                    " Usuario FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

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
                    lblFechaDesde.Visible = true;
                    lblFechaHasta.Visible = true;
                    dtpBuscarHasta.Visible = true;
                    break;
                default:
                    dtpBuscarDesde.Visible = false;
                    txtBuscar.Visible = true;
                    btnBuscar1.Visible = false;
                    lblBuscar.Visible = true;
                    lblFechaDesde.Visible = false;
                    lblFechaHasta.Visible = false;
                    dtpBuscarHasta.Visible = false;
                    break;
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            getCamionesFechas();

            
        }

        //Metodo para buscar por fechas
        private void getCamionesFechas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (cmbTipoBusqueda.Text == "Arribo")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarArriboLogisticaCC", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvCamionesCurso.DataSource = dt;
                }
                else if (cmbTipoBusqueda.Text == "Salida")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarSalidaLogisticaCC", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvCamionesCurso.DataSource = dt;
                }


            }
                
        }


        #endregion

        #region Click en boton completar camion

        private void btnCompletarCamion1_Click(object sender, EventArgs e)
        {
            CompletarCamion oCompletarCamion = new CompletarCamion();
            oCompletarCamion.CamionId(GetId());
            oCompletarCamion.CamionPatente(GetPatente());
            oCompletarCamion.ShowDialog();
            oCompletarCamion.Dispose();

            Refrescar();
        }
        #endregion

        #region Click boton editarCamion

        private void btnEditarCamion1_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                CompletarCamion edit = new CompletarCamion(Id);
                edit.ShowDialog();
                Refrescar();
            }
        }
        #endregion

        #region Click boton refrescar

        private void btnRefrescar1_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        #endregion

        #region Helper para regresar ID

        public int? GetId()
        {
            try
            {
                int rowIndex = dgvCamionesCurso.CurrentRow.Index;
                int id = Convert.ToInt32(dgvCamionesCurso.Rows[rowIndex].Cells[0].Value);
                return id;

            }
            catch
            {

                return null;
            }

        }

        #endregion

        #region Helper para regresar Patente

        public string? GetPatente()
        {
            try
            {
                int rowIndex = dgvCamionesCurso.CurrentRow.Index;
                string patente = Convert.ToString(dgvCamionesCurso.Rows[rowIndex].Cells["PatenteTractor"].Value);
                return patente;

            }
            catch
            {

                return null;
            }

        }


























        #endregion

    }
}
