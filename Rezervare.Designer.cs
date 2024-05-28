namespace Proiect_Paw_Hotel
{
    partial class Rezervare
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Superior");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Deluxe");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Single", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Superior");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Deluxe");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Double", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Superior");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Deluxe");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Triple", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Superior");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Deluxe");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Quad", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewCamere = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodCamera = new System.Windows.Forms.TextBox();
            this.clientNou = new System.Windows.Forms.Button();
            this.clientExistent = new System.Windows.Forms.Button();
            this.checkBoxParcare = new System.Windows.Forms.CheckBox();
            this.textBoxCodClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPretFinal = new System.Windows.Forms.TextBox();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.buttonAnuleaza = new System.Windows.Forms.Button();
            this.buttonReseteaza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTaxaParcare = new System.Windows.Forms.Label();
            this.buttonVeziCamere = new System.Windows.Forms.Button();
            this.buttonCalculFinal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshCamereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(190, 44);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckIn.TabIndex = 5;
            this.dateTimePickerCheckIn.ValueChanged += new System.EventHandler(this.dateTimePickerCheckIn_ValueChanged);
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(190, 89);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckOut.TabIndex = 6;
            this.dateTimePickerCheckOut.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check Out";
            // 
            // treeViewCamere
            // 
            this.treeViewCamere.Location = new System.Drawing.Point(56, 177);
            this.treeViewCamere.Name = "treeViewCamere";
            treeNode1.Name = "SStandardNode";
            treeNode1.Text = "Standard";
            treeNode2.Name = "SSuperiorNode";
            treeNode2.Text = "Superior";
            treeNode3.Name = "SDeluxeNode";
            treeNode3.Text = "Deluxe";
            treeNode4.Name = "SingleNode";
            treeNode4.Text = "Single";
            treeNode5.Name = "DStandardNode";
            treeNode5.Text = "Standard";
            treeNode6.Name = "DSuperiorNode";
            treeNode6.Text = "Superior";
            treeNode7.Name = "DDeluxeNode";
            treeNode7.Text = "Deluxe";
            treeNode8.Name = "DoubleNode";
            treeNode8.Text = "Double";
            treeNode9.Name = "TStandardNode";
            treeNode9.Text = "Standard";
            treeNode10.Name = "TSuperiorNode";
            treeNode10.Text = "Superior";
            treeNode11.Name = "TDeluxeNode";
            treeNode11.Text = "Deluxe";
            treeNode12.Name = "TripleNode";
            treeNode12.Text = "Triple";
            treeNode13.Name = "QStandardNode";
            treeNode13.Text = "Standard";
            treeNode14.Name = "QSuperiorNode";
            treeNode14.Text = "Superior";
            treeNode15.Name = "QDeluxeNode";
            treeNode15.Text = "Deluxe";
            treeNode16.Name = "QuadNode";
            treeNode16.Text = "Quad";
            this.treeViewCamere.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16});
            this.treeViewCamere.Size = new System.Drawing.Size(532, 114);
            this.treeViewCamere.TabIndex = 9;
            this.treeViewCamere.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCamere_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alege dintre camerele disponibile:";
            // 
            // textBoxCodCamera
            // 
            this.textBoxCodCamera.Location = new System.Drawing.Point(193, 312);
            this.textBoxCodCamera.Name = "textBoxCodCamera";
            this.textBoxCodCamera.ReadOnly = true;
            this.textBoxCodCamera.Size = new System.Drawing.Size(66, 22);
            this.textBoxCodCamera.TabIndex = 11;
            // 
            // clientNou
            // 
            this.clientNou.BackColor = System.Drawing.Color.OrangeRed;
            this.clientNou.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientNou.ForeColor = System.Drawing.Color.Gold;
            this.clientNou.Location = new System.Drawing.Point(320, 350);
            this.clientNou.Name = "clientNou";
            this.clientNou.Size = new System.Drawing.Size(146, 63);
            this.clientNou.TabIndex = 12;
            this.clientNou.Text = "Client Nou";
            this.clientNou.UseVisualStyleBackColor = false;
            this.clientNou.Click += new System.EventHandler(this.clientNou_Click);
            // 
            // clientExistent
            // 
            this.clientExistent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clientExistent.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientExistent.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clientExistent.Location = new System.Drawing.Point(497, 350);
            this.clientExistent.Name = "clientExistent";
            this.clientExistent.Size = new System.Drawing.Size(172, 63);
            this.clientExistent.TabIndex = 13;
            this.clientExistent.Text = "Client Existent";
            this.clientExistent.UseVisualStyleBackColor = false;
            this.clientExistent.Click += new System.EventHandler(this.clientExistent_Click);
            // 
            // checkBoxParcare
            // 
            this.checkBoxParcare.AutoSize = true;
            this.checkBoxParcare.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxParcare.Location = new System.Drawing.Point(54, 433);
            this.checkBoxParcare.Name = "checkBoxParcare";
            this.checkBoxParcare.Size = new System.Drawing.Size(152, 24);
            this.checkBoxParcare.TabIndex = 14;
            this.checkBoxParcare.Text = "parcare inclusa";
            this.checkBoxParcare.UseVisualStyleBackColor = true;
            this.checkBoxParcare.CheckedChanged += new System.EventHandler(this.checkBoxParcare_CheckedChanged);
            // 
            // textBoxCodClient
            // 
            this.textBoxCodClient.Location = new System.Drawing.Point(166, 371);
            this.textBoxCodClient.Name = "textBoxCodClient";
            this.textBoxCodClient.ReadOnly = true;
            this.textBoxCodClient.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodClient.TabIndex = 15;
            this.textBoxCodClient.TextChanged += new System.EventHandler(this.textBoxCodClient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cod Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "pret final:";
            // 
            // textBoxPretFinal
            // 
            this.textBoxPretFinal.Location = new System.Drawing.Point(150, 504);
            this.textBoxPretFinal.Name = "textBoxPretFinal";
            this.textBoxPretFinal.ReadOnly = true;
            this.textBoxPretFinal.Size = new System.Drawing.Size(100, 22);
            this.textBoxPretFinal.TabIndex = 18;
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalveaza.Location = new System.Drawing.Point(49, 571);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(108, 50);
            this.buttonSalveaza.TabIndex = 19;
            this.buttonSalveaza.Text = "Salvează";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // buttonAnuleaza
            // 
            this.buttonAnuleaza.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnuleaza.Location = new System.Drawing.Point(404, 571);
            this.buttonAnuleaza.Name = "buttonAnuleaza";
            this.buttonAnuleaza.Size = new System.Drawing.Size(108, 50);
            this.buttonAnuleaza.TabIndex = 20;
            this.buttonAnuleaza.Text = "Anulează";
            this.buttonAnuleaza.UseVisualStyleBackColor = true;
            this.buttonAnuleaza.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonReseteaza
            // 
            this.buttonReseteaza.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReseteaza.Location = new System.Drawing.Point(555, 571);
            this.buttonReseteaza.Name = "buttonReseteaza";
            this.buttonReseteaza.Size = new System.Drawing.Size(108, 50);
            this.buttonReseteaza.TabIndex = 21;
            this.buttonReseteaza.Text = "Resetează";
            this.buttonReseteaza.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Codul camerei ";
            // 
            // labelTaxaParcare
            // 
            this.labelTaxaParcare.AutoSize = true;
            this.labelTaxaParcare.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTaxaParcare.ForeColor = System.Drawing.Color.Red;
            this.labelTaxaParcare.Location = new System.Drawing.Point(212, 434);
            this.labelTaxaParcare.Name = "labelTaxaParcare";
            this.labelTaxaParcare.Size = new System.Drawing.Size(456, 23);
            this.labelTaxaParcare.TabIndex = 23;
            this.labelTaxaParcare.Text = "Veti plati o taxa suplimentara de 50 de lei pe noapte";
            this.labelTaxaParcare.Visible = false;
            // 
            // buttonVeziCamere
            // 
            this.buttonVeziCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVeziCamere.Location = new System.Drawing.Point(431, 40);
            this.buttonVeziCamere.Name = "buttonVeziCamere";
            this.buttonVeziCamere.Size = new System.Drawing.Size(113, 71);
            this.buttonVeziCamere.TabIndex = 24;
            this.buttonVeziCamere.Text = "Vezi camere";
            this.buttonVeziCamere.UseVisualStyleBackColor = true;
            this.buttonVeziCamere.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCalculFinal
            // 
            this.buttonCalculFinal.Location = new System.Drawing.Point(285, 492);
            this.buttonCalculFinal.Name = "buttonCalculFinal";
            this.buttonCalculFinal.Size = new System.Drawing.Size(105, 47);
            this.buttonCalculFinal.TabIndex = 25;
            this.buttonCalculFinal.Text = "Calculeaza pretul final";
            this.buttonCalculFinal.UseVisualStyleBackColor = true;
            this.buttonCalculFinal.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshCamereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 28);
            // 
            // refreshCamereToolStripMenuItem
            // 
            this.refreshCamereToolStripMenuItem.Name = "refreshCamereToolStripMenuItem";
            this.refreshCamereToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.refreshCamereToolStripMenuItem.Text = "Refresh Camere";
            this.refreshCamereToolStripMenuItem.Click += new System.EventHandler(this.refreshCamereToolStripMenuItem_Click);
            // 
            // Rezervare
            // 
            this.AcceptButton = this.buttonSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(788, 680);
            this.Controls.Add(this.buttonCalculFinal);
            this.Controls.Add(this.buttonVeziCamere);
            this.Controls.Add(this.labelTaxaParcare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReseteaza);
            this.Controls.Add(this.buttonAnuleaza);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.textBoxPretFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCodClient);
            this.Controls.Add(this.checkBoxParcare);
            this.Controls.Add(this.clientExistent);
            this.Controls.Add(this.clientNou);
            this.Controls.Add(this.textBoxCodCamera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeViewCamere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Rezervare";
            this.Text = "Rezervare";
            this.Load += new System.EventHandler(this.Rezervare_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewCamere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodCamera;
        private System.Windows.Forms.Button clientNou;
        private System.Windows.Forms.Button clientExistent;
        private System.Windows.Forms.CheckBox checkBoxParcare;
        private System.Windows.Forms.TextBox textBoxCodClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPretFinal;
        private System.Windows.Forms.Button buttonSalveaza;
        private System.Windows.Forms.Button buttonAnuleaza;
        private System.Windows.Forms.Button buttonReseteaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTaxaParcare;
        private System.Windows.Forms.Button buttonVeziCamere;
        private System.Windows.Forms.Button buttonCalculFinal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshCamereToolStripMenuItem;
    }
}