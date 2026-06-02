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
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            // Find if an admin form is open
            Form adminForm = null;
            foreach (Form open in Application.OpenForms)
            {
                if (open is frmAdministrador)
                {
                    adminForm = open;
                    break;
                }
            }

            // Configure buttons depending on whether admin is present
            var foundAdmin = this.Controls.Find("btnVolverAdmin", true);
            var foundVolver = this.Controls.Find("btnVolver", true);

            Button btnAdmin = (foundAdmin.Length > 0) ? foundAdmin[0] as Button : null;
            Button btnVolver = (foundVolver.Length > 0) ? foundVolver[0] as Button : null;

            if (adminForm != null)
            {
                // Show admin-specific button, hide simple volver
                if (btnAdmin != null) btnAdmin.Visible = true;
                if (btnVolver != null) btnVolver.Visible = false;

                if (btnAdmin != null)
                {
                    btnAdmin.Click -= BtnVolverAdmin_Click;
                    btnAdmin.Click += BtnVolverAdmin_Click;
                }

                // Also make sure hidden btnVolver won't handle clicks, but in case it's clicked, wire it to admin behavior
                if (btnVolver != null)
                {
                    btnVolver.Click -= BtnVolver_Click;
                    btnVolver.Click += BtnVolver_Click;
                }
            }
            else
            {
                // No admin open: show regular volver, hide admin button
                if (btnAdmin != null) btnAdmin.Visible = false;
                if (btnVolver != null) btnVolver.Visible = true;

                if (btnVolver != null)
                {
                    btnVolver.Click -= BtnVolver_Click;
                    btnVolver.Click += BtnVolver_Click;
                }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Simple close to go back to whatever opened this form
            this.Close();
        }

        private void BtnVolverAdmin_Click(object sender, EventArgs e)
        {
            // Intentar mostrar el frmAdministrador si existe en OpenForms
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
            }
            else
            {
                // Abrir nueva instancia sin usuario info
                frmAdministrador admin = new frmAdministrador("Administrador","Administrador");
                admin.Show();
            }

            this.Close();
        }
    }
}
