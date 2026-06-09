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


        private void frmAdministrador_Load(object sender, EventArgs e)
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
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal a = new frmPrincipal(nombreUsuario, rolUsuario);
            // When the principal closes, show this admin form again
            a.FormClosed += (s, args) => { try { this.Show(); } catch { } };
            this.Hide();
            a.Show();
        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            clsAuditoria.RegistrarInicioSesion(nombreUsuario, false, "Ingresó a RRHH");
            frmRRHH r = new frmRRHH(nombreUsuario, rolUsuario);
            r.FormClosed += (s, args) => { try { this.Show(); } catch { } };
            this.Hide();
            r.Show();
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
