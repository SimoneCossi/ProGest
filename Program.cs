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
            /*for (int i = 0; i < 10; i++)
            {
                DbVino v = new DbVino();
                Vino vino = new Vino();
                vino.SetAnno(5634);
                vino.SetNome("dio");
                vino.SetNrbottiglie(65346);
                vino.SetTipologia("ciano");
                vino.SetVigneto("buona giornata");
                v.AddItem(vino);
            }
            //v.DeleteTable();
            */
            /*
            List<string> NomiVini = new List<string>();
            NomiVini = v.Select("nome");
            for (int i = 0; i < NomiVini.Count; i++)
            {
                Console.WriteLine(NomiVini[i]);
            }
            */
        }
    }
}
