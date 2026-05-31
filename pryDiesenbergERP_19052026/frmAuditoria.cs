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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.Conectar())
            {
                // Cargar la auditoría en la grilla
                dgvAuditoria.DataSource =
                    clsConexion.ConexionBD.Consultar(
                    "SELECT * FROM AuditoriaInicioSesion");

                // Cargar usuarios en el ComboBox
                DataTable tablaUsuarios =
                    clsConexion.ConexionBD.Consultar(
                    "SELECT DISTINCT NombreUsuario FROM AuditoriaInicioSesion");

                cmbUsuario.DataSource = tablaUsuarios;
                cmbUsuario.DisplayMember = "NombreUsuario";

                // Cargar opciones del ComboBox Intento
                cmbIntento.Items.Clear();
                cmbIntento.Items.Add("Todos");
                cmbIntento.Items.Add("Sí");
                cmbIntento.Items.Add("No");

                cmbIntento.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(clsConexion.ConexionBD.error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM AuditoriaInicioSesion WHERE 1=1";

            if (cmbUsuario.Text != "")
            {
                sql += " AND NombreUsuario = '" + cmbUsuario.Text + "'";
            }

            if (cmbIntento.Text == "Sí")
            {
                sql += " AND IntentoFallido = True";
            }
            else if (cmbIntento.Text == "No")
            {
                sql += " AND IntentoFallido = False";
            }

            dgvAuditoria.DataSource =
                clsConexion.ConexionBD.Consultar(sql);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvAuditoria.DataSource = clsConexion.ConexionBD.Consultar("SELECT * FROM AuditoriaInicioSesion");
        }
    }
}
