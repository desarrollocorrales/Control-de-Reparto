using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Control_de_Reparto.GUIs;

namespace Control_de_Reparto
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
            Application.Run(new Frm_Reparto());
        }
    }
}
