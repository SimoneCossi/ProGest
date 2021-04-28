
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VisualizzaTabella = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonApri = new System.Windows.Forms.Button();
            this.tableLayoutPanelBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.ColumnCount = 2;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelBase.Controls.Add(this.ButtonApri, 1, 0);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 2;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(784, 411);
            this.tableLayoutPanelBase.TabIndex = 0;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 76);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // VisualizzaTabella
            // 
            this.VisualizzaTabella.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisualizzaTabella.BackColor = System.Drawing.SystemColors.Control;
            this.VisualizzaTabella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualizzaTabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizzaTabella.ForeColor = System.Drawing.SystemColors.InfoText;
            this.VisualizzaTabella.FormattingEnabled = true;
            this.VisualizzaTabella.Location = new System.Drawing.Point(219, 23);
            this.VisualizzaTabella.Name = "VisualizzaTabella";
            this.VisualizzaTabella.Size = new System.Drawing.Size(140, 28);
            this.VisualizzaTabella.TabIndex = 1;
            this.VisualizzaTabella.SelectedIndexChanged += new System.EventHandler(this.VisualizzaTabella_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Scegliere la tabella";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonApri
            // 
            this.ButtonApri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApri.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonApri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonApri.Location = new System.Drawing.Point(522, 25);
            this.ButtonApri.Name = "ButtonApri";
            this.ButtonApri.Size = new System.Drawing.Size(132, 32);
            this.ButtonApri.TabIndex = 3;
            this.ButtonApri.Text = "Apri Tabella";
            this.ButtonApri.UseVisualStyleBackColor = false;
            this.ButtonApri.Click += new System.EventHandler(this.ButtonApri_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tableLayoutPanelBase);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest";
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private System.Windows.Forms.ComboBox VisualizzaTabella;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonApri;
    }
}

