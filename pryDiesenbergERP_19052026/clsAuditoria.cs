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
        public static void RegistrarInicioSesion(string usuario, bool intentoFallido)
        {
            try
            {
                string rutaAccess = Path.Combine(
                    Application.StartupPath,
                    "Base de Datos",
                    "Diesenberg.accdb");

                string connStr =
                    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaAccess};";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO AuditoriaInicioSesion
                    (FechayHora, NombreUsuario, IntentoFallido)
                    VALUES (?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("?", OleDbType.Boolean).Value = intentoFallido;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
