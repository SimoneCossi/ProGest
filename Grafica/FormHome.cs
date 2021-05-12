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
using Progetto_Esame_PMO.Prodotti;
using Progetto_Esame_PMO.Grafica;
using Progetto_Esame_PMO.Grafica.Grafica_Vigneto;
using Progetto_Esame_PMO.Grafica.Grafica_Marmellata;

namespace Progetto_Esame_PMO
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            // inizializzo una stringa che andrà a contenere i nomi dei vari elementi da poter cercare
            List<string> righe = new List<string>();

            // aggiungo i vari nomi degli elementi alla stringa
            DbVino v = new DbVino();
            DbVigneto w = new DbVigneto();
            DbMarmellata m = new DbMarmellata();
            righe.Add(v.NameTable());
            righe.Add(w.NameTable());
            righe.Add(m.NameTable());


            // ciclo che aggiunge al menu di scelta i vari nomi inseriti nella stringa 'righe'
            for (int i = 0; i < righe.Count; i++)
            {
                VisualizzaTabella.Items.Add(righe[i]);
            }

        }// end form

        // evento del button apri
        private void ButtonApri_Click(object sender, EventArgs e)
        {

            // leggo cosa è stato selezionato all'interno del 'tableLayoutPanelProdotti'
            switch (VisualizzaTabella.SelectedItem.ToString())
            {
                // caso in cui non venga scelto nulla non succede nulla
                case "":
                    break;

                // caso in cui viene scelto di visualizzare i vini
                case "vini":
                    // apertura del form dove vengono visualizzati i dati nella tabella vini del db
                    FormVino v = new FormVino(this);
                    this.Hide();
                    v.Show();
                    break;
                
                // caso in cui viene scelto di visualizzare vigneti
                case "vigneti":
                    // apertura del form dove vengono visualizzati i dati della tabella vigneti del db
                    FormVigneto w = new FormVigneto(this);
                    this.Hide();
                    w.Show();
                    break;

                // caso in cui viene scelto di visualizzare marmellate
                case "marmellate":
                    // apertura del form dove vengono visualizzati i dati della tabella marmellate del db
                    FormMarmellata m = new FormMarmellata(this);
                    this.Hide();
                    m.Show();
                    break;




            }// end button apri
        }
    }
}
