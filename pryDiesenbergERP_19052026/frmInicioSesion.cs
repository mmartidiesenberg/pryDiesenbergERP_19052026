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
                frmPrincipal Principal = new frmPrincipal();
                Principal.nombreUsuario = tabla.Rows[0]["Nombre"].ToString();
                Principal.ShowDialog();
                this.Close();
            }
            else
            {
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
            if (!string.IsNullOrEmpty(clsConexion.ConexionBD.error)) MessageBox.Show("Error: " + clsConexion.ConexionBD.error);

        }

        private void gbInicio_Enter(object sender, EventArgs e)
        {

        }
    }
}
