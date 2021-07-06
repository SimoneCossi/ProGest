using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Esame_PMO.Database
{
    // interfaccia dove dichiaro i vari metodi che serviranno per interagire con il database
    interface IDb
    {
        // metodo per aggiungere un elemento alla tabella
        void AddItem(object ob);

        // metodo per eliminare un oggetto dalla tabella
        void DeleteItem(ListViewItem.ListViewSubItem id);

        // metodo per ripulire completamente una tabella
        void DeleteTable();

        // metodo per modificare un oggetto all`interno di una tabella
        void ModifyItem(object ob, string nomeColonna, ListViewItem.ListViewSubItem id);

        // metodo che restituisce il nome della tabella
        string NameTable();

        // metodo per cercare gli elementi all`interno delle tabelle
        string SelectElement(ListViewItem.ListViewSubItem id, string nomecolonna);

        // metodo di prova per leggere da database
        List<string> Select(string nomeColonna);

        // metodo per stampare univocalmente dati nel db
        List<string> SelectDistinct(string nomeColonna);
    }
}
