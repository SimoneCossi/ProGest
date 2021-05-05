
namespace Progetto_Esame_PMO.Grafica.Grafica_Marmellata
{
    partial class FormMarmellata
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
            this.listViewDettagli = new System.Windows.Forms.ListView();
            this.columnHeaderFrutto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDimensione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrBarattoli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonAggiungi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDettagli
            // 
            this.listViewDettagli.AllowColumnReorder = true;
            this.listViewDettagli.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewDettagli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFrutto,
            this.columnHeaderAnno,
            this.columnHeaderDimensione,
            this.columnHeaderNrBarattoli});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewDettagli, 2);
            this.listViewDettagli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDettagli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDettagli.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDettagli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDettagli.HideSelection = false;
            this.listViewDettagli.Location = new System.Drawing.Point(3, 70);
            this.listViewDettagli.Name = "listViewDettagli";
            this.listViewDettagli.Size = new System.Drawing.Size(794, 377);
            this.listViewDettagli.TabIndex = 5;
            this.listViewDettagli.UseCompatibleStateImageBehavior = false;
            this.listViewDettagli.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFrutto
            // 
            this.columnHeaderFrutto.Text = "Frutto";
            this.columnHeaderFrutto.Width = 127;
            // 
            // columnHeaderAnno
            // 
            this.columnHeaderAnno.Text = "Anno";
            this.columnHeaderAnno.Width = 104;
            // 
            // columnHeaderDimensione
            // 
            this.columnHeaderDimensione.Text = "Dimensione Barattolo (g)";
            this.columnHeaderDimensione.Width = 244;
            // 
            // columnHeaderNrBarattoli
            // 
            this.columnHeaderNrBarattoli.Text = "Nr Barattoli";
            this.columnHeaderNrBarattoli.Width = 208;
            // 
            // ButtonAggiungi
            // 
            this.ButtonAggiungi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAggiungi.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAggiungi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAggiungi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonAggiungi.Location = new System.Drawing.Point(100, 17);
            this.ButtonAggiungi.Name = "ButtonAggiungi";
            this.ButtonAggiungi.Size = new System.Drawing.Size(199, 33);
            this.ButtonAggiungi.TabIndex = 4;
            this.ButtonAggiungi.Text = "Aggiungi Marmellata";
            this.ButtonAggiungi.UseVisualStyleBackColor = false;
            this.ButtonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewDettagli, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAggiungi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FormMarmellata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormMarmellata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest - Marmellata";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDettagli;
        private System.Windows.Forms.ColumnHeader columnHeaderFrutto;
        private System.Windows.Forms.ColumnHeader columnHeaderAnno;
        private System.Windows.Forms.ColumnHeader columnHeaderDimensione;
        private System.Windows.Forms.ColumnHeader columnHeaderNrBarattoli;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonAggiungi;
    }
}