using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Esame_PMO.Prodotti
{
    // classe dove viene definito l'oggetto vigneto
    class Vigneto
    {
        //dicharazione dell'attributo nome
        private string nome;
        // definizione dei metodi per poter leggere e scrivere l'attributo
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string value)
        {
            nome = value;
        }

        //dichiarazione attributo "NrVitiMorte"
        int NrVitiMorte;
        // definizione metodi per leggere e scrivere su NrVitiMorte
        public int GetNrVitiMorte()
        {
            return NrVitiMorte;
        }
        public void SetNrVitiMorte(int value)
        {
            NrVitiMorte = value;
        }
    }
}
