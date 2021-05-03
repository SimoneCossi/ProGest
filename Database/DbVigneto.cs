using Microsoft.Data.Sqlite;
using Progetto_Esame_PMO.Prodotti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Esame_PMO.Database
{
    // classe in cui vengono definiti tutti i vari metodi dell'interfaccia IDb per la tabella 'vigneti' del db
    class DbVigneto : IDb
    {
        // definizione del metodo che permette di aggiungere elementi nekllla tabella 'vigneti' del db
        public void AddItem(object ob)
        {
            Vigneto v = (Vigneto)ob;
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // query per inserire i dati
                insertCommand.CommandText = "INSERT INTO vigneti VALUES (NULL,'" + v.GetNome() + "'," + v.GetNrVitiMorte() + ")";
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }// end metodo AddItem

        // definizione del metodo che permette di eliminare un elemento dalla tabella
        public void DeleteItem(ListViewItem.ListViewSubItem id)
        {
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // query per eliminare un elemento 
                insertCommand.CommandText = "DELETE FROM vigneti WHERE id = " + id.Text;
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }// end metodo DeleteItem

        // definizione del metedo che permette di eliminare tutti gli elementi dalla tabella
        public void DeleteTable()
        {
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // query per ripulire completamente una tabella vini e la tabella utilizzata per gli id delle altre tabelle
                insertCommand.CommandText = "DELETE FROM vigneti; DELETE FROM sqlite_sequence WHERE name = 'vigneti'";
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }// end metodo DeleteTable

        // definizione del metodo che permette di modificare un elemento
        public void ModifyItem(object ob, string nomeColonna, ListViewItem.ListViewSubItem id)
        {
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // query per modificare i dati
                insertCommand.CommandText = "UPDATE vigneti SET " + nomeColonna + " = '" + ob + "' WHERE id = " + id.Text;
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
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
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // query per cercare gli elementi
                insertCommand.CommandText = "SELECT " + nomeColonna + " FROM vigneti ORDER BY id";
                SqliteDataReader reader = insertCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            m.Add(reader.GetString(0));
                        }
                    }
                }
                reader.Close();
                // chiudo il database
                db.Close();
            }
            return m;
        }// end metodo Select

        // definizione del metodo che restituisce senza ripetizioni gli elementi del db
        public List<string> SelectDistinct(string nomeColonna)
        {
            List<string> m = new List<string>();
            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // query per cercare gli elementi
                insertCommand.CommandText = "SELECT DISTINCT " + nomeColonna + " FROM vigneti ORDER BY id";
                SqliteDataReader reader = insertCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            m.Add(reader.GetString(0));
                        }
                    }
                }
                reader.Close();
                // chiudo il database
                db.Close();
            }
            return m;
        }// end metodo SelectDistinct

        // definizione del metodo che restituisce un attributo scelto dalla tabella
        public string SelectElement(ListViewItem.ListViewSubItem id, string nomecolonna)
        {
            string m = null;

            // recupero il percorso (path) del database
            string dbpath = Path.GetFullPath("DB_ProGest.db");
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // query per cercare gli elementi
                insertCommand.CommandText = "SELECT " + nomecolonna + " FROM vigneti WHERE id = " + id.Text;
                SqliteDataReader reader = insertCommand.ExecuteReader();
                reader.Read();
                m = reader.GetString(0);
                reader.Close();
                // chiudo il database
                db.Close();
            }
            return m;
        }// end metodo SelectElement
    }// end DbVigneto
}
