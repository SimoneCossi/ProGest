using Progetto_Esame_PMO.Database;
using Progetto_Esame_PMO.Prodotti;
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
    public partial class FormAggiungiMarmellata : Form
    {

        private FormMarmellata  formmarmellata;
        private FormHome        home;

        public FormAggiungiMarmellata(FormMarmellata formmarmellata, FormHome home)
        {
            InitializeComponent();
            this.formmarmellata = formmarmellata;
            this.home           = home;

            DbMarmellata m = new DbMarmellata();

            // liste di stringhe per inserire i vari valori nei vari form
            List<string> Frutti = new List<string>();
            Frutti = m.SelectDistinct("frutto");

            List<string> DimensioniBarattoli = new List<string>();
            DimensioniBarattoli = m.SelectDistinct("dimensione");

            List<string> NrBarattoli = new List<string>();
            NrBarattoli = m.SelectDistinct("nrbarattoli");


            // ciclo che aggiunge i frutti già presenti nel db nel combobox frutta
            for (int i = 0; i < Frutti.Count; i++)
            {
                comboBoxFrutto.Items.Add(Frutti[i]);
            }

            // ciclo che aggiunge le dimensioni dei barattoli già presenti nel db nel combobox dimensioni
            for (int i = 0; i < DimensioniBarattoli.Count; i++)
            {
                comboBoxDimensioni.Items.Add(DimensioniBarattoli[i]);
            }

            // ciclo che aggiunge i numeri dei barattoli già presenti nel db nel combobox nrbarattoli
            for (int i = 0; i < NrBarattoli.Count; i++)
            {
                comboBoxNrBarattoli.Items.Add(NrBarattoli[i]);
            }
        }// end form aggiungi marmellata



        // evento che aggiunge un elemento al db e chiude il form corrente tornando a quello precedente
        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            // if che fa in modo che il pulsante non faccia nulla finchè l'utente non avrà inserito tutti i dati
            if (this.comboBoxFrutto.Text != "" &&
                this.comboBoxDimensioni.Text != "" &&
                this.comboBoxNrBarattoli.Text != "")
            {
                // creazione di un oggetto di tipo vino e deefinizione di tutti i suoi attributi in modo da passare alla
                // query solo un oggetto e non tante stringhe che dovranno pure essere in ordine corretto
                Marmellata marmellata = new Marmellata();
                marmellata.SetFrutto(this.comboBoxFrutto.Text);
                marmellata.SetAnno(decimal.ToInt16(this.numericUpDown1.Value));
                marmellata.SetDimensioniBarattolo(int.Parse(this.comboBoxDimensioni.Text));
                marmellata.SetNrBarattoli(int.Parse(this.comboBoxNrBarattoli.Text));

                DbMarmellata m = new DbMarmellata();
                m.AddItem(marmellata);

                // chiusura del form attuale a apertura del form precedente
                this.formmarmellata.Dispose();
                FormMarmellata frm = new FormMarmellata(this.home);
                frm.Show();
                this.Dispose();
            }// end if
        }// end buttonAggiungi
    }
}
