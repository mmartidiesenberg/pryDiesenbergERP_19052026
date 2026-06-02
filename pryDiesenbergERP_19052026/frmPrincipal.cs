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

            // Configurar btnVolverAdmin: visible solo para Administrador y ocultar btnVolver
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
                // Ocultar el botón Volver si es administrador, de lo contrario, mostrarlo
                btnVolver.Visible = !isAdmin;
                btnVolver.Click -= btnSalir_Click;
                btnVolver.Click += btnSalir_Click;
            }
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
            // Si hay una instancia de frmAdministrador abierta, traerla al frente.
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
                adminForm.Activate();
            }
            else
            {
                // Abrir nueva instancia con los datos del usuario actual
                frmAdministrador admin = new frmAdministrador(nombreUsuario, rolUsuario);
                admin.Show();
            }

            // Cerrar este formulario para volver al administrador
            this.Close();
        }
    }
}
