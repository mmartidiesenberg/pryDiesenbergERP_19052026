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
        public string nombreUsuario;
        public string rolUsuario;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.Conectar())
            {
                lblEstado.Text = "Base de datos conectada";
                lblEstado.ForeColor = Color.Green;
                lblUsuario.Text = "Usuario: " + nombreUsuario;
                lblPerfil.Text = "Perfil: " + rolUsuario;
                lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                lblEstado.Text = "No se pudo conectar la base de datos";
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show(clsConexion.ConexionBD.error);
            }
        }
    }
}
