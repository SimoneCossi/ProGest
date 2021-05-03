using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// per test
using Progetto_Esame_PMO.Database;
using Progetto_Esame_PMO.Prodotti;

namespace Progetto_Esame_PMO
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());

            ////////////////////////////////////////////////////////////
            ////////////AREA DI TEST///////////////////////////////////
            ////////////////////////////////////////////////////////// 
            
        }
    }
}
