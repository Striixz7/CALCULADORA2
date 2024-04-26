using System;
using System.Windows.Forms;

namespace CALCULADORA2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CALCULADORA2()); // Aquí se crea una instancia del formulario principal
        }
    }
}