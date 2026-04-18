using System;
using System.Windows.Forms;
using DAL;

namespace GUI
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

			// Iniciar con el formulario de LOGIN
			Application.Run(new frmLogin());
		}
	}
}