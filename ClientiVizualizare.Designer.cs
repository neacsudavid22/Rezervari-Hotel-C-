namespace Proiect_Paw_Hotel
{
    partial class ClientiVizualizare
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
            this.components = new System.ComponentModel.Container();
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printeaza = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrarileSelectateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeClientiSelectatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdaugaClient = new System.Windows.Forms.Button();
            this.buttonModificaClient = new System.Windows.Forms.Button();
            this.buttonStergeClient = new System.Windows.Forms.Button();
            this.buttonAnuleaza = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClienti
            // 
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(75, 62);
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.Size = new System.Drawing.Size(739, 223);
            this.listViewClienti.TabIndex = 16;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            this.listViewClienti.SelectedIndexChanged += new System.EventHandler(this.listViewClienti_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod client";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenume";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data nasterii";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nr. telefon";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 73;
            // 
            // printeaza
            // 
            this.printeaza.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printeaza.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printeaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printeaza.Location = new System.Drawing.Point(75, 318);
            this.printeaza.Name = "printeaza";
            this.printeaza.Size = new System.Drawing.Size(161, 80);
            this.printeaza.TabIndex = 17;
            this.printeaza.Text = "Printează Documentul";
            this.printeaza.UseVisualStyleBackColor = false;
            this.printeaza.Click += new System.EventHandler(this.clientExistent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printeazaToolStripMenuItem,
            this.actiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printeazaToolStripMenuItem
            // 
            this.printeazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentulToolStripMenuItem,
            this.inregistrarileSelectateToolStripMenuItem});
            this.printeazaToolStripMenuItem.Name = "printeazaToolStripMenuItem";
            this.printeazaToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.printeazaToolStripMenuItem.Text = "Printează";
            // 
            // documentulToolStripMenuItem
            // 
            this.documentulToolStripMenuItem.Name = "documentulToolStripMenuItem";
            this.documentulToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.documentulToolStripMenuItem.Text = "Documentul";
            this.documentulToolStripMenuItem.Click += new System.EventHandler(this.documentulToolStripMenuItem_Click);
            // 
            // inregistrarileSelectateToolStripMenuItem
            // 
            this.inregistrarileSelectateToolStripMenuItem.Name = "inregistrarileSelectateToolStripMenuItem";
            this.inregistrarileSelectateToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.inregistrarileSelectateToolStripMenuItem.Text = "Înregistrările selectate";
            this.inregistrarileSelectateToolStripMenuItem.Click += new System.EventHandler(this.inregistrarileSelectateToolStripMenuItem_Click);
            // 
            // actiuniToolStripMenuItem
            // 
            this.actiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem,
            this.modificaClientToolStripMenuItem,
            this.stergeClientiSelectatiToolStripMenuItem});
            this.actiuniToolStripMenuItem.Name = "actiuniToolStripMenuItem";
            this.actiuniToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.actiuniToolStripMenuItem.Text = "Acțiuni";
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.adaugaClientToolStripMenuItem.Text = "Adaugă client";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // modificaClientToolStripMenuItem
            // 
            this.modificaClientToolStripMenuItem.Name = "modificaClientToolStripMenuItem";
            this.modificaClientToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.modificaClientToolStripMenuItem.Text = "Modifică client";
            this.modificaClientToolStripMenuItem.Click += new System.EventHandler(this.modificaClientToolStripMenuItem_Click);
            // 
            // stergeClientiSelectatiToolStripMenuItem
            // 
            this.stergeClientiSelectatiToolStripMenuItem.Name = "stergeClientiSelectatiToolStripMenuItem";
            this.stergeClientiSelectatiToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.stergeClientiSelectatiToolStripMenuItem.Text = "Sterge Clienti selectati";
            this.stergeClientiSelectatiToolStripMenuItem.Click += new System.EventHandler(this.stergeClientiSelectatiToolStripMenuItem_Click);
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdaugaClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugaClient.ForeColor = System.Drawing.Color.Black;
            this.buttonAdaugaClient.Location = new System.Drawing.Point(279, 318);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.Size = new System.Drawing.Size(147, 80);
            this.buttonAdaugaClient.TabIndex = 20;
            this.buttonAdaugaClient.Text = "Adaugă";
            this.buttonAdaugaClient.UseVisualStyleBackColor = false;
            this.buttonAdaugaClient.Click += new System.EventHandler(this.buttonAdaugaRez_Click);
            // 
            // buttonModificaClient
            // 
            this.buttonModificaClient.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonModificaClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModificaClient.ForeColor = System.Drawing.Color.Black;
            this.buttonModificaClient.Location = new System.Drawing.Point(471, 318);
            this.buttonModificaClient.Name = "buttonModificaClient";
            this.buttonModificaClient.Size = new System.Drawing.Size(151, 80);
            this.buttonModificaClient.TabIndex = 19;
            this.buttonModificaClient.Text = "Modifică";
            this.buttonModificaClient.UseVisualStyleBackColor = false;
            this.buttonModificaClient.Click += new System.EventHandler(this.buttonModificaRez_Click);
            // 
            // buttonStergeClient
            // 
            this.buttonStergeClient.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonStergeClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStergeClient.ForeColor = System.Drawing.Color.Black;
            this.buttonStergeClient.Location = new System.Drawing.Point(667, 318);
            this.buttonStergeClient.Name = "buttonStergeClient";
            this.buttonStergeClient.Size = new System.Drawing.Size(147, 80);
            this.buttonStergeClient.TabIndex = 21;
            this.buttonStergeClient.Text = "Șterge";
            this.buttonStergeClient.UseVisualStyleBackColor = false;
            this.buttonStergeClient.Click += new System.EventHandler(this.buttonStergeRez_Click);
            // 
            // buttonAnuleaza
            // 
            this.buttonAnuleaza.BackColor = System.Drawing.Color.Red;
            this.buttonAnuleaza.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnuleaza.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAnuleaza.Location = new System.Drawing.Point(667, 438);
            this.buttonAnuleaza.Name = "buttonAnuleaza";
            this.buttonAnuleaza.Size = new System.Drawing.Size(147, 47);
            this.buttonAnuleaza.TabIndex = 22;
            this.buttonAnuleaza.Text = "Anulează";
            this.buttonAnuleaza.UseVisualStyleBackColor = false;
            this.buttonAnuleaza.Click += new System.EventHandler(this.buttonAnuleaza_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 76);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // ClientiVizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.buttonAnuleaza);
            this.Controls.Add(this.buttonStergeClient);
            this.Controls.Add(this.buttonAdaugaClient);
            this.Controls.Add(this.buttonModificaClient);
            this.Controls.Add(this.printeaza);
            this.Controls.Add(this.listViewClienti);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientiVizualizare";
            this.Text = "ClientiVizualizare";
            this.Load += new System.EventHandler(this.ClientiVizualizare_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button printeaza;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrarileSelectateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeClientiSelectatiToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdaugaClient;
        private System.Windows.Forms.Button buttonModificaClient;
        private System.Windows.Forms.Button buttonStergeClient;
        private System.Windows.Forms.Button buttonAnuleaza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}