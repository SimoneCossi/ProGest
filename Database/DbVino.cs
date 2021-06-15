using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Esame_PMO.Prodotti;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;

namespace Progetto_Esame_PMO.Database
{
    // classe in cui vengono definiti i vari metodi dell`interfacciadatabase 'IDb' personalizzandoli per la tabella 'vini' del 
    class DbVino : IDb
    {
        // inizializzazione dell'istanza in modo da non doverla richiamare in ogni funzione
        IQuery q = IQuery.Instance();


        // definizione del metodo che permette di aggiungere un elemento alla tabella 'vini' del database
        public void AddItem(object ob)
        {
            Vino v = (Vino)ob;

            // query per inserire i dati
            string str = "INSERT INTO vini VALUES (NULL,'" + v.GetNome() + "'," + v.GetAnno() + ",'" + v.GetTipologia() + "','" + v.GetVigneto() + "'," + v.GetNrbottiglie() + ");";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo AddItem


        // definizione del metodo che permette di eliminare un elemento dalla tabella
        public void DeleteItem(ListViewItem.ListViewSubItem id)
        {

            // query per eliminare un elemento
            string str = "DELETE FROM vini WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteItem


        // definizione del metodo che permette di ripulire l'intera tabella 
        public void DeleteTable()
        {

            // query per ripulire completamente la tabella vini e la tabella id che tiene il conto degli id di tutte le tabelle (togliendo solo gli id riferiti alla tabella vini)
            string str = "DELETE FROM vini; DELETE FROM sqlite_sequence WHERE name = 'vini'";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo DeleteTable


        // definizione del metodo che permette di modificare un elemento 
        public void ModifyItem(object ob, string nomeColonna, ListViewItem.ListViewSubItem id)
        {

            // query per modificare i dati
            string str = "UPDATE vini SET " + nomeColonna + " = '" + ob + "' WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(str);

        }// end metodo ModifyItem


        // definizione del metodo che mi restituisce il nome della tabella
        public string NameTable()
        {
            return "vini";
        }// end metodo NameTable


        // definizione del metodo per ottenere una lista di tutti gli elementi del db
        public List<string> Select(string nomeColonna)
        {

            List<string> m = new List<string>();

            // query per ottenere una lista di tutti gli elementi del db
            string str = "SELECT " + nomeColonna + " FROM vini ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;

        }// end metodo Select


        // definizione del metodo che restituisce unicalmente gli elementi del db
        public List<string> SelectDistinct(string nomeColonna)
        {

            List<string> m = new List<string>();

            // query per cercare gli elementi
            string str = "SELECT DISTINCT " + nomeColonna + " FROM vini ORDER BY id";
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;
        }// end metodo SelectDistinct


        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(ListViewItem.ListViewSubItem id, string nomecolonna)
        {

            string m = null;

            // query per cercare gli elementi
            string str = "SELECT " + nomecolonna + " FROM vini WHERE id = " + id.Text;
            // passo la stringa al metodo che mi effettuerà la query al db
            q.Query(ref m, str);
            return m;
        }// end metodo SelectElement


    }// end DbVino
}
