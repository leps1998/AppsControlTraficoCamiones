using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AppControlTraficoPorteria
{
    public class CamionesDB
    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";

        #region Metodo para ver camiones en curso

        public DataTable VerCamionesCurso()
        {
            string query = "SELECT id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                " HojaDeRuta, Precintos, PesoBruto, PasoTara, PesoNeto, Dock, Observaciones, UsuarioLogistica," +
                " UsuarioPorteria FROM CamionesCurso";

            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para agregar informacion a camiones curso

        public void Agregar(string Transporte, string PatenteTractor, string PatenteSemi,
            string NombreChofer, string ApellidoChofer, string DniChofer, string Proveedor,
            DateTime Arribo, bool FlagPorteria, string? Usuario)
        {
            string query = "INSERT INTO CamionesCurso(Transporte, PatenteTractor, PatenteSemi," +
                " NombreChofer, ApellidoChofer, DniChofer, Proveedor, Arribo, FlagPorteria, UsuarioPorteria)" +
                " VALUES(@Transporte, @PatenteTractor, @PatenteSemi, @NombreChofer, @ApellidoChofer, @DniChofer," +
                " @Proveedor, @Arribo, @FlagPorteria, @UsuarioPorteria)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Transporte", Transporte);
                command.Parameters.AddWithValue("@PatenteTractor", PatenteTractor);
                command.Parameters.AddWithValue("@PatenteSemi", PatenteSemi);
                command.Parameters.AddWithValue("@NombreChofer", NombreChofer);
                command.Parameters.AddWithValue("@ApellidoChofer", ApellidoChofer);
                command.Parameters.AddWithValue("@DniChofer", DniChofer);
                command.Parameters.AddWithValue("@Proveedor", Proveedor);
                command.Parameters.AddWithValue("@Arribo", Arribo);
                command.Parameters.AddWithValue("@FlagPorteria", FlagPorteria);
                command.Parameters.AddWithValue("@UsuarioPorteria", Usuario);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }

        #endregion

        #region Metodo para cargar ingreso y peso tara

        public void CargarIngresoPesoTara(double PesoTara, DateTime Ingreso, string nroRemito, string hojaDeRuta, string precintos, string destino, string observaciones, int? id)
        {
            string query = "UPDATE CamionesCurso SET PasoTara = @PasoTara, Ingreso = @Ingreso," +
                " RemitoNro = @RemitoNro, HojaDeRuta = @HojaDeRuta, Precintos = @Precintos," +
                " Destino = @Destino, Observaciones = @Observaciones WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PasoTara", PesoTara);
                command.Parameters.AddWithValue("@Ingreso", Ingreso);
                command.Parameters.AddWithValue("@RemitoNro", nroRemito);
                command.Parameters.AddWithValue("@HojaDeRuta", hojaDeRuta);
                command.Parameters.AddWithValue("@Precintos", precintos);
                command.Parameters.AddWithValue("@Destino", destino);
                command.Parameters.AddWithValue("@Observaciones", observaciones);



                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para cargar ingreso y peso tara al historial 

        public void CargarIngresoPesoTaraH(double PesoTara, DateTime Ingreso, int? id)
        {
            string query = "UPDATE HistorialCamiones SET PasoTara = @PasoTara, Ingreso = @Ingreso WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PasoTara", PesoTara);
                command.Parameters.AddWithValue("@Ingreso", Ingreso);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para cargar peso bruto y peso neto

        public void CargarPesoBrutoNeto(double PesoBruto, double PesoNeto, int? id)
        {
            string query = "UPDATE CamionesCurso SET PesoBruto = @PesoBruto, PesoNeto = @PesoNeto WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PesoBruto", PesoBruto);
                command.Parameters.AddWithValue("@PesoNeto", PesoNeto);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para cargar peso bruto y peso neto al historial 

        public void CargarPesoBrutoNetoH(double PesoBruto, double PesoNeto, int? id)
        {
            string query = "UPDATE HistorialCamiones SET PesoBruto = @PesoBruto, PesoNeto = @PesoNeto WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PesoBruto", PesoBruto);
                command.Parameters.AddWithValue("@PesoNeto", PesoNeto);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para agregar informacion a historial de camiones

        public void AgregarHistorial(string Transporte, string PatenteTractor, string PatenteSemi,
            string NombreChofer, string ApellidoChofer, string DniChofer, string Proveedor,
            DateTime Arribo, string? Usuario)
        {
            string query = "INSERT INTO HistorialCamiones(Transporte, PatenteTractor, PatenteSemi," +
                " NombreChofer, ApellidoChofer, DniChofer, Proveedor, Arribo, UsuarioPorteria)" +
                " VALUES(@Transporte, @PatenteTractor, @PatenteSemi, @NombreChofer, @ApellidoChofer, @DniChofer," +
                " @Proveedor, @Arribo, @UsuarioPorteria)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@Transporte", Transporte);
                command.Parameters.AddWithValue("@PatenteTractor", PatenteTractor);
                command.Parameters.AddWithValue("@PatenteSemi", PatenteSemi);
                command.Parameters.AddWithValue("@NombreChofer", NombreChofer);
                command.Parameters.AddWithValue("@ApellidoChofer", ApellidoChofer);
                command.Parameters.AddWithValue("@DniChofer", DniChofer);
                command.Parameters.AddWithValue("@Proveedor", Proveedor);
                command.Parameters.AddWithValue("@Arribo", Arribo);
                command.Parameters.AddWithValue("@UsuarioPorteria", Usuario);



                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }

        #endregion

        #region Metodo para agregar info final camiones

        public void AgregarInfoFinal(DateTime Salida, string RemitoNro, string HojaDeRuta, string Precintos, string Destino,
             string Observaciones, int? id)
        {
            string query = "UPDATE CamionesCurso SET Salida = @Salida, RemitoNro = @RemitoNro," +
                " HojaDeRuta = @HojaDeRuta, Precintos = @Precintos, Destino = @Destino," +
                " Observaciones = @Observaciones WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Salida", Salida);
                command.Parameters.AddWithValue("@RemitoNro", RemitoNro);
                command.Parameters.AddWithValue("@HojaDeRuta", HojaDeRuta);
                command.Parameters.AddWithValue("@Precintos", Precintos);
                command.Parameters.AddWithValue("@Destino", Destino);
                command.Parameters.AddWithValue("@Observaciones", Observaciones);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para agregar info final al historial de camiones

        public void AgregarInfoFinalHistorial(DateTime Salida, string RemitoNro, string HojaDeRuta,
            string Precintos, string Destino, string Observaciones, int? id)
        {
            string query = "UPDATE HistorialCamiones SET Salida = @Salida, RemitoNro = @RemitoNro," +
                " HojaDeRuta = @HojaDeRuta, Precintos = @Precintos, Destino = @Destino," +
                " Observaciones = @Observaciones WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Salida", Salida);
                command.Parameters.AddWithValue("@RemitoNro", RemitoNro);
                command.Parameters.AddWithValue("@HojaDeRuta", HojaDeRuta);
                command.Parameters.AddWithValue("@Precintos", Precintos);
                command.Parameters.AddWithValue("@Destino", Destino);
                command.Parameters.AddWithValue("@Observaciones", Observaciones);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para editarTotalDeCamiones

        public void EditarTotal(string Transporte, string PatenteTractor, string PatenteSemi, string NroRemito, string HojaDeRuta,
            string Precintos, string Destino, string Observaciones, string Proveedor, string NombreChofer, string ApellidoChofer,
            string DniChofer, double PesoTara, double PesoBruto, double PesoNeto, DateTime Salida, int? id)
        {
            string query = "UPDATE CamionesCurso SET Transporte = @Transporte, PatenteTractor = @PatenteTractor," +
                " PatenteSemi = @PatenteSemi, RemitoNro = @RemitoNro, HojaDeRuta = @HojaDeRuta, Precintos = @Precintos," +
                " Destino = @Destino, Observaciones = @Observaciones, Proveedor = @Proveedor, NombreChofer = @NombreChofer," +
                " ApellidoChofer = @ApellidoChofer, DniChofer = @DniChofer, PasoTara = @PasoTara, PesoBruto = @PesoBruto," +
                " PesoNeto = @PesoNeto, Salida = @Salida WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Transporte", Transporte);
                command.Parameters.AddWithValue("@PatenteTractor", PatenteTractor);
                command.Parameters.AddWithValue("@PatenteSemi", PatenteSemi);
                command.Parameters.AddWithValue("@RemitoNro", NroRemito);
                command.Parameters.AddWithValue("@HojaDeRuta", HojaDeRuta);
                command.Parameters.AddWithValue("@Precintos", Precintos);
                command.Parameters.AddWithValue("@Destino", Destino);
                command.Parameters.AddWithValue("@Observaciones", Observaciones);
                command.Parameters.AddWithValue("@Proveedor", Proveedor);
                command.Parameters.AddWithValue("@NombreChofer", NombreChofer);
                command.Parameters.AddWithValue("@ApellidoChofer", ApellidoChofer);
                command.Parameters.AddWithValue("@DniChofer", DniChofer);
                command.Parameters.AddWithValue("@PasoTara", PesoTara);
                command.Parameters.AddWithValue("@PesoBruto", PesoBruto);
                command.Parameters.AddWithValue("@PesoNeto", PesoNeto);
                command.Parameters.AddWithValue("@Salida", Salida);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para editarTotalDeCamionesHistorial

        public void EditarTotalH(string Transporte, string PatenteTractor, string PatenteSemi, string NroRemito, string HojaDeRuta,
            string Precintos, string Destino, string Observaciones, string Proveedor, string NombreChofer, string ApellidoChofer,
            string DniChofer, double PesoTara, double PesoBruto, double PesoNeto, DateTime Salida, int? id)
        {
            string query = "UPDATE HistorialCamiones SET Transporte = @Transporte, PatenteTractor = @PatenteTractor," +
                " PatenteSemi = @PatenteSemi, RemitoNro = @RemitoNro, HojaDeRuta = @HojaDeRuta, Precintos = @Precintos," +
                " Destino = @Destino, Observaciones = @Observaciones, Proveedor = @Proveedor, NombreChofer = @NombreChofer," +
                " ApellidoChofer = @ApellidoChofer, DniChofer = @DniChofer, PasoTara = @PasoTara, PesoBruto = @PesoBruto," +
                " PesoNeto = @PesoNeto, Salida = @Salida WHERE id = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Transporte", Transporte);
                command.Parameters.AddWithValue("@PatenteTractor", PatenteTractor);
                command.Parameters.AddWithValue("@PatenteSemi", PatenteSemi);
                command.Parameters.AddWithValue("@RemitoNro", NroRemito);
                command.Parameters.AddWithValue("@HojaDeRuta", HojaDeRuta);
                command.Parameters.AddWithValue("@Precintos", Precintos);
                command.Parameters.AddWithValue("@Destino", Destino);
                command.Parameters.AddWithValue("@Observaciones", Observaciones);
                command.Parameters.AddWithValue("@Proveedor", Proveedor);
                command.Parameters.AddWithValue("@NombreChofer", NombreChofer);
                command.Parameters.AddWithValue("@ApellidoChofer", ApellidoChofer);
                command.Parameters.AddWithValue("@DniChofer", DniChofer);
                command.Parameters.AddWithValue("@PasoTara", PesoTara);
                command.Parameters.AddWithValue("@PesoBruto", PesoBruto);
                command.Parameters.AddWithValue("@PesoNeto", PesoNeto);
                command.Parameters.AddWithValue("@Salida", Salida);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para liberar camion

        public void LiberarCamion(int Id)
        {
            string query = "DELETE FROM CamionesCurso WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo para ver historial de camiones

        public DataTable VerHistorialCamiones()
        {
            string query = "SELECT id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                " HojaDeRuta, Precintos, PesoBruto, PasoTara, PesoNeto, Dock, Observaciones, UsuarioLogistica," +
                " UsuarioPorteria FROM HistorialCamiones";

            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para ver estado de flag 

        public DataTable VerFlag()
        {
            string query = "SELECT id, Dock, PatenteTractor, FlagLogistica FROM CamionesCurso WHERE FlagLogistica = 'TRUE'";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para poner flag logistica en false

        public void Flag(bool FlagLogistica, int? Id)
        {
            string query = "UPDATE CamionesCurso SET FlagLogistica = @FlagLogistica WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FlagLogistica", FlagLogistica);
                command.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }
            }
        }


        #endregion

        #region Metodo ver info para validar

        public DataTable VerInfoParaValidar()
        {
            string query = "SELECT id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                " HojaDeRuta, Precintos, PesoBruto, PasoTara, PesoNeto, PesoKgHojaRuta, PesoPallets," +
                " Dock, Observaciones FROM CamionesCurso";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para que nos regrese el primer elemento que consiga
        public CamionDB? Get(int Id)
        {
            string query = "SELECT id, Observaciones, RemitoNro, HojaDeRuta, Precintos, Destino, PasoTara, PesoBruto, PesoNeto, Dock  FROM CamionesCurso WHERE id=@id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                CamionDB oCamionDB = new CamionDB();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    
                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.Observaciones = reader.GetString(1);
                    oCamionDB.RemitoNro = reader.GetString(2);
                    oCamionDB.HojaDeRuta = reader.GetString(3);
                    oCamionDB.Precintos = reader.GetString(4);
                    oCamionDB.Destino = reader.GetString(5);
                    

                    reader.Close();

                    connection.Close();

                    return oCamionDB;
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB no consegui nada" + ex.Message);
                }
                return oCamionDB;
            }


        }
        #endregion

        #region Metodo para ver el PesoKgHojaRuta del camion selecionado
        public CamionDB GetPesoKgHojaDeRutaTara(int Id)
        {
            string query = "SELECT id, PesoKgHojaRuta, PasoTara  FROM CamionesCurso WHERE id=@id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                CamionDB oCamionDB = new CamionDB();

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    
                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.PesoKgHojaRuja = reader.GetDecimal(1);
                    oCamionDB.PesoTara = reader.GetDecimal(2);

                    reader.Close();

                    connection.Close();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Para poder editar el camion debe haber pasado por logistica ");
                    
                }
                return oCamionDB;
            }


        }
        #endregion

        #region Metodo para ver dock del camion selecionado
        public CamionDB GetDock(int? Id)
        {
            string query = "SELECT id, Dock  FROM CamionesCurso WHERE id=@id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                CamionDB oCamionDB = new CamionDB();

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();


                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.Dock = reader.GetString(1);

                    reader.Close();

                    connection.Close();


                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Se le debe de haber asignado el dock al camion");
                    
                }
                return oCamionDB;
            }


        }
        #endregion

        #region Metodo para ver dock del camion selecionado
        public CamionDB GetPesoKgHojaDeRuta(int? Id)
        {
            string query = "SELECT id, PesoKgHojaRuta  FROM CamionesCurso WHERE id=@id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                CamionDB oCamionDB = new CamionDB();

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();


                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.PesoKgHojaRuja = reader.GetDecimal(1);

                    reader.Close();

                    connection.Close();


                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Se le debe de haber asignado el dock al camion");

                }
                return oCamionDB;
            }


        }
        #endregion

        #region Metodo para que nos regrese la info al dar dar click en editar camion
        public CamionDB GetInfo(int Id)
        {
            string query = "SELECT id, HojaDeRuta, Precintos, Destino, PasoTara, PesoBruto, PesoNeto," +
                " Observaciones, Dock, Transporte, PatenteTractor, PatenteSemi, Proveedor, NombreChofer, ApellidoChofer," +
                " DniChofer, RemitoNro, PasoTara, PesoBruto, PesoNeto, PesoKgHojaRuta, PesoPallets FROM CamionesCurso WHERE id=@id";
            


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    CamionDB oCamionDB = new CamionDB();
                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.HojaDeRuta = reader.GetString(1);
                    oCamionDB.Precintos = reader.GetString(2);
                    oCamionDB.Destino = reader.GetString(3);
                    oCamionDB.PesoTara = reader.GetDecimal(4);
                    oCamionDB.PesoBruto = reader.GetDecimal(5);
                    oCamionDB.PesoNeto = reader.GetDecimal(6);
                    oCamionDB.Observaciones = reader.GetString(7);
                    oCamionDB.Dock = reader.GetString(8);
                    oCamionDB.Transporte = reader.GetString(9);
                    oCamionDB.PatenteTractor = reader.GetString(10);
                    oCamionDB.PatenteSemi = reader.GetString(11);
                    oCamionDB.Proveedor = reader.GetString(12);
                    oCamionDB.NombreChofer = reader.GetString(13);
                    oCamionDB.ApellidoChofer = reader.GetString(14);
                    oCamionDB.DniChofer = reader.GetString(15);
                    oCamionDB.RemitoNro = reader.GetString(16);
                    oCamionDB.PesoTara = reader.GetDecimal(17);
                    oCamionDB.PesoBruto = reader.GetDecimal(18);
                    oCamionDB.PesoNeto = reader.GetDecimal(19);
                    oCamionDB.PesoKgHojaRuja = reader.GetDecimal(20);
                    oCamionDB.PesoPallets = reader.GetDecimal(21);


                    reader.Close();

                    connection.Close();

                    return oCamionDB;
                }
                catch (Exception ex)
                {

                    throw new Exception("Se debe haber completado todo para poder editar" + ex.Message);
                }
            }


        }
        #endregion

        #region Metodo de verificacion para liberar camion
        public CamionDB? GetInfoParaLiberar(int Id)
        {
            string query = "SELECT id, HojaDeRuta, Precintos, Destino, PasoTara, PesoBruto, PesoNeto," +
                 " Observaciones, Dock, Transporte, PatenteTractor, PatenteSemi, Proveedor, NombreChofer, ApellidoChofer," +
                 " DniChofer, RemitoNro, PasoTara, PesoBruto, PesoNeto, PesoKgHojaRuta, PesoPallets FROM CamionesCurso WHERE id=@id";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                CamionDB oCamionDB = new CamionDB();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    
                    oCamionDB.Id = reader.GetInt32(0);
                    oCamionDB.HojaDeRuta = reader.GetString(1);
                    oCamionDB.Precintos = reader.GetString(2);
                    oCamionDB.Destino = reader.GetString(3);
                    oCamionDB.PesoTara = reader.GetDecimal(4);
                    oCamionDB.PesoBruto = reader.GetDecimal(5);
                    oCamionDB.PesoNeto = reader.GetDecimal(6);
                    oCamionDB.Observaciones = reader.GetString(7);
                    oCamionDB.Dock = reader.GetString(8);
                    oCamionDB.Transporte = reader.GetString(9);
                    oCamionDB.PatenteTractor = reader.GetString(10);
                    oCamionDB.PatenteSemi = reader.GetString(11);
                    oCamionDB.Proveedor = reader.GetString(12);
                    oCamionDB.NombreChofer = reader.GetString(13);
                    oCamionDB.ApellidoChofer = reader.GetString(14);
                    oCamionDB.DniChofer = reader.GetString(15);
                    oCamionDB.RemitoNro = reader.GetString(16);
                    oCamionDB.PesoTara = reader.GetDecimal(17);
                    oCamionDB.PesoBruto = reader.GetDecimal(18);
                    oCamionDB.PesoNeto = reader.GetDecimal(19);
                    oCamionDB.PesoKgHojaRuja = reader.GetDecimal(20);
                    oCamionDB.PesoPallets = reader.GetDecimal(21);


                    reader.Close();

                    connection.Close();

                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hola");
                }
                return oCamionDB;
            }


        }
        #endregion

        #region Logueo

        #region Metodo Loguear

        public void Loguear(string usuario, string contraseña)
        {
            string query = "SELECT IdUsuario, Nombre, TipoUsuario FROM Usuarios WHERE Usuario=@Usuario AND Contraseña=@Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        int? usuarioConectado = Convert.ToInt32(dt.Rows[0][0].ToString());
                        EnviarTrue(true, usuarioConectado);
                        Form1 form1 = new Form1();
                        form1.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecto");
                    }

                    connection.Close();

                }
                catch (Exception)
                {


                }

            }

        }


        #endregion

        #region Metodo para enviarle un true al usuario que este conectado

        public void EnviarTrue(bool Activo, int? IdUsuario)
        {
            string query = "UPDATE Usuarios SET Activo = @Activo WHERE IdUsuario = @IdUsuario ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Activo", Activo);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }

            }
        }

        #endregion

        #region Metodo para ver quien esta logeado

        public DataTable VerUsuarioLogeado()
        {
            string query = "SELECT IdUsuario, Nombre, Usuario, TipoUsuario FROM Usuarios WHERE Activo = 'TRUE' AND (TipoUsuario = 'administrador' OR TipoUsuario = 'usuario porteria') ";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para cerrar Sesion

        public void CerrarSesion(bool Activo, string Nombre)
        {
            string query = "UPDATE Usuarios SET Activo = @Activo WHERE Nombre = @Nombre ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Activo", Activo);
                command.Parameters.AddWithValue("@Nombre", Nombre);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB" + ex.Message);
                }

            }
        }

        #endregion

        #endregion


    }
}

#region Clase Camion

public class CamionDB
{
    public int? Id { get; set; }
    public string? Transporte { get; set; }
    public string? PatenteTractor { get; set; }
    public string? PatenteSemi { get; set; }
    public string? NombreChofer { get; set; }
    public string? ApellidoChofer { get; set; }
    public string? DniChofer { get; set; }
    public string? Proveedor { get; set; }
    public string? Destino { get; set; }
    public string? Arribo { get; set; }
    public string? Ingreso { get; set; }
    public string? Salida { get; set; }
    public string? RemitoNro { get; set; }
    public string? HojaDeRuta { get; set; }
    public string? Precintos { get; set; }
    public decimal? PesoBruto { get; set; }
    public decimal? PesoTara { get; set; }
    public decimal? PesoNeto { get; set; }
    public string? Observaciones { get; set; }
    public decimal? PesoKgHojaRuja { get; set; }
    public decimal? PesoPallets { get; set; }
    public string? Dock { get; set; }
    public string? Usuario { get; set; }

}

#endregion

