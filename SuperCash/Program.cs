using System;
using System.Windows.Forms;
using SuperCash.Data;
using SuperCash.Forms;

namespace SuperCash
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializar datos de prueba
            DataStore.InicializarDatos();

            // Iniciar con el formulario de LOGIN (NO Form1)
            Application.Run(new frmLogin());
        }
    }
}