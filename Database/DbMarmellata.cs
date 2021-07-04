using Microsoft.Data.Sqlite;
using Progetto_Esame_PMO.Prodotti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progetto_Esame_PMO.Database;
using Progetto_Esame_PMO.Visitor_Pattern;


namespace Progetto_Esame_PMO.Database
{
    // classe in cui vengono definiti i vari metodi dell'interfaccia 'IDb' personalizzandoli per la tabella 'mamrellate' del database
    class DbMarmellata : IDb, Node
    {
        // inizializzazione dell'istanza in modo da non doverla richiamare in ogni funzione
        IQuery q = IQuery.Instance();

        // definizione del metodo che permette di aggiungere un elemento alla tabella 'vini' del database
        public void AddItem(object ob)
        {
            Marmellata m = (Marmellata)ob;

            // query per inserire i dati
            string str = "INSERT INTO marmellate VALUES (NULL,'" + m.GetFrutto() + "'," + m.GetAnno() + "," + m.GetDimensioneBarattolo() + "," + m.GetNrBarattoli() + ");";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo AddItem


        // definizione del metodo che permette di eliminare un elemento dalla tabella
        public void DeleteItem(ListViewItem.ListViewSubItem id)
        {

            // query per eliminare un elemento
            string str= "DELETE FROM marmellate WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteItem


        // definizione del metodo che permette di ripulire l'intera tabella 
        public void DeleteTable()
        {

            // query per ripulire completamente la tabella marmellate e la tabella id che tiene il conto degli id di tutte le tabelle (togliendo solo gli id riferiti alla tabella marmellate)
            string str = "DELETE FROM mamrellate; DELETE FROM sqlite_sequence WHERE name = 'marmellate'";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteTable


        // definizione del metodo che permette di modificare un elemento 
        public void ModifyItem(object ob, string nomeColonna, ListViewItem.ListViewSubItem id)
        {

            // query per modificare i dati
            string str = "UPDATE marmellate SET " + nomeColonna + " = '" + ob + "' WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo ModifyItem


        // definizione del metodo che mi restituisce il nome della tabella
        public string NameTable()
        {
            return "marmellate";
        }// end metodo NameTable


        // definizione del metodo per ottenere una lista di tutti gli elementi del db
        public List<string> Select(string nomeColonna)
        {

            List<string> m = new List<string>();

            // query per ottenere una lista di tutti gli elementi del db
            string str = "SELECT " + nomeColonna + " FROM marmellate ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo Select


        // definizione del metodo che restituisce unicalmente gli elementi del db
        public List<string> SelectDistinct(string nomeColonna)
        {
            List<string> m = new List<string>();
            
            // query per cercare gli elementi
            string str = "SELECT DISTINCT " + nomeColonna + " FROM marmellate ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectDistinct


        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(ListViewItem.ListViewSubItem id, string nomecolonna)
        {

            string m = null;

            // query per cercare gli elementi
            string str = "SELECT " + nomecolonna + " FROM marmellate WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectElement


        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(string id, string nomecolonna)
        {

            string m = null;

            // query per cercare gli elementi
            string str = "SELECT " + nomecolonna + " FROM marmellate WHERE id = " + id;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo SelectElement


        // definizione Accept
        public void Accept(Visitor v)
        {
            v.VisitMarmellate(this);
        }

    }// end DbMarmellata
}
