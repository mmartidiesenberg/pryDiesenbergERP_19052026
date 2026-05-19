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
        int intentos = 0;
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsConexion con = new clsConexion();
            string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            AppDomain.CurrentDomain.BaseDirectory + @"Base de Datos\Diesenberg.accdb;";

            con.Conectar(cadena);

            string sql = $"SELECT * FROM Usuario WHERE Nombre='{txtUsuario.Text}' AND Contraseña='{txtContrasenia.Text}'";
            DataTable dt = con.Consultar(sql);

            if (dt.Rows.Count > 0)
            {
                // Login correcto, abrir frmPrincipal
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Demasiados intentos fallidos. El sistema se cerrará.",
                                    "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {3 - intentos}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
