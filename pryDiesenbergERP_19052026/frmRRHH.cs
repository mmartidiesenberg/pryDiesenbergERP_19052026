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
            clsConexion.ConexionBD.Desconectar();
            clsConexion.ConexionBD.Conectar();

            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            if (cmbPerfil.SelectedValue == null)
            {
                MessageBox.Show("Perfil inválido.");
                return;
            }

            int idPerfil = Convert.ToInt32(cmbPerfil.SelectedValue);

            int dni;
            if (!int.TryParse(txtDNI.Text.Trim(), out dni))
            {
                MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Prefer the display text from the bound DataRowView (Provincia/Localidades). If not available, fall back to SelectedValue.
            string provincia = string.Empty;
            string localidad = string.Empty;
            try
            {
                var drvProv = cmbProvincia.SelectedItem as DataRowView;
                if (drvProv != null) provincia = drvProv["Provincia"].ToString();
                else provincia = cmbProvincia.SelectedValue?.ToString() ?? string.Empty;

                var drvLoc = cmbLocalidad.SelectedItem as DataRowView;
                if (drvLoc != null) localidad = drvLoc["Localidades"].ToString();
                else localidad = cmbLocalidad.SelectedValue?.ToString() ?? string.Empty;
            }
            catch
            {
                provincia = cmbProvincia.SelectedValue?.ToString() ?? string.Empty;
                localidad = cmbLocalidad.SelectedValue?.ToString() ?? string.Empty;
            }
            string direccion = txtDireccion.Text.Trim();
            string gmail = txtGmail.Text.Trim();
            string telefono = mskTelefono.Text.Trim();
            string redSocial = (cmbRedes.SelectedItem != null) ? cmbRedes.SelectedItem.ToString() : string.Empty;
            bool activo = chkActivo.Checked;
            string password = txtContrasenia.Text.Trim();

            if (string.IsNullOrWhiteSpace(gmail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Debe ingresar Gmail y Password para el usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = "INSERT INTO [Usuario] ([Nombre], [Apellido], [Perfil], [DNI], [Provincia], [Localidad], [Direccion], [Gmail], [Telefono], [Red Social], [Activo], [Contrasenia]) " +
             "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(sql, clsConexion.ConexionBD.conexion);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.Parameters.AddWithValue("?", apellido);
                cmd.Parameters.AddWithValue("?", idPerfil);
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

                // Limpiar campos
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDNI.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtGmail.Text = string.Empty;
                // Limpiar teléfono (masked) y redes
                try { mskTelefono.Text = string.Empty; } catch { }
                try { cmbRedes.SelectedIndex = -1; } catch { }
                chkActivo.Checked = false;
                cmbPerfil.SelectedIndex = 0;
                cmbProvincia.SelectedIndex = 0;
                cmbLocalidad.SelectedIndex = 0;
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
    }
}
