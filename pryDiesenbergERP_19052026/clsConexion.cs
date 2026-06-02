using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryDiesenbergERP_19052026
{
    public class clsConexion
    {
        public class ConexionBD
        {
            public static OleDbConnection conexion;
            public static string error;
            public static bool Conectar()
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base de Datos", "Diesenberg.accdb");
                string cadena = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + ruta;

                try
                {
                    conexion = new OleDbConnection(cadena);
                    conexion.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
            public static void Desconectar()
            {
                if (conexion != null && conexion.State == ConnectionState.Open) conexion.Close();
            }
            public static DataTable Consultar(string sql)
            {
                DataTable tabla = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, conexion);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
                return tabla;
            }
            public static void AuditarSesion(string usuario, bool acceso)
            {
                try
                {
                    string sql = "INSERT INTO AuditoriaInicioSesion (NombreUsuario, FechayHora, IntentoFallido) " +
                                 "VALUES ('" + usuario + "', #" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "#, " + acceso + ")";

                    OleDbCommand cmd = new OleDbCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            public static void AuditarAccion(string usuario, string accion)
            {
                try
                {
                    string sql = "INSERT INTO AuditoriaInicioSesion (FechayHora, NombreUsuario, Acción) " +
                                 "VALUES (#" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "#, '" + usuario + "', '" + accion + "')";

                    OleDbCommand cmd = new OleDbCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    error = ex.Message;
                }
            }


        }
    }
}
