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

			// Iniciar con el formulario de LOGIN
			Application.Run(new frmLogin());
		}
	}
}