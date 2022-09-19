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
    public partial class Camion : MaterialForm
    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";

        private int? id;
        private string? dock;
        private decimal pesoKgHojaDeRuta;

        public Camion()
        {
            InitializeComponent();
        }

        #region  Ajuste a pantalla

        private Rectangle botonNuevoCamion;
        private Rectangle botonCompletarCamion;
        private Rectangle botonEditarNuevoCamion;
        private Rectangle botonLiberarCamion;
        private Rectangle dgv;
        private Rectangle lblC;
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
        private Rectangle oBtnAgregarPesoTara;
        private Rectangle oBtnAgregarPesoBruto;


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
            resizeControl(botonNuevoCamion, btnNuevoCamion1);
            resizeControl(botonCompletarCamion, btnCompletarCamion1);
            resizeControl(botonEditarNuevoCamion, btnEditarCamion);
            resizeControl(botonLiberarCamion, btnLiberarCamion1);
            resizeControl(dgv, dgvCamionesCurso);
            resizeControl(lblC, lblCamionesCurso);
            resizeControl(olblBuscar, lblBuscar);
            resizeControl(otxtBuscar, txtBuscar);
            resizeControl(olblTipo, lblTipo1);
            resizeControl(ocmbTipo, cmbTipo1);
            resizeControl(obtnRefresacar, btnRefrescar1);
            resizeControl(obtnBuscar, btnBuscar1);
            resizeControl(olblFecha, lblFecha);
            resizeControl(odtpBuscar, dtpBuscarDesde);
            resizeControl(optbBerry, ptbBerry);
            resizeControl(lblHasta, lblFechaHasta);
            resizeControl(dtpHasta, dtpBuscarHasta);
            resizeControl(oBtnAgregarPesoTara, cargarPesoTara);
            resizeControl(oBtnAgregarPesoBruto, btnCargarPesoBruto);

        }

        #endregion


        private void NuevoCamion_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            botonNuevoCamion = new Rectangle(btnNuevoCamion1.Location.X, btnNuevoCamion1.Location.Y, btnNuevoCamion1.Width, btnNuevoCamion1.Height);
            botonCompletarCamion = new Rectangle(btnCompletarCamion1.Location.X, btnCompletarCamion1.Location.Y, btnCompletarCamion1.Width, btnCompletarCamion1.Height);
            botonEditarNuevoCamion = new Rectangle(btnEditarCamion.Location.X, btnEditarCamion.Location.Y, btnEditarCamion.Width, btnEditarCamion.Height);
            botonLiberarCamion = new Rectangle(btnLiberarCamion1.Location.X, btnLiberarCamion1.Location.Y, btnLiberarCamion1.Width, btnLiberarCamion1.Height);
            dgv = new Rectangle(dgvCamionesCurso.Location.X, dgvCamionesCurso.Location.Y, dgvCamionesCurso.Width, dgvCamionesCurso.Height);
            lblC = new Rectangle(lblCamionesCurso.Location.X, lblCamionesCurso.Location.Y, lblCamionesCurso.Width, lblCamionesCurso.Height);
            olblBuscar = new Rectangle(lblBuscar.Location.X, lblBuscar.Location.Y, lblBuscar.Width, lblBuscar.Height);
            otxtBuscar = new Rectangle(txtBuscar.Location.X, txtBuscar.Location.Y, txtBuscar.Width, txtBuscar.Height);
            olblTipo = new Rectangle(lblTipo1.Location.X, lblTipo1.Location.Y, lblTipo1.Width, lblTipo1.Height);
            ocmbTipo = new Rectangle(cmbTipo1.Location.X, cmbTipo1.Location.Y, cmbTipo1.Width, cmbTipo1.Height);
            obtnRefresacar = new Rectangle(btnRefrescar1.Location.X, btnRefrescar1.Location.Y, btnRefrescar1.Width, btnRefrescar1.Height);
            obtnBuscar = new Rectangle(btnBuscar1.Location.X, btnBuscar1.Location.Y, btnBuscar1.Width, btnBuscar1.Height);
            olblFecha = new Rectangle(lblFecha.Location.X, lblFecha.Location.Y, lblFecha.Width, lblFecha.Height);
            odtpBuscar = new Rectangle(dtpBuscarDesde.Location.X, dtpBuscarDesde.Location.Y, dtpBuscarDesde.Width, dtpBuscarDesde.Height);
            lblHasta = new Rectangle(lblFechaHasta.Location.X, lblFechaHasta.Location.Y, lblFechaHasta.Width, lblFechaHasta.Height);
            dtpHasta = new Rectangle(dtpBuscarHasta.Location.X, dtpBuscarHasta.Location.Y, dtpBuscarHasta.Width, dtpBuscarHasta.Height);
            oBtnAgregarPesoTara = new Rectangle(cargarPesoTara.Location.X, cargarPesoTara.Location.Y, cargarPesoTara.Width, cargarPesoTara.Height);
            optbBerry = new Rectangle(ptbBerry.Location.X, ptbBerry.Location.Y, ptbBerry.Width, ptbBerry.Height);
            oBtnAgregarPesoBruto = new Rectangle(btnCargarPesoBruto.Location.X, btnCargarPesoBruto.Location.Y, btnCargarPesoBruto.Width, btnCargarPesoBruto.Height);
            this.WindowState = FormWindowState.Maximized;
            Refrescar();
        }

        #region Click Boton refresar


        private void btnRefrescar1_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
        #endregion

        #region Click boton nuevo camion

        private void btnNuevoCamion1_Click(object sender, EventArgs e)
        {
            NuevoCamion oNuevoCamion = new NuevoCamion();
            oNuevoCamion.ShowDialog();

            Refrescar();

            oNuevoCamion.Dispose();
        }
        #endregion

        #region click en cargar peso tara
        private void cargarPesoTara_Click(object sender, EventArgs e)
        {
            if (LoadDock() != null)
            {
                try
                {
                    cargarPesoTaraIngreso oCargarPesoTaraIngreso = new cargarPesoTaraIngreso();
                    oCargarPesoTaraIngreso.CamionId(GetId());
                    oCargarPesoTaraIngreso.ShowDialog();
                    oCargarPesoTaraIngreso.Dispose();

                    Refrescar();

                }
                catch (Exception)
                {

                    //MessageBox.Show("Para poder completar, ya debe de haber pasado por logistica", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Para poder completar, se le debe de haber asignado el dock", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region click en boton cargar peso bruto

        private void btnCargarPesoBruto_Click(object sender, EventArgs e)
        {
            pesoKgHojaDeRuta = LoadPesoKgHojaRuta();

            if(pesoKgHojaDeRuta != 0)
            {
                CargaBrutoNeto oCargaBrutoNeto = new CargaBrutoNeto();
                oCargaBrutoNeto.CamionId(GetId());
                oCargaBrutoNeto.LoadPesos();
                oCargaBrutoNeto.ShowDialog();
                oCargaBrutoNeto.Dispose();
            }
            else
            {
                MessageBox.Show("Para poder completar,  debe de haber pasado por logistica", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        #endregion

        #region Metodo refrescar
        public void Refrescar()
        {
            CamionesDB oCamionesDB = new CamionesDB();
            dgvCamionesCurso.DataSource = oCamionesDB.VerCamionesCurso();

        }
        #endregion

        #region click boton liberar camion

        private void btnLiberarCamion1_Click(object sender, EventArgs e)
        {
            if (validar() && Validar150())
            {
                int? Id = GetId();
                try
                {
                    if (Id != null)
                    {
                        CamionesDB oCamionesDB = new CamionesDB();
                        oCamionesDB.LiberarCamion((int)Id);
                        Refrescar();
                        MessageBox.Show("Se libero camion de la tabla", "Camion liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al liberar");
                }
            }
            else
            {
                
                MessageBox.Show("Se debe haber completado toda la informacion del camion para poder liberar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


          
        }
        #endregion

        #region click boton completar camion

        private void btnCompletarCamion1_Click(object sender, EventArgs e)
        {
            pesoKgHojaDeRuta = LoadPesoKgHojaRuta();
            int? Id = GetId();

            if (pesoKgHojaDeRuta != 0 || pesoKgHojaDeRuta == null)
            {
                if (Id != null)
                {
                    CompletarInfoCamion edit = new CompletarInfoCamion(Id);
                    edit.ShowDialog();
                    Refrescar();
                }
            }
            else
            {
                MessageBox.Show("Para poder completar, ya debe de haber pasado por logistica", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            //if (pesoKgHojaDeRuta != 0 || pesoKgHojaDeRuta == null)
            //    {
            //        try
            //        {

            //            CompletarInfoCamion oCompletarInfoCamion = new CompletarInfoCamion();
            //            oCompletarInfoCamion.CamionId(GetId());
            //            oCompletarInfoCamion.CamionPatente(GetPatente());

            //            oCompletarInfoCamion.ShowDialog();

            //            oCompletarInfoCamion.Dispose();

            //            Refrescar();
            //        }
            //        catch (Exception)
            //        {

            //            MessageBox.Show("Para poder completar, ya debe de haber pasado por logistica", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Para poder completar, ya debe de haber pasado por logistica", "Completar camión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }


        }

        #endregion

        #region click en boton editar camion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                EditarCamion edit = new EditarCamion(Id);
                edit.ShowDialog();
                Refrescar();
            }
        }
        #endregion

        #region Timmer

        private void timer1_Tick(object sender, EventArgs e)
        {
            CamionesDB oCamionesDB = new CamionesDB();

            int id;
            bool flagLogistica;
            string dock;
            string patente;

            try
            {
                DataTable dt = oCamionesDB.VerFlag();
                DataRow row = dt.Rows[0];

                id = Convert.ToInt32(row["id"]);
                flagLogistica = Convert.ToBoolean(row["FlagLogistica"]);
                dock = Convert.ToString(row["dock"]);
                patente = Convert.ToString(row["PatenteTractor"]);

                if (flagLogistica)
                {
                    timer1.Enabled = false;

                    DialogResult res = MessageBox.Show($"Envíe el camion con patente: {patente} al {dock} por favor", "Envie camion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (res == DialogResult.OK)
                    {
                        oCamionesDB.Flag(false, id);
                    }
                }
            }
            catch (Exception)
            {

               
            }

            Refrescar();

            timer1.Enabled = true;
            

        }
        #endregion

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
                    " FROM CamionesCurso WHERE Transporte LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Patente Tractor")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM CamionesCurso WHERE patenteTractor LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Patente Semi")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM CamionesCurso WHERE PatenteSemi LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Destino")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM CamionesCurso WHERE Destino LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

                    connection.Close();
                }
                else if (cmbTipo1.Text == "Numero de remito")
                {

                    cmd.CommandText = "SELECT id, Transporte, PatenteTractor, PatenteSemi," +
                        " NombreChofer,ApellidoChofer, DniChofer, Proveedor, Destino, Arribo," +
                        " Ingreso, Salida, RemitoNro,HojaDeRuta, Precintos, PesoBruto, PasoTara," +
                        " PesoNeto, PesoPallets, Dock, Observaciones" +
                        " FROM CamionesCurso WHERE RemitoNro LIKE  ('" + txtBuscar.Text + "%')";

                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvCamionesCurso.DataSource = dt;

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
                    SqlDataAdapter da = new SqlDataAdapter("buscarArriboPorteriaCC", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@fecha_Desde", SqlDbType.Date).Value = dtpBuscarDesde.Text;
                    da.SelectCommand.Parameters.Add("@fecha_Hasta", SqlDbType.Date).Value = dtpBuscarHasta.Text;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dgvCamionesCurso.DataSource = dt;
                }
                else if (cmbTipo1.Text == "Salida")
                {
                    SqlDataAdapter da = new SqlDataAdapter("buscarSalidaPorteriaCC", connection);
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

        #region Metodo para ver si tiene dock asignado

        public string LoadDock()
        {
            CamionesDB camionesDB = new CamionesDB();
            CamionDB camionDB = camionesDB.GetDock((int)GetId());
            dock = Convert.ToString(camionDB.Dock);

            return dock;
            
        }

        #endregion

        #region Metodo para ver si ya tiene peso kg hoja de ruta

        public decimal LoadPesoKgHojaRuta()
        {

            decimal pesoKgHojaRuta = 0;

            CamionesDB camionesDB = new CamionesDB();
            CamionDB camionDB = camionesDB.GetPesoKgHojaDeRuta((int)GetId());
            pesoKgHojaRuta = Convert.ToDecimal(camionDB.PesoKgHojaRuja);

            return pesoKgHojaRuta;

        }

        #endregion

        #region Metodo para validar +- 150 kg

        public bool Validar150()
        {
            bool completo = true;
            int? id = GetId();

            CamionesDB oCamionesDB = new CamionesDB();
            CamionDB oCamionDB = oCamionesDB.GetInfoParaLiberar((int)id);

            decimal? pesoNeto = oCamionDB.PesoNeto;

            if (pesoNeto >= 150.000m)
            {
                completo = false;
                DialogResult ok = MessageBox.Show("El pesaje del camion es de 150kg o más. \n ¿Desea liberar el camion?", "Mas de 150KG", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (ok == DialogResult.Yes)
                {
                    completo = true;
                }
                else if (ok == DialogResult.No)
                {
                    completo = false;
                    MessageBox.Show("No puedes liberar, el pesaje del camion es de 150kg o más.", "Mas de 150KG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                completo = true;
            }

            return completo;
        }

        #endregion

        #region Metodo para validar que todo el camion este completo y liberar

        public bool validar()
        {
            bool completo = true;
            int? id = GetId();

            CamionesDB oCamionesDB = new CamionesDB();
            CamionDB oCamionDB = oCamionesDB.GetInfoParaLiberar((int)id);

            string? trasporte = oCamionDB.Transporte;
            string? patenteTractor = oCamionDB.PatenteTractor;
            string? patenteSemi = oCamionDB.PatenteSemi;
            string? nombreChofer = oCamionDB.NombreChofer;
            string? apellidoChofer = oCamionDB.ApellidoChofer;
            string? dnichofer = oCamionDB.DniChofer;
            string? proveedor = oCamionDB.Proveedor;
            string? destino = oCamionDB.Destino;
            string? remitoNro = oCamionDB.RemitoNro;
            string? hojaDeRuta = oCamionDB.HojaDeRuta;
            string? precintos = oCamionDB.Precintos;
            decimal? pesoBruto = oCamionDB.PesoBruto;
            decimal? pesoTara = oCamionDB.PesoTara;
            decimal? pesoNeto = oCamionDB.PesoNeto;
            decimal? pesoKgHojaRuta = oCamionDB.PesoKgHojaRuja;
            decimal? pesoPallets = oCamionDB.PesoPallets;
            string? observaciones = oCamionDB.Observaciones;
            string? dock = oCamionDB.Dock;
            
            if (trasporte == null || trasporte == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }


            if (dock == null || dock == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }


            if (patenteTractor == null || patenteTractor == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (patenteSemi == null || patenteSemi == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (nombreChofer == null || nombreChofer == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (apellidoChofer == null || apellidoChofer == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (dnichofer == null || dnichofer == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (proveedor == null || proveedor == "")
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (pesoTara == null || pesoTara == 0.0000m)
            {
                completo = false;
            }
            else
            {
                completo = true;
            }


            if (pesoBruto == null || pesoBruto == 0.0000m)
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (pesoNeto == null)
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (pesoKgHojaRuta == null || pesoKgHojaRuta == 0.0000m)
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if (pesoPallets == null)
            {
                completo = false;
            }
            else
            {
                completo = true;
            }

            if ((remitoNro == null || remitoNro == "") || (hojaDeRuta == null || hojaDeRuta == "") || (precintos == null || precintos == "") || (destino == null || destino == "") || (observaciones == null || observaciones == ""))
            {
                completo = false;
            }
            else
            {
                completo = true;
            }


            return completo;
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
