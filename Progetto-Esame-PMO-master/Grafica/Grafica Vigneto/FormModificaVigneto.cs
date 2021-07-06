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
    public partial class FormModificaVigneto : Form
    {
        ListViewItem.ListViewSubItem id;
        private FormVigneto formvigneto;
        private FormHome home;

        public FormModificaVigneto(ListViewItem.ListViewSubItem id, FormVigneto formvigneto, FormHome home)
        {
            InitializeComponent();
            this.id = id;
            this.formvigneto = formvigneto;
            this.home = home;

            DbVigneto w = new DbVigneto();

            // lettura dal db dei dati necessari
            // stampa dei dati tramite textbox
            textBox1.Text = w.SelectElement(id, "nome");

            textBox2.Text = w.SelectElement(id, "nrvitimorte");

        }// end form


        private void ButtonElimina_Click(object sender, EventArgs e)
        {
            // metodo per eliminare un elemento dal database
            DbVigneto w= new DbVigneto();
            w.DeleteItem(this.id);

            // chiusura del form attuale a apertura del form precedente
            this.formvigneto.Dispose();
            FormVigneto frm = new FormVigneto(this.home);
            frm.Show();
            this.Dispose();
        }// end button elemina


        // evento che applica le modifiche effettuate dall'utente
        private void ButtonApplica_Click(object sender, EventArgs e)
        {
            // caso in cui l'utente voglia moidifcare entrambi gli elementi
            if (this.comboBoxNomeVigneto.Text != "" && this.numericUpDownNrViti.Value != 0)
            {
                DbVigneto w = new DbVigneto();

                // conversione dei valori da decimal a int per eseguire la sottrazione dei valori 
                int nrvitimorte     = int.Parse(w.SelectElement(this.id, "nrvitimorte"));
                int vitisostituite  = decimal.ToInt32(this.numericUpDownNrViti.Value);
                int viti = nrvitimorte - vitisostituite;

                // metodo chiamato 2 volte per apportare tutte le modifiche
                w.ModifyItem(this.comboBoxNomeVigneto.Text, "nome", this.id);
                w.ModifyItem(viti, "nrvitimorte", this.id);

                // chiusura del form attuale a apertura del form precedente
                this.formvigneto.Dispose();
                FormVigneto frm = new FormVigneto(this.home);
                frm.Show();
                this.Dispose();
            }
            // caso in cui l'utente voglia modificare solo il numero di viti
            else if(this.comboBoxNomeVigneto.Text == "" && this.numericUpDownNrViti.Value != 0)
            {
                DbVigneto w = new DbVigneto();

                // conversione dei valori da decimal a int per eseguire la sottrazione dei valori 
                int nrvitimorte = int.Parse(w.SelectElement(this.id, "nrvitimorte"));
                int vitisostituite = decimal.ToInt32(this.numericUpDownNrViti.Value);
                int viti = nrvitimorte - vitisostituite;

                // chiamata del metodo per modificare un elemento
                w.ModifyItem(viti, "nrvitimorte", this.id);

                // chiusura del form attuale a apertura del form precedente
                this.formvigneto.Dispose();
                FormVigneto frm = new FormVigneto(this.home);
                frm.Show();
                this.Dispose();
            }
            // caso in cui l'utente voglia moidifcare solo il nome del vigneto
            else if(this.comboBoxNomeVigneto.Text != "" && this.numericUpDownNrViti.Value == 0)
            {
                DbVigneto w = new DbVigneto();

                // metodo chiamato 2 volte per apportare tutte le modifiche
                w.ModifyItem(this.comboBoxNomeVigneto.Text, "nome", this.id);

                // chiusura del form attuale a apertura del form precedente
                this.formvigneto.Dispose();
                FormVigneto frm = new FormVigneto(this.home);
                frm.Show();
                this.Dispose();
            }

            // se l'utente scegli di non modificare nulla e preme il  pulsante non succede nulla

        }// end applica
    }
}
