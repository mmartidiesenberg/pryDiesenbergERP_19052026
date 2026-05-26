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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBD.Conectar();
            DataTable tabla = clsConexion.ConexionBD.Consultar("SELECT * FROM Usuario" +
                         " WHERE Gmail = '" + txtUsuario.Text + "'" +
                         " AND Contrasenia = '" + txtContrasenia.Text + "'");


            if (tabla.Rows.Count > 0)
            {
                string usuario = tabla.Rows[0]["Gmail"].ToString();
                string perfil = tabla.Rows[0]["Perfil"].ToString();

                // GUARDA EL INGRESO EN LA BD
                clsAuditoria.RegistrarInicioSesion(usuario, false);

                if (perfil == "Administrador")
                {
                    frmAdministrador Administrador = new frmAdministrador();
                    Administrador.ShowDialog();
                    this.Close();
                }

                else if (perfil == "Recursos Humanos")
                {
                    frmRRHH RecursosHumanos = new frmRRHH();
                    RecursosHumanos.ShowDialog();
                    this.Close();
                }

                else
                {
                    frmPrincipal Principal = new frmPrincipal();
                    Principal.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                // GUARDA INTENTO FALLIDO
                clsAuditoria.RegistrarInicioSesion(txtUsuario.Text, true);

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
    }
}
