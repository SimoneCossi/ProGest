
namespace Progetto_Esame_PMO
{
    partial class FormHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonApri = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VisualizzaTabella = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewPriorita = new System.Windows.Forms.ListView();
            this.NomeProdotto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.ColumnCount = 2;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelBase.Controls.Add(this.ButtonApri, 1, 0);
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelBase.Controls.Add(this.listViewPriorita, 0, 1);
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 2;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(687, 419);
            this.tableLayoutPanelBase.TabIndex = 0;
            // 
            // ButtonApri
            // 
            this.ButtonApri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApri.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonApri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonApri.Location = new System.Drawing.Point(483, 36);
            this.ButtonApri.Name = "ButtonApri";
            this.ButtonApri.Size = new System.Drawing.Size(132, 32);
            this.ButtonApri.TabIndex = 7;
            this.ButtonApri.Text = "Apri Tabella";
            this.ButtonApri.UseVisualStyleBackColor = false;
            this.ButtonApri.Click += new System.EventHandler(this.ButtonApri_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.VisualizzaTabella, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 98);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // VisualizzaTabella
            // 
            this.VisualizzaTabella.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisualizzaTabella.BackColor = System.Drawing.SystemColors.Control;
            this.VisualizzaTabella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualizzaTabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizzaTabella.ForeColor = System.Drawing.SystemColors.InfoText;
            this.VisualizzaTabella.FormattingEnabled = true;
            this.VisualizzaTabella.Location = new System.Drawing.Point(234, 34);
            this.VisualizzaTabella.Name = "VisualizzaTabella";
            this.VisualizzaTabella.Size = new System.Drawing.Size(140, 28);
            this.VisualizzaTabella.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(26, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Scegliere la tabella";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewPriorita
            // 
            this.listViewPriorita.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewPriorita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeProdotto,
            this.Quantita});
            this.listViewPriorita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPriorita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPriorita.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewPriorita.HideSelection = false;
            this.listViewPriorita.Location = new System.Drawing.Point(3, 107);
            this.listViewPriorita.Name = "listViewPriorita";
            this.listViewPriorita.Size = new System.Drawing.Size(406, 309);
            this.listViewPriorita.TabIndex = 8;
            this.listViewPriorita.UseCompatibleStateImageBehavior = false;
            this.listViewPriorita.View = System.Windows.Forms.View.Details;
            // 
            // NomeProdotto
            // 
            this.NomeProdotto.Text = "Nome Prodotto";
            this.NomeProdotto.Width = 176;
            // 
            // Quantita
            // 
            this.Quantita.Text = "Quantità";
            this.Quantita.Width = 149;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(415, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 309);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(3, 50);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 54);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Lista dei Prodotti con priorità di vendita";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(3, 157);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 149);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "\r\nVerranno visualizzati in ordine:\r\n5 vini\r\n3 vigneti\r\n3 marmellate\r\n\r\nquesto poi" +
    "chè si da la priorità di vendita ai vini, poi ai vigneti e infine alle marmellat" +
    "e";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(687, 419);
            this.Controls.Add(this.tableLayoutPanelBase);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest";
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox VisualizzaTabella;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonApri;
        private System.Windows.Forms.ListView listViewPriorita;
        private System.Windows.Forms.ColumnHeader NomeProdotto;
        private System.Windows.Forms.ColumnHeader Quantita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

