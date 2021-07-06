
namespace Progetto_Esame_PMO.Grafica.Grafica_Vigneto
{
    partial class FormVigneto
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.listViewDettagli = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrVitiMorte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewDettagli, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAggiungi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAggiungi.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAggiungi.Location = new System.Drawing.Point(23, 20);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(180, 34);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiugngi Vigneto";
            this.buttonAggiungi.UseVisualStyleBackColor = false;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // listViewDettagli
            // 
            this.listViewDettagli.AllowColumnReorder = true;
            this.listViewDettagli.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewDettagli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderNrVitiMorte});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewDettagli, 2);
            this.listViewDettagli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDettagli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDettagli.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDettagli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDettagli.HideSelection = false;
            this.listViewDettagli.Location = new System.Drawing.Point(3, 77);
            this.listViewDettagli.Name = "listViewDettagli";
            this.listViewDettagli.Size = new System.Drawing.Size(447, 419);
            this.listViewDettagli.TabIndex = 1;
            this.listViewDettagli.UseCompatibleStateImageBehavior = false;
            this.listViewDettagli.View = System.Windows.Forms.View.Details;
            this.listViewDettagli.DoubleClick += new System.EventHandler(this.listViewDettagli_DoubleClick);
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome Vigneto";
            this.columnHeaderNome.Width = 222;
            // 
            // columnHeaderNrVitiMorte
            // 
            this.columnHeaderNrVitiMorte.Text = "Nr Viti Morte";
            this.columnHeaderNrVitiMorte.Width = 214;
            // 
            // FormVigneto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(453, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "FormVigneto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest - Vigneto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.ListView listViewDettagli;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderNrVitiMorte;
    }
}