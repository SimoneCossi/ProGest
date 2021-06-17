using Progetto_Esame_PMO.Prodotti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Esame_PMO.Database;

namespace Progetto_Esame_PMO.Visitor_Pattern
{
    class PrinterVisitor : Visitor
    {

        // visita il db e ordina gli id in base al numero di bottiglie decrescente
        // ritorna la lista di id ordinata in modo da poter poi stampare gli elementi `con maggiore priorità di vendita
        public List<string> VisitVini(DbVino v)
        {
            List<string> NrBottiglieVini = new List<string>();
            NrBottiglieVini = v.Select("nrbottiglie");

            List<string> Id = new List<string>();
            Id = v.Select("id");

            OrdinaListaVini(NrBottiglieVini, Id);

            // da modificare. messo solamente per togliere l'errore
            return Id ;
        }

        public void VisitMarmellate(Marmellata v)
        {
            throw new NotImplementedException();
        }

        public void VisitVigneti(Vigneto v)
        {
            throw new NotImplementedException();
        }

        // funzione che ordina la lista dei vini in modo da mettere prima i vini con più bottiglie in magazzino
        // INSERTION SORT
        void OrdinaListaVini(List<string> vini, List<string> id)
        {
            int j;
            string tempnr;
            string tempid;

            for( int i = 1; i < vini.Count(); i++)
            {
                tempnr = vini[i].ToString();
                tempid = id[i].ToString();
                j = i;

                while ((j > 0 ) && (string.Compare(vini[j - 1], tempnr) < 0))
                {
                    vini[j] = vini[j - 1];
                    id[j]   = id[j - 1];
                    j = j - 1;
                }

                vini[j] = tempnr;
                id[j]   = tempid;
            }
            
        }// end OrdinaListaVini
        
    }


}
