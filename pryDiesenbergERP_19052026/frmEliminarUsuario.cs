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
            if (clsConexion.ConexionBD.Conectar())
            {

                lblEstado.Text = "Base de datos conectada";
                lblEstado.ForeColor = Color.Green;

            }
            else
            {
                lblEstado.Text = "No se pudo conectar la base de datos";
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show(clsConexion.ConexionBD.error);

            }
            CargarComboUsuarios();
        }

        private void CargarComboUsuarios()
        {
            clsConexion.ConexionBD.Desconectar();
            clsConexion.ConexionBD.Conectar();
            // Traer Id y un nombre completo para manejar eliminaciones por Id
            DataTable tablaUsuarios = clsConexion.ConexionBD.Consultar(
                "SELECT Id_Usuario, Nombre & ' ' & Apellido AS FullName FROM Usuario");
            cmbUsuario.Items.Clear();
            if (tablaUsuarios.Rows.Count == 0)
            {
                cmbUsuario.Items.Add("(Sin usuarios)");
                cmbUsuario.SelectedIndex = 0;
                return;
            }

            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                // Guardamos el Id en el ValueMember si fuera un control con DataSource,
                // como workaround almacenamos "Id|FullName" en el item de texto.
                cmbUsuario.Items.Add(fila["Id_Usuario"].ToString() + "|" + fila["FullName"].ToString());
            }
            cmbUsuario.SelectedIndex = 0;
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
            // Recuperar Id y nombre completo del item almacenado como "Id|FullName"
            if (!usuarioSeleccionado.Contains("|"))
            {
                MessageBox.Show("No hay usuarios para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var parts = usuarioSeleccionado.Split(new char[] { '|' }, 2);
            int idUsuario = Convert.ToInt32(parts[0]);
            string nombreCompleto = parts[1];

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

                    // 2. Eliminar registros relacionados en Usuario-Perfil usando Id
                    string sqlRelacion = "DELETE FROM [Usuario-Perfil] WHERE Id_Usuario = ?";
                    var cmdRelacion = new OleDbCommand(sqlRelacion, clsConexion.ConexionBD.conexion);
                    cmdRelacion.Parameters.AddWithValue("?", idUsuario);
                    cmdRelacion.ExecuteNonQuery();

                    // 3. Eliminar el usuario por Id
                    string sqlDelete = "DELETE FROM Usuario WHERE Id_Usuario = ?";
                    var cmdDelete = new OleDbCommand(sqlDelete, clsConexion.ConexionBD.conexion);
                    cmdDelete.Parameters.AddWithValue("?", idUsuario);
                    cmdDelete.ExecuteNonQuery();

                    clsConexion.ConexionBD.AuditarAccion(usuario, "Eliminó al usuario: " + nombreCompleto);

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

        private void btnVolverAdmin_Click(object sender, EventArgs e)
        {
            Form adminForm = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmAdministrador)
                {
                    adminForm = open;
                    break;
                }
            }

            if (adminForm != null)
            {
                adminForm.Show();
                adminForm.BringToFront();
            }
            else
            {
                frmAdministrador admin = new frmAdministrador("Administrador", "Administrador");
                admin.Show();
            }

            this.Close();
        }
    }
}
