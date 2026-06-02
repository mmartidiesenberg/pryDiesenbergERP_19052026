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
    public partial class frmRRHH : Form
    {
        private string usuario;
        private string perfil;

        public frmRRHH(string usuarioLogueado, string perfilUsuario)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            perfil = perfilUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBD.Desconectar();
            clsConexion.ConexionBD.Conectar();

            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string perfilNuevo = cmbUsuario.SelectedItem.ToString();
            string dni = txtDNI.Text.Trim();
            string provincia = cmbProvincia.Text;
            string localidad = cmbLocalidad.Text;
            string direccion = txtDireccion.Text.Trim();

            clsConexion.ConexionBD.Consultar(
                "INSERT INTO Usuario (Nombre, Apellido, Perfil, DNI, Provincia, Localidad, Direccion) " +
                "VALUES ('" + nombre + "', '" + apellido + "', '" + perfilNuevo + "', '" +
                dni + "', '" + provincia + "', '" + localidad + "', '" + direccion + "')");
            clsConexion.ConexionBD.AuditarAccion(usuario, "Agregó un Usuario");

            MessageBox.Show(
                "Usuario Agregado Correctamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    


       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string usuarioSeleccionado = cmbUsuario.SelectedItem.ToString();
            string[] datos = usuarioSeleccionado.Split(' ');
            string nombre = datos[0];
            string apellido = datos[1];
            DialogResult resultado = MessageBox.Show("¿Está Seguro que Desea Eliminar este Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                clsConexion.ConexionBD.Desconectar();
                clsConexion.ConexionBD.Conectar();
                clsConexion.ConexionBD.Consultar("DELETE FROM Usuario WHERE Nombre = '" + nombre + "' AND Apellido = '" + apellido + "'");
                clsConexion.ConexionBD.AuditarAccion(usuario, "Eliminó un Usuario");
                MessageBox.Show("Usuario Eliminado Correctamente");
                cmbUsuario.Items.Remove(usuarioSeleccionado);
            }
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {
            if (clsConexion.ConexionBD.Conectar())
            {
                // Provincias
                DataTable tablaProvincias =
                    clsConexion.ConexionBD.Consultar(
                    "SELECT * FROM Provincias");

                cmbProvincia.DataSource = tablaProvincias;
                cmbProvincia.DisplayMember = "Provincia";
                cmbProvincia.ValueMember = "Id_Provincia";

                // Localidades
                DataTable tablaLocalidades =
                    clsConexion.ConexionBD.Consultar(
                    "SELECT * FROM Localidades");

                cmbLocalidad.DataSource = tablaLocalidades;
                cmbLocalidad.DisplayMember = "Localidades";
                cmbLocalidad.ValueMember = "Id_Localidades";
            }
            else
            {
                MessageBox.Show(clsConexion.ConexionBD.error);
            }
        }
    }
}
