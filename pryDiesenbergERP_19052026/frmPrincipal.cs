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
    public partial class frmPrincipal : Form
    {
        string nombreUsuario;
        string rolUsuario;

        public frmPrincipal(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre; 
            rolUsuario = perfil;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.Conectar())
            {
                lblEstado.Text = "Base de datos conectada";
                lblEstado.ForeColor = Color.Green;
                lblUsuario.Text = nombreUsuario;
                lblPerfil.Text = rolUsuario;
                lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                // Update user menu text
                tsUserMenu.Text = nombreUsuario + " ▼";
            }
            else
            {
                lblEstado.Text = "No se pudo conectar la base de datos";
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show(clsConexion.ConexionBD.error);
            }

            // Vincular evento del botón Volver/Salir buscando el control por nombre (soporta btnVolver o btnSalir)
            Button btn = null;
            var found = this.Controls.Find("btnVolver", true);
            if (found.Length > 0) btn = found[0] as Button;
            else
            {
                found = this.Controls.Find("btnSalir", true);
                if (found.Length > 0) btn = found[0] as Button;
            }

            if (btn != null)
            {
                btn.Click -= btnSalir_Click;
                btn.Click += btnSalir_Click;
            }

            // Configurar btnVolverAdmin: visible solo para Administrador and hide regular volver
            var foundAdminBtn = this.Controls.Find("btnVolverAdmin", true);
            var foundVolverBtn = this.Controls.Find("btnVolver", true);
            Button btnAdmin = (foundAdminBtn.Length > 0) ? foundAdminBtn[0] as Button : null;
            Button btnVolver = (foundVolverBtn.Length > 0) ? foundVolverBtn[0] as Button : null;

            bool isAdmin = (rolUsuario == "Administrador");

            if (btnAdmin != null)
            {
                btnAdmin.Click -= BtnVolverAdmin_Click;
                btnAdmin.Click += BtnVolverAdmin_Click;
                btnAdmin.Visible = isAdmin;
            }

            if (btnVolver != null)
            {
                // Hide the simple volver when admin, otherwise show it
                btnVolver.Visible = !isAdmin;
                btnVolver.Click -= btnSalir_Click;
                btnVolver.Click += btnSalir_Click;
            }

            // Wire user menu
            tsmiCerrarSesion.Click -= TsmiCerrarSesion_Click;
            tsmiCerrarSesion.Click += TsmiCerrarSesion_Click;

            tsmiModificarPass.Click -= TsmiModificarPass_Click;
            tsmiModificarPass.Click += TsmiModificarPass_Click;

            tsmiFuncionalidades.Click -= TsmiFuncionalidades_Click;
            tsmiFuncionalidades.Click += TsmiFuncionalidades_Click;

            // If administrator, optionally open frmAdministrador automatically non-modally
            if (isAdmin)
            {
                try
                {
                    ShowAdministrator();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir Administrador automáticamente: " + ex.Message);
                }
            }
        }

        private void TsmiModificarPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de modificar contraseña no implementada.");
        }

        private void TsmiDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de datos personales no implementada.");
        }

        private void TsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            // Simular cerrar sesión: volver al frmInicioSesion y limpiar campos
            Form loginForm = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmInicioSesion)
                {
                    loginForm = open;
                    break;
                }
            }

            if (loginForm != null)
            {
                ((frmInicioSesion)loginForm).ClearFields();
                loginForm.Show();
            }
            else
            {
                var login = new frmInicioSesion();
                login.Show();
            }

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Intentar encontrar una instancia existente de frmInicioSesion abierta (oculta) y mostrarla
            Form loginForm = null;

            foreach (Form open in Application.OpenForms)
            {
                if (open is frmInicioSesion)
                {
                    loginForm = open;
                    break;
                }
            }

            if (loginForm != null)
            {
                // Limpiar campos si el método existe
                try
                {
                    ((frmInicioSesion)loginForm).ClearFields();
                }
                catch { }

                loginForm.Show();
            }
            else
            {
                var login = new frmInicioSesion();
                login.Show();
            }

            this.Close();
        }

        private void BtnVolverAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAdministrator();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Administrador: " + ex.Message);
            }
        }

        private void TsmiFuncionalidades_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir según el perfil del usuario
                if (rolUsuario == "Administrador")
                {
                    ShowAdministrator();
                }
                else if (rolUsuario == "Recursos Humanos")
                {
                    ShowRRHH();
                }
                else
                {
                    MessageBox.Show("Solo podes ver el menu principal", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir funcionalidades: " + ex.Message);
            }
        }

        private void ShowRRHH()
        {
            // Find existing RRHH form
            frmRRHH rrhh = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmRRHH)
                {
                    rrhh = (frmRRHH)open;
                    break;
                }
            }

            if (rrhh == null)
            {
                rrhh = new frmRRHH(nombreUsuario, rolUsuario);
                rrhh.FormClosed += (s, e) => { try { this.Show(); } catch { } };
                this.Hide();
                rrhh.Show();
            }
            else
            {
                if (!rrhh.Visible)
                {
                    this.Hide();
                    rrhh.Show();
                }
                rrhh.BringToFront();
                rrhh.Activate();
            }
        }

        private void ShowAdministrator()
        {
            // Find existing admin form
            frmAdministrador admin = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmAdministrador)
                {
                    admin = (frmAdministrador)open;
                    break;
                }
            }

            if (admin == null)
            {
                admin = new frmAdministrador(nombreUsuario, rolUsuario);
                // When admin closes, show this principal again
                admin.FormClosed += (s, e) => { try { this.Show(); } catch { } };
                // Hide principal and show admin non-modally
                this.Hide();
                admin.Show();
            }
            else
            {
                // If admin exists, bring to front. If it was hidden, show it.
                if (!admin.Visible)
                {
                    this.Hide();
                    admin.Show();
                }
                admin.BringToFront();
                admin.Activate();
            }
        }
    }
}
