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
            righe.Add(v.NameTable());
            righe.Add(w.NameTable());


            // ciclo che aggiunge al menu di scelta i vari nomi inseriti nella stringa 'righe'
            for (int i = 0; i < righe.Count; i++)
            {
                VisualizzaTabella.Items.Add(righe[i]);
            }
            


        }

        // evento del button apri
        private void ButtonApri_Click(object sender, EventArgs e)
        {
            // leggo cosa è stato selezionato allìnterno del 'tableLayoutPanelProdotti'
            switch (VisualizzaTabella.SelectedItem.ToString())
            {
                // caso in cui viene scelto di visualizzare i vini
                case "vini":
                    // apertura del form dove vengono visualizzati i dati nella tabella vini del db
                    FormVino v = new FormVino(this);
                    this.Hide();
                    v.Show();
                    break;

                case "vigneti":
                    // apertura del form dove vengono visualizzati i dati della tabella vigneti del db
                    FormVigneto w = new FormVigneto(this);
                    this.Hide();
                    w.Show();
                    break;



            }// end button apri
        }
    }
}
