
namespace Progetto_Esame_PMO.Grafica
{
    partial class FormVino
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewDettagli = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVigneto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrBottiglie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonAggiungi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonAggiungi
            // 
            this.ButtonAggiungi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAggiungi.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAggiungi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAggiungi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonAggiungi.Location = new System.Drawing.Point(147, 13);
            this.ButtonAggiungi.Name = "ButtonAggiungi";
            this.ButtonAggiungi.Size = new System.Drawing.Size(145, 33);
            this.ButtonAggiungi.TabIndex = 4;
            this.ButtonAggiungi.Text = "Aggiugni Vino";
            this.ButtonAggiungi.UseVisualStyleBackColor = false;
            this.ButtonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.listViewDettagli, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 335);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listViewDettagli
            // 
            this.listViewDettagli.AllowColumnReorder = true;
            this.listViewDettagli.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewDettagli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderAnno,
            this.columnHeaderTipologia,
            this.columnHeaderVigneto,
            this.columnHeaderNrBottiglie});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewDettagli, 4);
            this.listViewDettagli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDettagli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDettagli.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDettagli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDettagli.HideSelection = false;
            this.listViewDettagli.Location = new System.Drawing.Point(3, 3);
            this.listViewDettagli.Name = "listViewDettagli";
            this.listViewDettagli.Size = new System.Drawing.Size(868, 329);
            this.listViewDettagli.TabIndex = 0;
            this.listViewDettagli.UseCompatibleStateImageBehavior = false;
            this.listViewDettagli.View = System.Windows.Forms.View.Details;
            this.listViewDettagli.DoubleClick += new System.EventHandler(this.listViewDettagli_DoubleClick);
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome Vino";
            this.columnHeaderNome.Width = 162;
            // 
            // columnHeaderAnno
            // 
            this.columnHeaderAnno.Text = "Anno";
            this.columnHeaderAnno.Width = 154;
            // 
            // columnHeaderTipologia
            // 
            this.columnHeaderTipologia.Text = "Tipologia";
            this.columnHeaderTipologia.Width = 154;
            // 
            // columnHeaderVigneto
            // 
            this.columnHeaderVigneto.Text = "Vigneto";
            this.columnHeaderVigneto.Width = 163;
            // 
            // columnHeaderNrBottiglie
            // 
            this.columnHeaderNrBottiglie.Text = "Nr Bottiglie";
            this.columnHeaderNrBottiglie.Width = 154;
            // 
            // FormVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(880, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormVino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGest - Vino";
            this.Load += new System.EventHandler(this.FormVino_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonAggiungi;
        private System.Windows.Forms.ListView listViewDettagli;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderAnno;
        private System.Windows.Forms.ColumnHeader columnHeaderTipologia;
        private System.Windows.Forms.ColumnHeader columnHeaderVigneto;
        private System.Windows.Forms.ColumnHeader columnHeaderNrBottiglie;
    }
}