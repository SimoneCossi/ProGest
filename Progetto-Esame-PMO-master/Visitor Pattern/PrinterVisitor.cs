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

            OrdinaLista(NrBottiglieVini, Id);

            // da modificare. messo solamente per togliere l'errore
            return Id ;
        }

        public List<string> VisitMarmellate(DbMarmellata v)
        {
            List<string> NrBarattoli = new List<string>();
            NrBarattoli = v.Select("nrbarattoli");


            List<string> Id = new List<string>();
            Id = v.Select("id");

            OrdinaLista(NrBarattoli, Id);

            // da modificare. messo solamente per togliere l'errore
            return Id;
        }

        public List<string> VisitVigneti(DbVigneto v)
        {
            List<string> NrViti = new List<string>();
            NrViti = v.Select("nrvitimorte");


            List<string> Id = new List<string>();
            Id = v.Select("id");

            OrdinaLista(NrViti, Id);

            // da modificare. messo solamente per togliere l'errore
            return Id;
        }

        // funzione che ordina la lista dei vini in modo da mettere prima i vini con più bottiglie in magazzino
        // INSERTION SORT
        void OrdinaLista(List<string> nr, List<string> id)
        {
            int i,
                j,
                tempvi,
                tempid;

            for(i = 1; i < id.Count; i++)
            {
                tempvi = int.Parse(nr[i]);
                tempid = int.Parse(id[i]);
                j = i;

                while((j > 0) && (int.Parse(nr[j-1]) < tempvi))
                {
                    nr[j] = nr[j - 1];
                    id[j]   = id[j - 1];
                    j = j - 1;
                }
                nr[j] = tempvi.ToString();
                id[j]   = tempid.ToString();
            }

        }// end OrdinaListaVini
        
    }

}
