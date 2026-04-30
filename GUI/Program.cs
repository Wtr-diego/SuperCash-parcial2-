using System;
using System.Windows.Forms;

namespace GUI
{
<<<<<<< HEAD
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
=======
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
>>>>>>> 21b8bb4b051c176eb666c7c7a6d1fcedbf3db64c
}