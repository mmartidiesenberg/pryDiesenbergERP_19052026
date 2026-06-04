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
            string perfilNuevo = cmbPerfil.SelectedItem.ToString();
            int dni = int.Parse(txtDNI.Text.Trim());
            string provincia = ((DataRowView)cmbProvincia.SelectedItem)["Provincia"].ToString();
            string localidad = ((DataRowView)cmbLocalidad.SelectedItem)["Localidades"].ToString();
            string direccion = txtDireccion.Text.Trim();

            string sql = "INSERT INTO [Usuario] ([Nombre], [Apellido], [Perfil], [DNI], [Provincia], [Localidad], [Direccion], [Gmail], [Contrasenia], [Telefono]) " +
                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(sql, clsConexion.ConexionBD.conexion);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.Parameters.AddWithValue("?", apellido);
                cmd.Parameters.AddWithValue("?", perfilNuevo);
                cmd.Parameters.AddWithValue("?", dni);
                cmd.Parameters.AddWithValue("?", provincia);
                cmd.Parameters.AddWithValue("?", localidad);
                cmd.Parameters.AddWithValue("?", direccion);
                cmd.Parameters.AddWithValue("?", "");
                cmd.Parameters.AddWithValue("?", "");
                cmd.Parameters.AddWithValue("?", "");
                cmd.ExecuteNonQuery();

                clsConexion.ConexionBD.AuditarAccion(usuario, "Agregó un Usuario");

                MessageBox.Show("Usuario Agregado Correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos solo si el INSERT fue exitoso
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDNI.Text = string.Empty;
                txtDireccion.Text = string.Empty;
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
            cmbPerfil.Items.Clear();
            cmbPerfil.Items.Add("Administrador");
            cmbPerfil.Items.Add("Recursos Humanos");
            cmbPerfil.Items.Add("Usuario");
            cmbPerfil.SelectedIndex = 0;

            if (clsConexion.ConexionBD.Conectar())
            {
                DataTable tablaProvincias = clsConexion.ConexionBD.Consultar("SELECT * FROM Provincias");
                cmbProvincia.DataSource = tablaProvincias;
                cmbProvincia.DisplayMember = "Provincia";
                cmbProvincia.ValueMember = "Id_Provincia";

                DataTable tablaLocalidades = clsConexion.ConexionBD.Consultar("SELECT * FROM Localidades");
                cmbLocalidad.DataSource = tablaLocalidades;
                cmbLocalidad.DisplayMember = "Localidades";
                cmbLocalidad.ValueMember = "Id_Localidades";
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
    }
}
