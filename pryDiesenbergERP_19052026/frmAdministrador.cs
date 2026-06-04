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
    public partial class frmAdministrador : Form
    {
        string nombreUsuario;
        string rolUsuario;
        public frmAdministrador(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            rolUsuario = perfil;
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            clsAuditoria.RegistrarInicioSesion(nombreUsuario, false, "Ingresó a contactos");
            frmContacto x = new frmContacto();  
            x.ShowDialog();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.Conectar())
            {
           
                lblUsuario.Text = nombreUsuario;
                lblPerfil.Text = rolUsuario;
                lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal a = new frmPrincipal(nombreUsuario, rolUsuario);
            a.ShowDialog();
        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            clsAuditoria.RegistrarInicioSesion(nombreUsuario, false, "Ingresó a RRHH");

            frmRRHH r = new frmRRHH(nombreUsuario, rolUsuario);
            r.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria q = new frmAuditoria();    
            q.ShowDialog(); 
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario b = new frmEliminarUsuario   (nombreUsuario, rolUsuario);
            b.ShowDialog();
        }
    }
}
