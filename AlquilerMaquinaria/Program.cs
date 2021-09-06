using AlquilerMaquinaria.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AlquilerMaquinaria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //configuracion de automapper
            AutomapperConfiguration.Configure();

            Application.Run(new frmPrincipal());
        }
    }
}
