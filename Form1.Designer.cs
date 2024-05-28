namespace Proiect_Paw_Hotel
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.listViewRezervari = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModificaRez = new System.Windows.Forms.Button();
            this.buttonVizRez = new System.Windows.Forms.Button();
            this.buttonStergeRez = new System.Windows.Forms.Button();
            this.buttonAdaugaRez = new System.Windows.Forms.Button();
            this.buttonPrinteazaFull = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervarileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervarileSelectateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRezervareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaDocumentulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaValorileSelectateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewRezervari
            // 
            this.listViewRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listViewRezervari.FullRowSelect = true;
            this.listViewRezervari.HideSelection = false;
            this.listViewRezervari.LabelEdit = true;
            this.listViewRezervari.Location = new System.Drawing.Point(62, 127);
            this.listViewRezervari.Name = "listViewRezervari";
            this.listViewRezervari.Size = new System.Drawing.Size(939, 265);
            this.listViewRezervari.TabIndex = 0;
            this.listViewRezervari.UseCompatibleStateImageBehavior = false;
            this.listViewRezervari.View = System.Windows.Forms.View.Details;
            this.listViewRezervari.SelectedIndexChanged += new System.EventHandler(this.listViewRezervari_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "cod rezervare";
            this.columnHeader12.Width = 108;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "check in";
            this.columnHeader13.Width = 95;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "check out";
            this.columnHeader14.Width = 96;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "cod camera";
            this.columnHeader15.Width = 97;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "cod client";
            this.columnHeader16.Width = 93;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "parcare inclusa";
            this.columnHeader17.Width = 125;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "pret final";
            this.columnHeader18.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervari:";
            // 
            // buttonModificaRez
            // 
            this.buttonModificaRez.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonModificaRez.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModificaRez.ForeColor = System.Drawing.Color.Black;
            this.buttonModificaRez.Location = new System.Drawing.Point(254, 423);
            this.buttonModificaRez.Name = "buttonModificaRez";
            this.buttonModificaRez.Size = new System.Drawing.Size(151, 60);
            this.buttonModificaRez.TabIndex = 2;
            this.buttonModificaRez.Text = "Modifică";
            this.buttonModificaRez.UseVisualStyleBackColor = false;
            this.buttonModificaRez.Click += new System.EventHandler(this.buttonModificaRez_Click);
            // 
            // buttonVizRez
            // 
            this.buttonVizRez.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonVizRez.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVizRez.ForeColor = System.Drawing.Color.Black;
            this.buttonVizRez.Location = new System.Drawing.Point(460, 423);
            this.buttonVizRez.Name = "buttonVizRez";
            this.buttonVizRez.Size = new System.Drawing.Size(147, 60);
            this.buttonVizRez.TabIndex = 3;
            this.buttonVizRez.Text = "Vizualizează clienții";
            this.buttonVizRez.UseVisualStyleBackColor = false;
            this.buttonVizRez.Click += new System.EventHandler(this.buttonVizRez_Click);
            // 
            // buttonStergeRez
            // 
            this.buttonStergeRez.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonStergeRez.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStergeRez.ForeColor = System.Drawing.Color.Black;
            this.buttonStergeRez.Location = new System.Drawing.Point(854, 423);
            this.buttonStergeRez.Name = "buttonStergeRez";
            this.buttonStergeRez.Size = new System.Drawing.Size(147, 60);
            this.buttonStergeRez.TabIndex = 4;
            this.buttonStergeRez.Text = "Șterge";
            this.buttonStergeRez.UseVisualStyleBackColor = false;
            this.buttonStergeRez.Click += new System.EventHandler(this.buttonStergeRez_Click);
            // 
            // buttonAdaugaRez
            // 
            this.buttonAdaugaRez.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdaugaRez.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugaRez.ForeColor = System.Drawing.Color.Black;
            this.buttonAdaugaRez.Location = new System.Drawing.Point(62, 423);
            this.buttonAdaugaRez.Name = "buttonAdaugaRez";
            this.buttonAdaugaRez.Size = new System.Drawing.Size(147, 60);
            this.buttonAdaugaRez.TabIndex = 5;
            this.buttonAdaugaRez.Text = "Adaugă";
            this.buttonAdaugaRez.UseVisualStyleBackColor = false;
            this.buttonAdaugaRez.Click += new System.EventHandler(this.buttonAdaugaRez_Click);
            // 
            // buttonPrinteazaFull
            // 
            this.buttonPrinteazaFull.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonPrinteazaFull.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrinteazaFull.ForeColor = System.Drawing.Color.Black;
            this.buttonPrinteazaFull.Location = new System.Drawing.Point(656, 423);
            this.buttonPrinteazaFull.Name = "buttonPrinteazaFull";
            this.buttonPrinteazaFull.Size = new System.Drawing.Size(147, 60);
            this.buttonPrinteazaFull.TabIndex = 6;
            this.buttonPrinteazaFull.Text = "Printează";
            this.buttonPrinteazaFull.UseVisualStyleBackColor = false;
            this.buttonPrinteazaFull.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizeazaToolStripMenuItem,
            this.actiuniToolStripMenuItem,
            this.printeazaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizeazaToolStripMenuItem
            // 
            this.vizualizeazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.camereToolStripMenuItem});
            this.vizualizeazaToolStripMenuItem.Name = "vizualizeazaToolStripMenuItem";
            this.vizualizeazaToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.vizualizeazaToolStripMenuItem.Text = "Vizualizeaza";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // camereToolStripMenuItem
            // 
            this.camereToolStripMenuItem.Name = "camereToolStripMenuItem";
            this.camereToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.camereToolStripMenuItem.Text = "Camere";
            // 
            // actiuniToolStripMenuItem
            // 
            this.actiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRezervareToolStripMenuItem,
            this.modificaRezervareToolStripMenuItem,
            this.stergeRezervareToolStripMenuItem});
            this.actiuniToolStripMenuItem.Name = "actiuniToolStripMenuItem";
            this.actiuniToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.actiuniToolStripMenuItem.Text = "Actiuni";
            // 
            // adaugaRezervareToolStripMenuItem
            // 
            this.adaugaRezervareToolStripMenuItem.Name = "adaugaRezervareToolStripMenuItem";
            this.adaugaRezervareToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.adaugaRezervareToolStripMenuItem.Text = "Adauga rezervare";
            this.adaugaRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem_Click);
            // 
            // modificaRezervareToolStripMenuItem
            // 
            this.modificaRezervareToolStripMenuItem.Name = "modificaRezervareToolStripMenuItem";
            this.modificaRezervareToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.modificaRezervareToolStripMenuItem.Text = "Modifica rezervare";
            this.modificaRezervareToolStripMenuItem.Click += new System.EventHandler(this.modificaRezervareToolStripMenuItem_Click);
            // 
            // stergeRezervareToolStripMenuItem
            // 
            this.stergeRezervareToolStripMenuItem.Name = "stergeRezervareToolStripMenuItem";
            this.stergeRezervareToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.stergeRezervareToolStripMenuItem.Text = "Sterge Rezervarile selectate";
            this.stergeRezervareToolStripMenuItem.Click += new System.EventHandler(this.stergeRezervareToolStripMenuItem_Click);
            // 
            // printeazaToolStripMenuItem
            // 
            this.printeazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervarileToolStripMenuItem,
            this.rezervarileSelectateToolStripMenuItem});
            this.printeazaToolStripMenuItem.Name = "printeazaToolStripMenuItem";
            this.printeazaToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.printeazaToolStripMenuItem.Text = "Printeaza";
            // 
            // rezervarileToolStripMenuItem
            // 
            this.rezervarileToolStripMenuItem.Name = "rezervarileToolStripMenuItem";
            this.rezervarileToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.rezervarileToolStripMenuItem.Text = "Rezervarile";
            this.rezervarileToolStripMenuItem.Click += new System.EventHandler(this.rezervarileToolStripMenuItem_Click);
            // 
            // rezervarileSelectateToolStripMenuItem
            // 
            this.rezervarileSelectateToolStripMenuItem.Name = "rezervarileSelectateToolStripMenuItem";
            this.rezervarileSelectateToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.rezervarileSelectateToolStripMenuItem.Text = "Rezervarile selectate";
            this.rezervarileSelectateToolStripMenuItem.Click += new System.EventHandler(this.rezervarileSelectateToolStripMenuItem_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.adaugaRezervareToolStripMenuItem1,
            this.printeazaDocumentulToolStripMenuItem,
            this.printeazaValorileSelectateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(259, 124);
            this.contextMenuStrip1.Text = "Modifica Rezervarea";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 24);
            this.toolStripMenuItem1.Text = "Modifica Rezervarea";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 24);
            this.toolStripMenuItem2.Text = "Sterge Rezervarea";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // adaugaRezervareToolStripMenuItem1
            // 
            this.adaugaRezervareToolStripMenuItem1.Name = "adaugaRezervareToolStripMenuItem1";
            this.adaugaRezervareToolStripMenuItem1.Size = new System.Drawing.Size(258, 24);
            this.adaugaRezervareToolStripMenuItem1.Text = "Adauga Rezervare";
            this.adaugaRezervareToolStripMenuItem1.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem1_Click);
            // 
            // printeazaDocumentulToolStripMenuItem
            // 
            this.printeazaDocumentulToolStripMenuItem.Name = "printeazaDocumentulToolStripMenuItem";
            this.printeazaDocumentulToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.printeazaDocumentulToolStripMenuItem.Text = "Printeaza Documentul";
            this.printeazaDocumentulToolStripMenuItem.Click += new System.EventHandler(this.printeazaDocumentulToolStripMenuItem_Click);
            // 
            // printeazaValorileSelectateToolStripMenuItem
            // 
            this.printeazaValorileSelectateToolStripMenuItem.Name = "printeazaValorileSelectateToolStripMenuItem";
            this.printeazaValorileSelectateToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.printeazaValorileSelectateToolStripMenuItem.Text = "Printeaza Valorile Selectate";
            this.printeazaValorileSelectateToolStripMenuItem.Click += new System.EventHandler(this.printeazaValorileSelectateToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 592);
            this.Controls.Add(this.buttonPrinteazaFull);
            this.Controls.Add(this.buttonAdaugaRez);
            this.Controls.Add(this.buttonStergeRez);
            this.Controls.Add(this.buttonVizRez);
            this.Controls.Add(this.buttonModificaRez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewRezervari);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home - Rezervari";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRezervari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModificaRez;
        private System.Windows.Forms.Button buttonVizRez;
        private System.Windows.Forms.Button buttonStergeRez;
        private System.Windows.Forms.Button buttonAdaugaRez;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button buttonPrinteazaFull;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervarileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervarileSelectateToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printeazaDocumentulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazaValorileSelectateToolStripMenuItem;
    }
}

