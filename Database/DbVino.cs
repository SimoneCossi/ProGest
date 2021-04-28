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
    // classe in cui definisco i vari metodi dell`interfaccia `IDb` personalizzandoli per la tabella `vini` del database
    class DbVino : IDb
    {
        // definizione del il metodo che permette di aggiungere un elemento alla tabella `vini` del database
        public void AddItem(object ob)
        {
            Vino v = (Vino)ob;
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
                insertCommand.CommandText = "INSERT INTO vini VALUES (NULL,'" + v.GetNome() + "'," + v.GetAnno() + ",'" + v.GetTipologia() + "','" + v.GetVigneto() + "'," + v.GetNrbottiglie() + ");";
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }

        // definizione del metodo che permette di eliminare un elemento da una tabella
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
                insertCommand.CommandText = "DELETE FROM vini WHERE id = " + id.Text ;
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }

        // definizione del metodo che permette di ripulire l'intera tabella 
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
                insertCommand.CommandText = "DELETE FROM vini; DELETE FROM sqlite_sequence WHERE name = 'vini'";
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }

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
                insertCommand.CommandText = "UPDATE vini SET " + nomeColonna + " = '" + ob + "' WHERE id = " + id.Text ;
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }

        // definizione del metodo che mi restituisce il nome della tabella
        public string NameTable()
        {
            return "vini";
        }

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
                insertCommand.CommandText = "SELECT " + nomecolonna + " FROM vini WHERE id = " + id.Text;
                SqliteDataReader reader = insertCommand.ExecuteReader();
                reader.Read();
                m = reader.GetString(0);
                reader.Close();
                // chiudo il database
                db.Close();
            }
            return m;
        }

        // definizione del metodo per ottenere una lista di tutti gli elementi del db
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
                insertCommand.CommandText = "SELECT " + nomeColonna + " FROM vini ORDER BY id";
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
        }


        // definizione del metodo che restituisce unicalmente gli attributi del db
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
                insertCommand.CommandText = "SELECT DISTINCT " + nomeColonna + " FROM vini ORDER BY id";
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
        }

    }
}
