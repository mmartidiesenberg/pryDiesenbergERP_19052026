using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergERP_19052026
{
    public partial class frmRRHH : Form
    {
        private string usuario;
        private string perfil;

        public frmRRHH(string usuarioLogueado, string perfilUsuario)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            perfil = perfilUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.conexion == null ||
        clsConexion.ConexionBD.conexion.State == System.Data.ConnectionState.Closed)
            {
                clsConexion.ConexionBD.Conectar();
            }

            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string perfilTexto = (cmbPerfil.SelectedItem as DataRowView)?["Perfil"].ToString() ?? string.Empty;

            if (!int.TryParse(txtDNI.Text.Trim(), out int dni))
            {
                MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string provincia = (cmbProvincia.SelectedItem as DataRowView)?["Provincia"].ToString() ?? string.Empty;
            string localidad = (cmbLocalidad.SelectedItem as DataRowView)?["Localidades"].ToString() ?? string.Empty;
            string direccion = txtDireccion.Text.Trim();
            string gmail = txtGmail.Text.Trim();
            string telefono = mskTelefono.Text.Trim();
            string redSocial = cmbRedes.SelectedItem?.ToString() ?? string.Empty;
            bool activo = chkActivo.Checked;
            string password = txtContrasenia.Text.Trim();

            if (string.IsNullOrWhiteSpace(gmail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Debe ingresar Gmail y Password.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = "INSERT INTO [Usuario] ([Nombre], [Apellido], [Perfil], [DNI], [Provincia], [Localidad], [Direccion], [Gmail], [Telefono], [Red Social], [Activo], [Contrasenia]) " +
                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(sql, clsConexion.ConexionBD.conexion);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.Parameters.AddWithValue("?", apellido);
                cmd.Parameters.AddWithValue("?", perfilTexto);
                cmd.Parameters.AddWithValue("?", dni);
                cmd.Parameters.AddWithValue("?", provincia);
                cmd.Parameters.AddWithValue("?", localidad);
                cmd.Parameters.AddWithValue("?", direccion);
                cmd.Parameters.AddWithValue("?", gmail);
                cmd.Parameters.AddWithValue("?", telefono);
                cmd.Parameters.AddWithValue("?", redSocial);
                cmd.Parameters.AddWithValue("?", activo);
                cmd.Parameters.AddWithValue("?", password);
                cmd.ExecuteNonQuery();

                clsConexion.ConexionBD.AuditarAccion(usuario, "Agregó un Usuario");

                MessageBox.Show("Usuario Agregado Correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDNI.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtGmail.Text = string.Empty;
                txtContrasenia.Text = string.Empty;
                try { mskTelefono.Text = string.Empty; } catch { }
                try { cmbRedes.SelectedIndex = -1; } catch { }
                chkActivo.Checked = false;
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
      
      
        private void frmRRHH_Load(object sender, EventArgs e)
        {
            try
            {
                if (clsConexion.ConexionBD.Conectar())
                {
                    // Cargar perfiles desde la BD
                    DataTable tablaPerfiles = clsConexion.ConexionBD.Consultar("SELECT Id_Perfil, Perfil FROM Perfil");
                    if (tablaPerfiles != null && tablaPerfiles.Rows.Count > 0)
                    {
                        cmbPerfil.DataSource = tablaPerfiles;
                        cmbPerfil.DisplayMember = "Perfil";
                        cmbPerfil.ValueMember = "Id_Perfil";
                        cmbPerfil.SelectedIndex = 0;
                    }

                    // Cargar provincias
                    DataTable tablaProvincias = clsConexion.ConexionBD.Consultar("SELECT * FROM Provincias");
                    if (tablaProvincias != null && tablaProvincias.Rows.Count > 0)
                    {
                        cmbProvincia.DataSource = tablaProvincias;
                        cmbProvincia.DisplayMember = "Provincia";
                        cmbProvincia.ValueMember = "Id_Provincia";
                        cmbProvincia.SelectedIndex = 0;
                    }

                    // Cargar localidades
                    DataTable tablaLocalidades = clsConexion.ConexionBD.Consultar("SELECT * FROM Localidades");
                    if (tablaLocalidades != null && tablaLocalidades.Rows.Count > 0)
                    {
                        cmbLocalidad.DataSource = tablaLocalidades;
                        cmbLocalidad.DisplayMember = "Localidades";
                        cmbLocalidad.ValueMember = "Id_Localidades";
                        cmbLocalidad.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en frmRRHH_Load:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Asegurar que los controles de Perfil estén visibles y habilitados para carga
            try
            {
                cmbPerfil.Visible = true;
                cmbPerfil.Enabled = true;
                lblPerfil.Visible = true;
                lblPerfil.Enabled = true;
            }
            catch { }

            // Vincular boton VolverAdmin si existe
            var found = this.Controls.Find("btnVolverAdmin", true);
            if (found.Length > 0 && found[0] is Button btn)
            {
                btn.Click -= BtnVolverAdmin_Click;
                btn.Click += BtnVolverAdmin_Click;
                btn.Visible = (perfil == "Administrador");
            }
        }

        private void BtnVolverAdmin_Click(object sender, EventArgs e)
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
            }
            else
            {
                frmAdministrador admin = new frmAdministrador(usuario, perfil);
                admin.Show();
            }

            this.Close();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario b = new frmEliminarUsuario(usuario, perfil);
            b.ShowDialog();
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control chars (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("DNI: Sólo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, spaces, control chars
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Nombre: Sólo se permiten letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Apellido: Sólo se permiten letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mskTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Teléfono: Sólo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
