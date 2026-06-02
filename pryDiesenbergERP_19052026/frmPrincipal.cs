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
        private bool adminOpened = false; // flag to open admin once

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

            tsmiDatos.Click -= TsmiDatos_Click;
            tsmiDatos.Click += TsmiDatos_Click;

            tsmiModificarPass.Click -= TsmiModificarPass_Click;
            tsmiModificarPass.Click += TsmiModificarPass_Click;

            tsmiFuncionalidades.Click -= TsmiFuncionalidades_Click;
            tsmiFuncionalidades.Click += TsmiFuncionalidades_Click;

            // If administrator, automatically open frmAdministrador once
            if (isAdmin && !adminOpened)
            {
                try
                {
                    adminOpened = true;
                    frmAdministrador admin = null;
                    // reuse existing if any
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
                    }

                    this.Hide();
                    // make sure admin is invisible before calling ShowDialog
                    if (admin.Visible)
                    {
                        admin.Hide();
                    }
                    admin.ShowDialog();
                    this.Show();
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
            // Open frmAdministrador modally and return to this form after it closes
            try
            {
                frmAdministrador admin = null;

                // If an instance already exists, use it, otherwise create a new one
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
                }

                // Hide this form while admin is open
                this.Hide();
                admin.ShowDialog();
                // When admin closes, show this form again
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Administrador: " + ex.Message);
            }
        }

        private void TsmiFuncionalidades_Click(object sender, EventArgs e)
        {
            // Open admin modal via user menu
            try
            {
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
                }

                // Ensure admin is not already visible as non-modal
                if (admin.Visible)
                {
                    admin.Hide();
                }

                this.Hide();
                admin.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Administrador desde Funcionalidades: " + ex.Message);
            }
        }
    }
}
