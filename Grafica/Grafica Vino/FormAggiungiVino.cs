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

            this.formvino = formvino;
            this.home = home;

            DbVino v = new DbVino();

            // liste di stringhe per inserire nei vari combobox valori già esistenti
            List<string> NomiVini = new List<string>();
            NomiVini = v.SelectDistinct("nome");

            List<string> TipologiaVini = new List<string>();
            TipologiaVini = v.SelectDistinct("tipologia");

            // trasformarlo per prendere i nomi dal db viogneti
            // List<string> VignetoVini = new List<string>();
            // DbVigneti vigneti = new DbVigneti("nome");
            // VignetoVini = vigneti.SelectDistinct("nome");
            List<string> VignetoVini = new List<string>();
            VignetoVini = v.SelectDistinct("vigneto");

            List<string> NrBottiglieVini = new List<string>();
            NrBottiglieVini = v.SelectDistinct("nrbottiglie");

            // ciclo che aggiunge i nomi già presenti nel db nel combobox nome
            for ( int i = 0; i < NomiVini.Count; i++)
            {
                comboBoxNome.Items.Add(NomiVini[i]);
            }

            // ciclo che aggiunge le tipologie già presenti nel db nel combobox tipologia
            for (int i =0; i < TipologiaVini.Count; i++)
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




        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            // if che fa in modo che il pulsante non fgaccia nulla finchè l'utente non avrà inserito tutti i dati
            if( this.comboBoxNome.Text.ToString()      != "" && 
                this.comboBoxTipologia.Text.ToString() != "" &&
                this.comboBoxVigneto.Text.ToString()   != "" &&
                this.comboBoxBottiglie.Text.ToString() != "" )
            {
                // creo un oggetto di tipo vino e definisco i suoi attributi in modo dda passare alla query per aggiungere l'elemento solo un oggetto e non tante stringhe
                Vino vino = new Vino();
                vino.SetNome(this.comboBoxNome.Text.ToString());
                vino.SetAnno(this.numericUpDown1.Value);
                vino.SetTipologia(this.comboBoxTipologia.Text.ToString());
                vino.SetVigneto(this.comboBoxVigneto.Text.ToString());
                vino.SetNrbottiglie(int.Parse(this.comboBoxBottiglie.Text.ToString()));

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
