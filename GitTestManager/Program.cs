using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestManager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new GitTestManagerForm());

            HttpTest.checkHttpRequest();


            Console.Out.WriteLine("Pulse una tecla para salir");
            Console.In.ReadLine();
        }
    }
}
