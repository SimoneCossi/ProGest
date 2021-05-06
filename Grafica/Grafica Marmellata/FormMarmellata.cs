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

namespace Progetto_Esame_PMO.Grafica.Grafica_Marmellata
{
    public partial class FormMarmellata : Form
    {
        private FormHome home;

        public FormMarmellata(FormHome home)
        {
            InitializeComponent();
            this.home = home;

            DbMarmellata m = new DbMarmellata();

            // creo delle liste di stringhe e attribuisco a ciascuna le varie informazioni contenute nel database
            List<string> FruttoMarmellata = new List<string>();
            FruttoMarmellata = m.Select("frutto");

            List<string> AnnoMarmellate = new List<string>();
            AnnoMarmellate = m.Select("anno");

            List<string> DimensioneBarattoli = new List<string>();
            DimensioneBarattoli= m.Select("dimensione");

            List<string> NrBarattoli = new List<string>();
            NrBarattoli = m.Select("nrbarattoli");

            List<string> Id = new List<string>();
            Id = m.Select("id");

            // ciclo per aggiungere tutti gli item e i subitem alla listview
            for (int i = 0; i < Id.Count; i++)
            {
                ListViewItem entryListItem = listViewDettagli.Items.Add(FruttoMarmellata[i]);
                entryListItem.UseItemStyleForSubItems = true;
                ListViewItem.ListViewSubItem annoItem = entryListItem.SubItems.Add(AnnoMarmellate[i]);
                ListViewItem.ListViewSubItem tipologiaItem = entryListItem.SubItems.Add(DimensioneBarattoli[i]);
                ListViewItem.ListViewSubItem vignetoItem = entryListItem.SubItems.Add(NrBarattoli[i]);
                ListViewItem.ListViewSubItem id = entryListItem.SubItems.Add(Id[i]);
            }
        }// end form


        // evento che apre un form dove è possibile aggiungere una marmellata
        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            FormAggiungiMarmellata a = new FormAggiungiMarmellata(this, this.home);
            a.Show();
        }// end button aggiungi click


        // evento che apre la home page quando viene chiusa la pagina
        protected override void OnClosed(EventArgs e)
        {
            this.home.Show();
            base.OnClosed(e);
        }// end OnClosed


        // evento che apre un form che permette di modifcare l'elemento su cui si è premuto per due volte 
        private void listViewDettagli_DoubleClick(object sender, EventArgs e)
        {
            ListView res = (ListView)sender;
            FormModificaMarmellata m = new FormModificaMarmellata(res.SelectedItems[0].SubItems[4], this, this.home);
            m.Show();
        }// end doubleclick
    }
}
