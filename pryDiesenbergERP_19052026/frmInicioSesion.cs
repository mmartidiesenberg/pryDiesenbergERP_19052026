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
            clsConexion.ConexionBD conexion = new clsConexion.ConexionBD();

            string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Diesenberg.accdb";

            conexion.Conectar(cadena);

            DataTable tabla = conexion.Consultar(
                "SELECT * FROM Usuarios WHERE Gmail = '" + txtUsuario.Text +
                "' AND Contraseña = '" + txtContrasenia.Text + "'");

            if (tabla.Rows.Count > 0)
            {
                frmPrincipal Principal = new frmPrincipal();

                Principal.nombreUsuario = tabla.Rows[0]["Nombre"].ToString();
                Principal.rolUsuario = tabla.Rows[0]["Perfil"].ToString();

                Principal.ShowDialog();

                this.Close();
            }
            else
            {
                intentos--;

                MessageBox.Show(
                    "Usuario o Contraseña Incorrectos, Te Quedan "
                    + intentos +
                    " Intentos Disponibles"
                );

                if (intentos <= 0)
                {
                    this.Close();
                }
            }
        }
    }
}
