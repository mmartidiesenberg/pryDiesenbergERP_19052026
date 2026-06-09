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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
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
            CargarDatosAuditoria();

            // Find if admin is open
            Form adminForm = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmAdministrador)
                {
                    adminForm = open;
                    break;
                }
            }

            var foundAdmin = this.Controls.Find("btnVolverAdmin", true);
            var foundVolver = this.Controls.Find("btnMostrarTodo", true); // keep mostrar todo

            Button btnAdmin = (foundAdmin.Length > 0) ? foundAdmin[0] as Button : null;

            if (adminForm != null)
            {
                if (btnAdmin != null)
                {
                    btnAdmin.Visible = true;
                    btnAdmin.Click -= BtnVolverAdmin_Click;
                    btnAdmin.Click += BtnVolverAdmin_Click;
                }
            }
            else
            {
                if (btnAdmin != null) btnAdmin.Visible = false;
            }
        }

        private void BtnVolverAdmin_Click(object sender, EventArgs e)
        {
            // Intentar mostrar el frmAdministrador si existe en OpenForms
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
                frmAdministrador admin = new frmAdministrador("Administrador","Administrador");
                admin.Show();
            }

            this.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CargarDatosAuditoria();
        }

        private void CargarDatosAuditoria()
        {
            if (clsConexion.ConexionBD.Conectar())
            {
                // Mostrar fecha, usuario, acción y una columna Ingreso que muestra SI si pudo entrar y NO si fallo
                string baseSql = "SELECT FechayHora, NombreUsuario, Acción, IIF(IntentoFallido=0,'SI','NO') AS Ingreso FROM AuditoriaInicioSesion ORDER BY FechayHora DESC";
                dgvAuditoria.DataSource = clsConexion.ConexionBD.Consultar(baseSql);

                // Cargar usuarios para el filtro de auditoría:
                // - emails que ya estén en auditoría
                // - Gmail registrados en Usuario
                // - además, incluir el Nombre + ' ' + Apellido de la tabla Usuario para mostrar usuarios recién creados
                string sqlUsuarios =
                    "SELECT DISTINCT NombreUsuario AS Usuario FROM AuditoriaInicioSesion WHERE NombreUsuario LIKE '%@%' " +
                    "UNION SELECT DISTINCT Gmail AS Usuario FROM Usuario WHERE Gmail IS NOT NULL AND Gmail <> '' " +
                    "UNION SELECT DISTINCT Nombre & ' ' & Apellido AS Usuario FROM Usuario WHERE Nombre IS NOT NULL AND Nombre <> '' " +
                    "ORDER BY Usuario";

                DataTable tablaUsuarios = clsConexion.ConexionBD.Consultar(sqlUsuarios);

                cmbUsuario.DataSource = tablaUsuarios;
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.ValueMember = "Usuario";

                // dejar sin selección por defecto
                cmbUsuario.SelectedIndex = -1;
                cmbUsuario.Text = string.Empty;

                // Cargar opciones del ComboBox Intento
                cmbIntento.Items.Clear();
                cmbIntento.Items.Add("Todos");
                cmbIntento.Items.Add("SI");
                cmbIntento.Items.Add("NO");

                cmbIntento.SelectedIndex = 0;

                // Wire up events so filters apply immediately when user changes selection
                cmbUsuario.SelectedIndexChanged -= cmbUsuario_SelectedIndexChanged;
                cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
                cmbUsuario.TextChanged -= cmbUsuario_TextChanged;
                cmbUsuario.TextChanged += cmbUsuario_TextChanged;

                cmbIntento.SelectedIndexChanged -= cmbIntento_SelectedIndexChanged;
                cmbIntento.SelectedIndexChanged += cmbIntento_SelectedIndexChanged;
            }
            else
            {
                MessageBox.Show(clsConexion.ConexionBD.error);
            }
        }

        private void ApplyFilter()
        {
            try
            {
                string sql = "SELECT FechayHora, NombreUsuario, Acción, IIF(IntentoFallido=0,'SI','NO') AS Ingreso FROM AuditoriaInicioSesion WHERE 1=1";

                // Filtrar por usuario (email) si hay texto
                if (!string.IsNullOrEmpty(cmbUsuario.Text))
                {
                    string usuario = cmbUsuario.Text.Replace("'", "''");
                    sql += " AND NombreUsuario = '" + usuario + "'";
                }

                // Filtrar por intento: SI -> IntentoFallido = False; NO -> IntentoFallido = True
                if (cmbIntento.Text == "SI")
                {
                    sql += " AND IntentoFallido = False";
                }
                else if (cmbIntento.Text == "NO")
                {
                    sql += " AND IntentoFallido = True";
                }

                sql += " ORDER BY FechayHora DESC";

                dgvAuditoria.DataSource = clsConexion.ConexionBD.Consultar(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Apply filter automatically when user selection changes
            ApplyFilter();
        }

        private void cmbUsuario_TextChanged(object sender, EventArgs e)
        {
            // Also apply when text changes (in case user types)
            // Only apply if not empty to avoid spamming when clearing
            if (!string.IsNullOrEmpty(cmbUsuario.Text)) ApplyFilter();
        }

        private void cmbIntento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Apply filter automatically when intento changes
            ApplyFilter();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarDatosAuditoria();
        }
    }
}
