using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergERP_19052026
{
    internal class clsAuditoria
    {
        public static void RegistrarInicioSesion(string usuario, bool intentoFallido, string accion)
        {
            try
            {
                // Asegurarse de que la conexión compartida esté abierta
                if (!clsConexion.ConexionBD.Conectar())
                {
                    MessageBox.Show("No se pudo conectar a la base de datos para auditar.");
                    return;
                }

                // Evitar insertar valores vacíos como nombre
                string usuarioInsert = string.IsNullOrWhiteSpace(usuario) ? "(sin usuario)" : usuario.Trim();

                string sql = @"INSERT INTO AuditoriaInicioSesion (FechayHora, NombreUsuario, IntentoFallido, Acción) VALUES (?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(sql, clsConexion.ConexionBD.conexion))
                {
                    cmd.Parameters.Add("@FechayHora", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("@NombreUsuario", OleDbType.VarChar).Value = usuarioInsert;
                    cmd.Parameters.Add("@IntentoFallido", OleDbType.Boolean).Value = intentoFallido;
                    cmd.Parameters.Add("@Accion", OleDbType.VarChar).Value = accion ?? string.Empty;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
