using Microsoft.Data.Sqlite;
using Progetto_Esame_PMO.Prodotti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progetto_Esame_PMO.Visitor_Pattern;

namespace Progetto_Esame_PMO.Database
{
    // classe in cui vengono definiti tutti i vari metodi dell'interfaccia IDb per la tabella 'vigneti' del db
    class DbVigneto : IDb, Node
    {
        // inizializzazione dell'istanza in modo da non doverla richiamare in ogni funzione
        IQuery q = IQuery.Instance();

        // definizione del metodo che permette di aggiungere elementi nekllla tabella 'vigneti' del db
        public void AddItem(object ob)
        {

            Vigneto v = (Vigneto)ob;

            // query per inserire i dati
            string str = "INSERT INTO vigneti VALUES (NULL,'" + v.GetNome() + "'," + v.GetNrVitiMorte() + ")";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo AddItem


        // definizione del metodo che permette di eliminare un elemento dalla tabella
        public void DeleteItem(ListViewItem.ListViewSubItem id)
        {

            // query per eliminare un elemento
            string str = "DELETE FROM vigneti WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteItem


        // definizione del metedo che permette di eliminare tutti gli elementi dalla tabella
        public void DeleteTable()
        {

            // query per ripulire completamente la tabella vigneti e la tabella id che tiene il conto degli id di tutte le tabelle (togliendo solo gli id riferiti alla tabella vigneti)
            string str = "DELETE FROM vigneti; DELETE FROM sqlite_sequence WHERE name = 'vigneti'";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteTable


        // definizione del metodo che permette di modificare un elemento
        public void ModifyItem(object ob, string nomeColonna, ListViewItem.ListViewSubItem id)
        {

            // query per modificare i dati
            string str = "UPDATE vigneti SET " + nomeColonna + " = '" + ob + "' WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo ModifyItem


        // definizione del metodo che ritorna il nome della tabella
        public string NameTable()
        {
            return "vigneti";
        }// end metodo NameTable


        // definiozne del metodo che ritorna tutti gli elementi del db
        public List<string> Select(string nomeColonna)
        {

            List<string> m = new List<string>();

            // query per ottenere una lista di tutti gli elementi del db
            string str = "SELECT " + nomeColonna + " FROM vigneti ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo Select


        // definizione del metodo che restituisce senza ripetizioni gli elementi del db
        public List<string> SelectDistinct(string nomeColonna)
        {

            List<string> m = new List<string>();

            // query per cercare gli elementi
            string str = "SELECT DISTINCT " + nomeColonna + " FROM vigneti ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectDistinct


        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(ListViewItem.ListViewSubItem id, string nomecolonna)
        {

            string m = null;

            // query per cercare gli elementi
            string str = "SELECT " + nomecolonna + " FROM vigneti WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectElement


        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(string id, string nomecolonna)
        {

            string m = null;

            // query per cercare gli elementi
            string str = "SELECT " + nomecolonna + " FROM vigneti WHERE id = " + id;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectElement

        // definizione Accept
        public void Accept(Visitor v)
        {
            v.VisitVigneti(this);
        }

    }// end DbVigneto
}
