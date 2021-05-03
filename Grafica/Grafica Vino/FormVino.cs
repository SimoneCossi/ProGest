using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progetto_Esame_PMO.Database;
using Progetto_Esame_PMO.Grafica.Grafica_Vino;

namespace Progetto_Esame_PMO.Grafica
{
    public partial class FormVino : Form
    {
        private FormHome home; 
        public FormVino(FormHome home)
        {
            InitializeComponent();
            this.home = home; 

            DbVino v = new DbVino();

            // creo delle liste di stringhe e attribuisco a ciascuna le varie informazioni contenute nel database
            List<string> NomiVini = new List<string>();
            NomiVini = v.Select("nome");

            List<string> AnnoVini = new List<string>();
            AnnoVini = v.Select("anno");

            List<string> TipologiaVini = new List<string>();
            TipologiaVini = v.Select("tipologia");

            List<string> VignetoVini = new List<string>();
            VignetoVini = v.Select("vigneto");

            List<string> NrBottiglieVini = new List<string>();
            NrBottiglieVini = v.Select("nrbottiglie");

            List<string> Id = new List<string>();
            Id = v.Select("id");

            // ciclo per aggiungere tutti gli item e i subitem alla listview
            for (int i = 0; i < Id.Count; i++)
            {
                ListViewItem entryListItem = listViewDettagli.Items.Add(NomiVini[i]);
                entryListItem.UseItemStyleForSubItems = true;
                ListViewItem.ListViewSubItem annoItem = entryListItem.SubItems.Add(AnnoVini[i]);
                ListViewItem.ListViewSubItem tipologiaItem = entryListItem.SubItems.Add(TipologiaVini[i]);
                ListViewItem.ListViewSubItem vignetoItem = entryListItem.SubItems.Add(VignetoVini[i]);
                ListViewItem.ListViewSubItem nrBottiglieItem = entryListItem.SubItems.Add(NrBottiglieVini[i]);
                ListViewItem.ListViewSubItem id = entryListItem.SubItems.Add(Id[i]);
            }
        }// end form


        // evento che apre la home page quando viene chiusa la pagina
        protected override void OnClosed(EventArgs e)
        {
            this.home.Show();
            base.OnClosed(e);
        }// end OnClosed


        // evento che apre un form dove poter modificare l'elemento selezionato
        private void listViewDettagli_DoubleClick(object sender, EventArgs e)
        {
            ListView res = (ListView)sender; 
            FormModificaVino v = new FormModificaVino(res.SelectedItems[0].SubItems[5], this, this.home);
            v.Show();
        }// end doubleclick


        // evento che apre un form dove è possibile aggiungere un vino
        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            FormAggiungiVino a = new FormAggiungiVino(this, this.home);
            a.Show();
        }// end button aggiungi click


        private void FormVino_Load(object sender, EventArgs e)
        {

        }
    }
}
