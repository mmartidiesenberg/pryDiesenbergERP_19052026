using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace pryDiesenbergERP_19052026
{
    public class clsConexion
    {
        private string connectionString;

        public clsConexion()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + @"BaseDatos\Diesenberg.accdb";
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};Persist Security Info=False;";
        }

        public OleDbConnection ObtenerConexion()
        {
            return new OleDbConnection(connectionString);
        }

        // Ejecutar consultas que no devuelven datos (INSERT, UPDATE, DELETE)
        public int EjecutarComando(string sql, OleDbParameter[] parametros = null)
        {
            using (var conn = ObtenerConexion())
            using (var cmd = new OleDbCommand(sql, conn))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Obtener datos como DataTable
        public DataTable ObtenerDatos(string sql, OleDbParameter[] parametros = null)
        {
            using (var conn = ObtenerConexion())
            using (var cmd = new OleDbCommand(sql, conn))
            using (var adapter = new OleDbDataAdapter(cmd))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                conn.Open();
                var tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }
}
