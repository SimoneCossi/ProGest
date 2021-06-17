using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


// per test
using Progetto_Esame_PMO.Database;
using Progetto_Esame_PMO.Prodotti;
using Progetto_Esame_PMO.Visitor_Pattern;

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
            DbVino v = new DbVino();
            List<string> i = new List<string>();
            i = v.Select("id");
            for (int n = 0; n < i.Count; n++)
                Console.WriteLine(i[n]);

            PrinterVisitor c = new PrinterVisitor();
            i = c.VisitVini(v);
            for (int n = 0; n < i.Count; n++)
                Console.WriteLine(i[n]);
        }
    }
}
