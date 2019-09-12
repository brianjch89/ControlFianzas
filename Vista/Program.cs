using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.IO.File.Exists("ControlFianzas.accdb"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormVentanaPrincipal());
            }
            else
                new FormAviso("La base de datos no se encuentra en la misma carpeta donde está el sistema.", 630, 266).ShowDialog();
        }
    }
}
