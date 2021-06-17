using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Esame_PMO.Visitor_Pattern;

namespace Progetto_Esame_PMO.Prodotti
{
    // classe dove viene definito l'oggetto marmellata con i vari attributi da poter passare alla query del db
    class Marmellata
    {
        // dichiarazione dell'atttributo 'nome'
        private string frutto;
        // definizione dei metodi per poter andare a leggere e scrivere l'attributo
        public string GetFrutto()
        {
            return frutto;
        }
        public void SetFrutto(string value)
        {
            frutto = value;
        }

        // dichiarazione dell'atrributo 'anno'
        private int anno;
        // definizione dei metodi per poter andare a leggere e scrivere l'attributo
        public int GetAnno()
        {
            return anno;
        }
        public void SetAnno(int value)
        {
            anno = value;
        }

        // dichiarazione dell'attributo dimensioniBarattolo
        // dimensione espressa in grammi
        int dimensioneBarattolo;
        // definizione dei metodi per poter andare a leggere e scrivere l'attributo
        public int GetDimensioneBarattolo()
        {
            return dimensioneBarattolo;
        }
        public void SetDimensioniBarattolo(int value)
        {
            dimensioneBarattolo = value;
        }

        // dichiarazione dell'asttributo nrBarattoli
        private int nrBarattoli;
        // definizione dei metodi per poter andare a leggere e scrivere l'attributo
        public int GetNrBarattoli()
        {
            return nrBarattoli;
        }
        public void SetNrBarattoli(int value)
        {
            nrBarattoli = value;
        }

    }
}
