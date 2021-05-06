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

namespace Progetto_Esame_PMO.Grafica.Grafica_Vino
{
    public partial class FormAggiungiVino : Form
    {
        private FormVino formvino;
        private FormHome home;

        public FormAggiungiVino(FormVino formvino, FormHome home)
        {
            InitializeComponent();

            this.formvino  = formvino;
            this.home      = home;

            DbVino v    = new DbVino();
            DbVigneto w = new DbVigneto();

            // liste di stringhe per inserire nei vari combobox valori già esistenti
            List<string> NomiVini = new List<string>();
            NomiVini = v.SelectDistinct("nome");

            List<string> TipologiaVini = new List<string>();
            TipologiaVini = v.SelectDistinct("tipologia");

            List<string> VignetoVini = new List<string>();
            VignetoVini = w.SelectDistinct("nome");

            List<string> NrBottiglieVini = new List<string>();
            NrBottiglieVini = v.SelectDistinct("nrbottiglie");

            // ciclo che aggiunge i nomi già presenti nel db nel combobox nome
            for ( int i = 0; i < NomiVini.Count; i++)
            {
                comboBoxNome.Items.Add(NomiVini[i]);
            }

            // ciclo che aggiunge le tipologie già presenti nel db nel combobox tipologia
            for (int i = 0; i < TipologiaVini.Count; i++)
            {
                comboBoxTipologia.Items.Add(TipologiaVini[i]);
            }

            // ciclo che aggiunge i vari vigneti presenti nel db nel combobox vigneti
            for (int i = 0; i < VignetoVini.Count; i++)
            {
                comboBoxVigneto.Items.Add(VignetoVini[i]);
            }

            // ciclo che aggiunge i vari numeri di bottiglie al combobox
            // anche se numerico viene utilizzato un combobox perchè spesso si produce lo stesso quantitativo
            // di bottiglie per vini diversi e il numeric updown non permette di selezionare quantità già presenti
            for ( int i = 0; i < NrBottiglieVini.Count; i ++)
            {
                comboBoxBottiglie.Items.Add(NrBottiglieVini[i]);
            }
        }// end FormAggiungiVino



        // evento che aggiunge un elemento al db e chiude il form corrente tornando a quello precedente
        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            int NrBottiglie;
            // if che fa in modo che il pulsante non faccia nulla finchè l'utente non avrà inserito tutti i dati
            if( this.comboBoxNome.Text      != "" && 
                this.comboBoxTipologia.Text != "" &&
                this.comboBoxVigneto.Text   != "" &&
                this.comboBoxBottiglie.Text != "" &&
                int.TryParse(this.comboBoxBottiglie.Text, out NrBottiglie))
            {
                // creazione di un oggetto di tipo vino e deefinizione di tutti i suoi attributi in modo da passare alla
                // query solo un oggetto e non tante stringhe che dovranno pure essere in ordine corretto
                Vino vino = new Vino();
                vino.SetNome(this.comboBoxNome.Text);
                vino.SetAnno(decimal.ToInt16(this.numericUpDown1.Value));
                vino.SetTipologia(this.comboBoxTipologia.Text);
                vino.SetVigneto(this.comboBoxVigneto.Text);
                vino.SetNrbottiglie(NrBottiglie);

                DbVino v = new DbVino();
                v.AddItem(vino);

                // chiusura del form attuale a apertura del form precedente
                this.formvino.Dispose();
                FormVino frm = new FormVino(this.home);
                frm.Show();
                this.Dispose();
            }// end if
        }//end "ButtonAggiungiClick
    }
}
