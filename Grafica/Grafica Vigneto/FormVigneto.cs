using Progetto_Esame_PMO.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Esame_PMO.Grafica.Grafica_Vigneto
{
    public partial class FormVigneto : Form
    {
        private FormHome home;
        public FormVigneto(FormHome home)
        {
            InitializeComponent();
            this.home = home;

            DbVigneto w = new DbVigneto();

            // dichiarazione e definizione di variabili ( list<string> e array[int])
            List<string> NomiVigneti = new List<string>();
            NomiVigneti = w.Select("nome");

            List<string> NrVitiMorte = new List<string>();
            NrVitiMorte = w.Select("nrvitimorte");

            List<string> Id = new List<string>();
            Id = w.Select("id");

            // ciclo per aggiungere tutti gli item e i subitem alla listview
            for (int i = 0; i < Id.Count; i++)
            {
                ListViewItem entryListItem = listViewDettagli.Items.Add(NomiVigneti[i]);
                entryListItem.UseItemStyleForSubItems = true;
                ListViewItem.ListViewSubItem nrvitmorteItem = entryListItem.SubItems.Add(NrVitiMorte[i]);
                ListViewItem.ListViewSubItem id = entryListItem.SubItems.Add(Id[i]);
            }
        }// end form


        // evento che apre un nuovo form dove sarà possibile aggiungere un nuovo vigneto
        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            FormAggiungiVigneto c = new FormAggiungiVigneto(this, this.home);
            c.Show();
        }// end button aggiungi click


        // evento che apre la home page quando viene chiusa la pagina
        protected override void OnClosed(EventArgs e)
        {
            this.home.Show();
            base.OnClosed(e);
        }// end OnClosed


        // evento che apre un form dove è possibile modificare il vigneto selezionato
        private void listViewDettagli_DoubleClick(object sender, EventArgs e)
        {
            ListView res = (ListView)sender;
            FormModificaVigneto w = new FormModificaVigneto(res.SelectedItems[0].SubItems[2], this, this.home);
            w.Show();
        }// end double click
    }
}
