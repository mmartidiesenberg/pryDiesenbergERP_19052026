using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergERP_19052026
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show detailed message boxes for unhandled exceptions instead of a generic error page
            Application.ThreadException += (s, e) =>
            {
                try
                {
                    MessageBox.Show("Error de aplicación:\n" + e.Exception.Message + "\n\n" + e.Exception.StackTrace,
                        "Error no controlado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { }
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                try
                {
                    var ex = e.ExceptionObject as Exception;
                    if (ex != null)
                    {
                        MessageBox.Show("Excepción no controlada:\n" + ex.Message + "\n\n" + ex.StackTrace,
                            "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Excepción no controlada: " + e.ExceptionObject?.ToString(),
                            "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
            };

            try
            {
                Application.Run(new frmInicioSesion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la aplicación:\n" + ex.Message + "\n\n" + ex.StackTrace,
                    "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
