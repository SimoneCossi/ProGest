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
    public partial class FormModificaMarmellata : Form
    {

        ListViewItem.ListViewSubItem id;
        private FormMarmellata formmarmellata;
        private FormHome home;

        public FormModificaMarmellata(ListViewItem.ListViewSubItem id, FormMarmellata formmarmellata, FormHome home)
        {
            InitializeComponent();

            this.id = id;
            this.formmarmellata = formmarmellata;
            this.home = home;

            DbMarmellata m = new DbMarmellata();

            // lettura dal databese dei dati necessari e passaggio ai vari textbox che li stamperanno a video
            textBox1.Text = m.SelectElement(id, "frutto");

            textBox2.Text = m.SelectElement(id, "anno");

            textBox3.Text = m.SelectElement(id, "dimensione");

            textBox4.Text = m.SelectElement(id, "nrbarattoli");

        }// end form


        // evento che elimina l'elemento attuale dal db 
        private void ButtonElimina_Click(object sender, EventArgs e)
        {
            // metodo per eliminare un elemento dal database
            DbMarmellata m = new DbMarmellata();
            m.DeleteItem(this.id);

            // chiusura del form attuale a apertura del form precedente
            this.formmarmellata.Dispose();
            FormMarmellata frm = new FormMarmellata(this.home);
            frm.Show();
            this.Dispose();

        }// end button elimina


        // evento in cui viene premuto il bottone con "applica modifiche"
        private void ButtonApplica_Click(object sender, EventArgs e)
        {
            // caso in cui sia stato modificato il valore
            if (this.numericUpDownNrBottiglie.Value != 0)
            {
                DbMarmellata m = new DbMarmellata();

                // conversione di valori da string a int e da decimal a int per eseguire la sottrazione delle bottilgie vendute dal totale
                int nrbarattoli = int.Parse(m.SelectElement(this.id, "nrbarattoli"));
                int BarattoliVenduti = decimal.ToInt32(this.numericUpDownNrBottiglie.Value);
                int NuovoNrBarattoli = nrbarattoli - BarattoliVenduti;

                // metodo per modificare l'elemento
                m.ModifyItem(NuovoNrBarattoli, "nrbarattoli", this.id);

                // chiudo e riarpo i il form recedente in modo da visualizzare le modifiche
                this.formmarmellata.Dispose();
                FormMarmellata frm = new FormMarmellata(this.home);
                frm.Show();
                this.Dispose();
            }
            // se l'utente non modifica il valore del numericupdown non accade nulla in quanto non ci sta nulla da modificare
        }// end modifica
    }
}
