using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlTraficoLogistica.Controlador
{

    public class CamionesLogisticaDB
    {
        public string connectionString = "Data Source=DESKTOP-6QJ5I73;Initial Catalog=TraficoCamiones;Integrated Security=True";

        #region Informacion Camion 

        #region Metodo para ver camiones en curso

        public DataTable VerCamionesCurso()
        {
            string query = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones, UsuarioPorteria," +
                " UsuarioLogistica FROM CamionesCurso";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para ver hisotrial de camiones

        public DataTable VerHistorialDeCamiones()
        {
            string query = "SELECT Id, Transporte, PatenteTractor, PatenteSemi, NombreChofer," +
                " ApellidoChofer, DniChofer, Proveedor, Destino, Arribo, Ingreso, Salida, RemitoNro," +
                " HojaDeRuta, Precintos, PesoKgHojaRuta, PesoPallets, Dock, Observaciones, UsuarioPorteria," +
                " UsuarioLogistica FROM HistorialCamiones";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para completar camion

        public void completarCamion(double KgHojaDeRuta, double PesoPallets, int? Id, string? Usuario)
        {
            string query = "UPDATE CamionesCurso SET PesoKgHojaRuta = @PesoKgHojaRuta," +
                " PesoPallets = @PesoPallets, UsuarioLogistica = @UsuarioLogistica WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PesoKgHojaRuta", KgHojaDeRuta);
                command.Parameters.AddWithValue("@PesoPallets", PesoPallets);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@UsuarioLogistica", Usuario);

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

        #region Metodo para completar Historial camiones

        public void completarCamionHisto(double KgHojaDeRuta, double PesoPallets, int? Id, string? Usuario)
        {
            string query = "UPDATE HistorialCamiones SET PesoKgHojaRuta = @PesoKgHojaRuta," +
                " PesoPallets = @PesoPallets, UsuarioLogistica = @UsuarioLogistica WHERE Id = @Id ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PesoKgHojaRuta", KgHojaDeRuta);
                command.Parameters.AddWithValue("@PesoPallets", PesoPallets);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@UsuarioLogistica", Usuario);

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

        #region Metodo para que nos regrese el primer elemento que consiga
        public CamionDB Get(int Id)
        {
            string query = "SELECT id, PesoKgHojaRuta, PesoPallets FROM CamionesCurso WHERE id=@id";


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
                    oCamionDB.PesoKgHojaRuta = reader.GetDecimal(1);
                    oCamionDB.PesoPallets = reader.GetDecimal(2);

                    reader.Close();

                    connection.Close();

                    return oCamionDB;
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en la DB no consegui nada" + ex.Message);
                }
            }


        }
        #endregion

        #endregion

        #region Asignacion de Dock

        #region Metodo para ver estado de flag porteria

        public DataTable VerFlagPorteria()
        {
            string query = "SELECT id, PatenteTractor, FlagPorteria FROM CamionesCurso WHERE FlagPorteria = 'TRUE'";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para enviar dock y flag

        public void enviarDock(bool FlagLogistica, bool FlagPorteria, string Dock, int? Id)
        {
            string query = "UPDATE CamionesCurso SET FlagLogistica = @FlagLogistica," +
                "FlagPorteria = @FlagPorteria, Dock = @Dock WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FlagLogistica", FlagLogistica);
                command.Parameters.AddWithValue("@FlagPorteria", FlagPorteria);
                command.Parameters.AddWithValue("@Dock", Dock);
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

        #endregion

        #region Logueo

        #region Metodo Loguear

        public void Loguear(string usuario, string contraseña)
        {
            string query = "SELECT IdUsuario, Nombre, TipoUsuario FROM Usuarios WHERE Usuario=@Usuario AND Contraseña=@Contraseña ";

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
            string query = "SELECT IdUsuario, Nombre, Usuario, TipoUsuario FROM Usuarios WHERE Activo = 'TRUE' AND (TipoUsuario = 'administrador' OR TipoUsuario = 'usuario logistica')";
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

        #region Metodo para crear usuario

        public void AgregarUsuario(string Nombre, string Usuario, string Contraseña, string TipoDeUsuario)
        {
            string query = "INSERT INTO Usuarios(Nombre, Usuario, Contraseña, TipoUsuario)" +
                " VALUES (@Nombre, @Usuario, @Contraseña, @TipoUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Contraseña", Contraseña);
                command.Parameters.AddWithValue("@TipoUsuario", TipoDeUsuario);



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

        #region Metodo para actulizar datos

        public void Update(string Nombre, string Usuario, string Contraseña, string TipoDeUsuario, int Id)
        {
            string query = "UPDATE Usuarios SET Nombre=@Nombre, Usuario=@Usuario, Contraseña=@Contraseña," +
                "TipoUsuario=@TipoUsuario WHERE IdUsuario=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Contraseña", Contraseña);
                command.Parameters.AddWithValue("@TipoUsuario", TipoDeUsuario);
                command.Parameters.AddWithValue("@id", Id);


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

        #region Metodo para eliminar usuario

        public void EliminarUsuario(int Id)
        {
            string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdUsuario", Id);

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

        #region Metodo para ver usuarios

        public DataTable VerUsuarios()
        {
            string query = "SELECT IdUsuario, Nombre, Usuario, TipoUsuario FROM Usuarios";
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            da.Fill(dtTabla);
            return dtTabla;
        }

        #endregion

        #region Metodo para que nos regrese el primer elemento que consiga
        public Usuario GetUsuario(int Id)
        {
            string query = "SELECT IdUsuario,Nombre,Usuario FROM Usuarios WHERE IdUsuario=@id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();


                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = reader.GetInt32(0);
                    oUsuario.Nombre = reader.GetString(1);
                    oUsuario.Usuario1 = reader.GetString(1);

                    reader.Close();

                    connection.Close();

                    return oUsuario;
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

#region Clase camionDB
public class CamionDB
{
    public int Id { get; set; }
    public decimal PesoKgHojaRuta { get; set; }
    public decimal PesoPallets { get; set; }


}
#endregion

#region Clase Usuario
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Usuario1 { get; set; }

}
#endregion


