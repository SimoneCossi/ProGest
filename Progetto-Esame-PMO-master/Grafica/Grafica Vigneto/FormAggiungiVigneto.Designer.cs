
namespace Progetto_Esame_PMO.Grafica.Grafica_Vigneto
{
    partial class FormAggiungiVigneto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAggiungi = new System.Windows.Forms.Button();
            this.numericUpDownNrVitiMorte = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrVitiMorte)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonAggiungi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownNrVitiMorte, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonAggiungi
            // 
            this.ButtonAggiungi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAggiungi.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAggiungi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonAggiungi.Location = new System.Drawing.Point(522, 65);
            this.ButtonAggiungi.Name = "ButtonAggiungi";
            this.ButtonAggiungi.Size = new System.Drawing.Size(116, 37);
            this.ButtonAggiungi.TabIndex = 22;
            this.ButtonAggiungi.Text = "Aggiungi";
            this.ButtonAggiungi.UseVisualStyleBackColor = false;
            this.ButtonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);
            // 
            // numericUpDownNrVitiMorte
            // 
            this.numericUpDownNrVitiMorte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownNrVitiMorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNrVitiMorte.Location = new System.Drawing.Point(288, 108);
            this.numericUpDownNrVitiMorte.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNrVitiMorte.Name = "numericUpDownNrVitiMorte";
            this.numericUpDownNrVitiMorte.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownNrVitiMorte.TabIndex = 21;
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Location = new System.Drawing.Point(51, 108);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(130, 28);
            this.comboBoxNome.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Nome del Vigneto";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(235, 36);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 32);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Nr Viti Morte";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAggiungiVigneto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(696, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "FormAggiungiVigneto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest - Vigneto - Aggiungi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrVitiMorte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBoxNome;
        private System.Windows.Forms.NumericUpDown numericUpDownNrVitiMorte;
        private System.Windows.Forms.Button ButtonAggiungi;
    }
}