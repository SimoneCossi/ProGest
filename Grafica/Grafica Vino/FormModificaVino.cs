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

namespace Progetto_Esame_PMO.Grafica
{
    public partial class FormModificaVino : Form
    {

        ListViewItem.ListViewSubItem id;
        private FormVino formvino;
        private FormHome home;

        public FormModificaVino(ListViewItem.ListViewSubItem id, FormVino formvino, FormHome home)
        {
            InitializeComponent();
            
            this.id = id;
            this.formvino = formvino;
            this.home = home;

            DbVino v = new DbVino();

            // leggo dal databese i dai necessari e li passo ad delle stringhe per poi passarle ai vari textbox che li stamperanno a video
            string nome = v.SelectElement(id, "nome");
            textBox1.Text = nome;

            string anno = v.SelectElement(id, "anno");
            textBox2.Text = anno;

            string tipologia = v.SelectElement(id, "tipologia");
            textBox3.Text = tipologia;

            string vigneto = v.SelectElement(id, "vigneto");
            textBox4.Text = vigneto;

            string nrbottiglie = v.SelectElement(id, "nrbottiglie");
            textBox5.Text = nrbottiglie;

        }

        private void ButtonElimina_Click(object sender, EventArgs e)
        {

            // metodo per eliminare un elemento dal database
            DbVino v = new DbVino();
            v.DeleteItem(this.id);

            // chiusura del form attuale a apertura del form precedente
            this.formvino.Dispose();
            FormVino frm = new FormVino(this.home);
            frm.Show();
            this.Dispose();

        }

        // evento in cui viene premuto il bottone con "applica modifiche"
        private void ButtonApplica_Click(object sender, EventArgs e)
        {
            // caso in cui sono stati modificati entrambi gli elementio modificabili 
            if (this.comboBoxNomeVino.Text != "" && this.numericUpDownNrBottiglie.Value != 0)
            {
                DbVino v = new DbVino();

                // conversione di valori da string a int e da decimal a int per eseguire la sottrazione delle bottilgie vendute dal totale
                string nrbottiglie = v.SelectElement(this.id, "nrbottiglie");
                int NrBottiglie = int.Parse(nrbottiglie);
                decimal BottiglieVendute = this.numericUpDownNrBottiglie.Value;
                decimal NuovoNrBottiglie = NrBottiglie - BottiglieVendute;

                // metodo chiamato 2 volte per apportare tutte le modifiche
                v.ModifyItem(this.comboBoxNomeVino.Text, "nome",  this.id);
                v.ModifyItem(NuovoNrBottiglie, "nrbottiglie", this.id);

                // chiudo e riarpo i il form recedente in modo da visualizzare le modifiche
                this.formvino.Dispose();
                FormVino frm = new FormVino(this.home);
                frm.Show();
                this.Dispose();
            }
            // caso in cui l'utente desideri modificare solo il nome
            else if (this.comboBoxNomeVino.Text != "" && this.numericUpDownNrBottiglie.Value == 0)
            {
                // metodo per modifacare un elemento nel db
                DbVino v = new DbVino();
                v.ModifyItem(this.comboBoxNomeVino.Text, "nome", this.id);

                // chiudo e riarpo i il form recedente in modo da visualizzare le modifiche
                this.formvino.Dispose();
                FormVino frm = new FormVino(this.home);
                frm.Show();
                this.Dispose();
            }
            // caso in cui l'utente deisideri modificare solo il numero di bottiglie
            else if (this.comboBoxNomeVino.Text == "" && this.numericUpDownNrBottiglie.Value != 0)
            {
                DbVino v = new DbVino();
                Console.WriteLine("if3");

                // conversione di valori da string a int e da decimal a int per eseguire la sottrazione delle bottilgie vendute dal totale
                string nrbottiglie = v.SelectElement(this.id, "nrbottiglie");
                int NrBottiglie = int.Parse(nrbottiglie);
                decimal BottiglieVendute = this.numericUpDownNrBottiglie.Value;
                decimal NuovoNrBottiglie = NrBottiglie - BottiglieVendute;

                // metodo per modifacare un elemento nel db
                v.ModifyItem(NuovoNrBottiglie, "nrbottiglie", this.id);

                // chiudo e riarpo i il form recedente in modo da visualizzare le modifiche
                this.formvino.Dispose();
                FormVino frm = new FormVino(this.home);
                frm.Show();
                this.Dispose();
            }
            
            // nel caso in cui non è stato modificato nessun valore non succede nulla

        }

    }
}
