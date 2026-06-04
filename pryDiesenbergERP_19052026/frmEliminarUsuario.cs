using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryDiesenbergERP_19052026
{
    public partial class frmEliminarUsuario : Form
    {
        private string usuario;
        private string perfil;
        public frmEliminarUsuario(string usuarioLogueado, string perfilUsuario)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            perfil = perfilUsuario;

        }
        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            CargarComboUsuarios();
        }

        private void CargarComboUsuarios()
        {
            clsConexion.ConexionBD.Desconectar();
            clsConexion.ConexionBD.Conectar();
            DataTable tablaUsuarios = clsConexion.ConexionBD.Consultar(
                "SELECT Nombre, Apellido FROM Usuario");
            cmbUsuario.Items.Clear();
            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                cmbUsuario.Items.Add(
                    fila["Nombre"].ToString() + " " + fila["Apellido"].ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string usuarioSeleccionado = cmbUsuario.SelectedItem.ToString();
            string[] datos = usuarioSeleccionado.Split(' ');
            string nombre = datos[0];
            string apellido = datos[1];

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar a " + usuarioSeleccionado + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    clsConexion.ConexionBD.Desconectar();
                    clsConexion.ConexionBD.Conectar();

                    // 1. Obtener el ID del usuario
                    string sqlId = "SELECT Id_Usuario FROM Usuario WHERE Nombre = ? AND Apellido = ?";
                    var cmdId = new OleDbCommand(sqlId, clsConexion.ConexionBD.conexion);
                    cmdId.Parameters.AddWithValue("?", nombre);
                    cmdId.Parameters.AddWithValue("?", apellido);
                    object idObj = cmdId.ExecuteScalar();

                    if (idObj != null)
                    {
                        int idUsuario = Convert.ToInt32(idObj);

                        // 2. Eliminar registros relacionados en Usuario-Perfil
                        string sqlRelacion = "DELETE FROM [Usuario-Perfil] WHERE Id_Usuario = ?";
                        var cmdRelacion = new OleDbCommand(sqlRelacion, clsConexion.ConexionBD.conexion);
                        cmdRelacion.Parameters.AddWithValue("?", idUsuario);
                        cmdRelacion.ExecuteNonQuery();
                    }

                    // 3. Eliminar el usuario
                    string sqlDelete = "DELETE FROM Usuario WHERE Nombre = ? AND Apellido = ?";
                    var cmdDelete = new OleDbCommand(sqlDelete, clsConexion.ConexionBD.conexion);
                    cmdDelete.Parameters.AddWithValue("?", nombre);
                    cmdDelete.Parameters.AddWithValue("?", apellido);
                    cmdDelete.ExecuteNonQuery();

                    clsConexion.ConexionBD.AuditarAccion(usuario, "Eliminó al usuario: " + usuarioSeleccionado);

                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarComboUsuarios(); // Recargar combo
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
