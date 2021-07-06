using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Esame_PMO.Visitor_Pattern;

namespace Progetto_Esame_PMO.Prodotti
{
    // classe dove viene definito l'oggetto 'vino' con vari attributi da poter passare alle query del database
    class Vino
    {

        // dichiarazione dell'attributo 'nome'
        private string nome;
        //definizione dei metodi per poter andare a leggere e/o scrivere l'attributo 'nome'
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string value)
        {
            nome = value;
        }

        // dichiarazione dell'atributo 'anno'
        private int anno;
        // definizione dei metodi per andare a leggere e/o scrivere l'attrubuto 'anno'
        public int GetAnno()
        {
            return anno;
        }
        public void SetAnno(int value)
        {
            anno = value;
        }

        // dichiarazione dell'attributo 'tipologia'
        private string tipologia;
        // definizione dei metodi per andare a leggere e/o scrivere l'attrubuto 'tipologia'
        public string GetTipologia()
        {
            return tipologia;
        }
        public void SetTipologia(string value)
        {
            tipologia = value;
        }

        // dichiarazione dell'attributo 'vigneto'
        private string vigneto;
        // definizione dei metodi per andare a leggere e/o scrivere l'attrubuto 'vigneto'
        public string GetVigneto()
        {
            return vigneto;
        }
        public void SetVigneto(string value)
        {
            vigneto = value;
        }

        // dichiarazione dell'attributo 'nrbottiglie'
        private int nrbottiglie;
        // definizione dei metodi per andare a leggere e/o scrivere l'attrubuto 'nrbottiglie'
        public int GetNrbottiglie()
        {
            return nrbottiglie;
        }
        public void SetNrbottiglie(int value)
        {
            nrbottiglie = value;
        }

    }
}
