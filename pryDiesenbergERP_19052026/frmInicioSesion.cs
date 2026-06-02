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
    public partial class frmInicioSesion : Form
    {
        int intentos = 3;
        

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        public void ClearFields()
        {
            try
            {
                // Limpiar campos de usuario y contraseña y colocar el foco en usuario
                txtUsuario.Text = string.Empty;
                txtContrasenia.Text = string.Empty;
                txtUsuario.Focus();
                // Resetear intentos si se desea (opcional)
                intentos = 3;
            }
            catch { }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBD.Conectar();
            DataTable tabla = clsConexion.ConexionBD.Consultar("SELECT * FROM Usuario" +
                         " WHERE Gmail = '" + txtUsuario.Text + "'" +
                         " AND Contrasenia = '" + txtContrasenia.Text + "'");


            if (tabla.Rows.Count > 0)
            {
                // Obtener datos
                string gmail = tabla.Rows[0]["Gmail"].ToString().Trim();
                string nombreCompleto = tabla.Rows[0]["Nombre"].ToString().Trim() + " " + tabla.Rows[0]["Apellido"].ToString().Trim();
                string perfil = tabla.Rows[0]["Perfil"].ToString();

                // GUARDA EL INGRESO EN LA BD usando el Gmail para que en auditoría aparezcan emails
                clsAuditoria.RegistrarInicioSesion(gmail, false, "Inicio de sesión");

                // No cerrar el formulario de login: ocultarlo y volver a mostrar cuando se cierre el formulario hijo
                if (perfil == "Administrador")
                {
                    frmAdministrador Administrador = new frmAdministrador(nombreCompleto, perfil);
                    this.Hide();
                    Administrador.ShowDialog();
                    this.Show();
                }

                else if (perfil == "Recursos Humanos")
                {
                    frmRRHH RecursosHumanos = new frmRRHH(nombreCompleto, perfil);
                    this.Hide();
                    RecursosHumanos.ShowDialog();
                    this.Show();
                }

                else
                {
                    frmPrincipal Principal = new frmPrincipal(nombreCompleto, perfil);
                    this.Hide();
                    Principal.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                // GUARDA INTENTO FALLIDO (texto ingresado, presumiblemente email)
                clsAuditoria.RegistrarInicioSesion(txtUsuario.Text, true, "Inicio de sesión fallido");

                intentos--;

                MessageBox.Show(
                    "Usuario o Contraseña Incorrectos. Te quedan " +
                    intentos + " intentos disponibles."
                );

                if (intentos <= 0)
                {
                    this.Close();
                }
            }

            if (!string.IsNullOrEmpty(clsConexion.ConexionBD.error))
            {
                MessageBox.Show("Error: " + clsConexion.ConexionBD.error);
            }
        }

        private void gbInicio_Enter(object sender, EventArgs e)
        {

        }
    }
}
