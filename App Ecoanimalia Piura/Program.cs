using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App_Ecoanimalia_Piura.Graficos;

namespace App_Ecoanimalia_Piura
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
            Application.Run(new text_contra());
        }
    }
}
