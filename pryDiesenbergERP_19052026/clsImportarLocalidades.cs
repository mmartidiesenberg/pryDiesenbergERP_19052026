using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryDiesenbergERP_19052026
{
    class clsImportarLocalidades
    {
        public static void ImportarLocalidades()
        {
            string rutaCSV = Path.Combine(Application.StartupPath,
                              "Archivos",
                              "localidades_cordoba.csv");
            string rutaAccess = Path.Combine(Application.StartupPath,
                                 "Base de Datos",
                                 "Diesenberg.accdb");
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaAccess};";
            string[] lineas = File.ReadAllLines(rutaCSV, System.Text.Encoding.UTF8);

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                for (int i = 1; i < lineas.Length; i++) // i=1 para saltear el encabezado
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                    string nombreLocalidad = lineas[i].Trim();
                    string sql = "INSERT INTO Localidades (Localidades) VALUES (@nombre)";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreLocalidad);
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("¡Listo!");
            }
        }
    }
}
