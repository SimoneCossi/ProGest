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
using Progetto_Esame_PMO.Prodotti;

namespace Progetto_Esame_PMO.Grafica.Grafica_Vigneto
{
    public partial class FormAggiungiVigneto : Form
    {

        private FormVigneto formvigneto;
        private FormHome    formhome;

        public FormAggiungiVigneto(FormVigneto formvigneto, FormHome formhome)
        {
            InitializeComponent();
            this.formvigneto    = formvigneto;
            this.formhome       = formhome;

            DbVigneto w = new DbVigneto();

            // dichiarazione e definizione di variabili ( list<string> e array[int])
            List<string> NomiVigneti = new List<string>();
            NomiVigneti = w.SelectDistinct("nome");

            List<string> NrVitiMorte = new List<string>();
            NrVitiMorte = w.SelectDistinct("nrvitimorte");

            // ciclo che aggiunge al combobox i vari nomi dei vigneti
            for ( int i = 0; i < NomiVigneti.Count; i++)
            {
                comboBoxNome.Items.Add(NomiVigneti[i]);
            }


        }// end form

        // salva le modifiche e chiude il form attuale andando a riaprire il form precedente
        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            if( this.comboBoxNome.Text != "" )
            {
                // creazione di un oggetto di tipo vigneto in modo da passare alla query un singolo oggetto e non 
                // più valori 
                Vigneto vigneto = new Vigneto();
                vigneto.SetNome(this.comboBoxNome.Text);
                vigneto.SetNrVitiMorte(decimal.ToInt16(this.numericUpDownNrVitiMorte.Value));

                DbVigneto w = new DbVigneto();
                w.AddItem(vigneto);

                // chiusura del form attuale a apertura del form precedente
                this.formvigneto.Dispose();
                FormVigneto frm = new FormVigneto(this.formhome);
                frm.Show();
                this.Dispose();
            }// end if
        }// end Button aggiungi click
    }
}
