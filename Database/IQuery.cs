using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Progetto_Esame_PMO.Prodotti;

namespace Progetto_Esame_PMO.Database
{
    // SINGLETON PATTERN
    class IQuery
    {
        // dichiarazione attributi
        private static IQuery instance = null;
        private string dbpath;
       
        protected IQuery()
        {
            // inizializzazione di istanza...
            // recupero il percorso (path) del database
            dbpath = Path.GetFullPath("DB_ProGest.db");
        }// end IQuery

        // 
        public static IQuery Instance()
        {
            if (instance == null)
                instance = new IQuery();
            return instance;
        }

        // metodo pubblico per aggiungere, modificare, eliminare elementi dal db
        public void Query(string str)
        {
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // query per inserire i dati
                // le viene passata la stringa contente la query da eseguire
                insertCommand.CommandText = str.ToString();
                insertCommand.ExecuteReader();

                // chiudo il database
                db.Close();
            }
        }// end Query

        // metodo pubblico per cercare elementi nel db
        public void Query(ref List<string> list, string str)
        {

            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // query per cercare gli elementi
                // le viene passata la stringa contente la query da eseguire
                insertCommand.CommandText = str.ToString();
                SqliteDataReader reader = insertCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            list.Add(reader.GetString(0));
                        }
                    }
                }
                reader.Close();
                // chiudo il database
                db.Close();
            }
        }// end Query

        // metodo che restituisce un attributo scelto dalla tabella
        public string Query(ref string m, string str)
        {
            using (SqliteConnection db =
                new SqliteConnection($"Filename={dbpath}"))
            {
                // apro il database
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // query per cercare gli elementi
                // le viene passata la stringa contente la query da eseguire
                insertCommand.CommandText = str.ToString();
                SqliteDataReader reader = insertCommand.ExecuteReader();
                reader.Read();
                m = reader.GetString(0);
                reader.Close();
                // chiudo il database
                db.Close();
            }
            return str;
        }// end query
    }
}
