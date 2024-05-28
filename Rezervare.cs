using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_Paw_Hotel
{
    public partial class Rezervare : Form
    {
        private Clienti client;
        private Camere camera;
        private Rezervari rezervare;
        private List<Rezervari> listaRezervari;
        private List<Camere> listaCamere;
        private List<Clienti> listaClienti;
        public Rezervare(List<Rezervari> listaRezervariRef, List<Camere> listaCamereRef, List<Clienti> listaClientiRef, Rezervari r_modf)
        {
            InitializeComponent();
            listaRezervari = listaRezervariRef;
            listaCamere = listaCamereRef;
            listaClienti = listaClientiRef;
            if(r_modf != null)
            {
                rezervare = r_modf;
                textBoxCodClient.Text = rezervare.Client.CodClient.ToString();
                checkBoxParcare.Checked = rezervare.ParcareInclusa;
                dateTimePickerCheckIn.Value = rezervare.CheckIn;
                dateTimePickerCheckOut.Value = rezervare.CheckOut;
                textBoxCodCamera.Text = rezervare.Camera.Cod.ToString();
            }

            PopulateTreeView(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);

            KeyDown += new KeyEventHandler(Rezervare_KeyDown);
            KeyPreview = true;

            treeViewCamere.ItemDrag += new ItemDragEventHandler(treeViewCamere_ItemDrag);

            textBoxCodCamera.AllowDrop = true;
            textBoxCodCamera.DragEnter += new DragEventHandler(textBoxCodCamera_DragEnter);
            textBoxCodCamera.DragDrop += new DragEventHandler(textBoxCodCamera_DragDrop);

            treeViewCamere.ContextMenuStrip = contextMenuStrip1;

            Clienti.cod = listaClienti.Max(client => client.CodClient);
            Rezervari.currentValue = listaRezervari.Max(rezervare => rezervare.CodRezervare);
        }

        private void treeViewCamere_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode node = (TreeNode)e.Item;
            if (node.Nodes.Count == 0)
            {
                DoDragDrop(node, DragDropEffects.Move);
            }
        }

        private void textBoxCodCamera_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxCodCamera_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if(node.Level == 2)
                    textBoxCodCamera.Text = node.Tag.ToString();
            }
        }
    private void Rezervare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                buttonCalculFinal.PerformClick();
            }
            else if (e.KeyCode == Keys.R)
            {
                buttonReseteaza.PerformClick();
            }
            else if (e.KeyCode == Keys.V)
            {
                buttonVeziCamere.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                buttonSalveaza.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        private void dateTimePickerCheckIn_ValueChanged(object sender, EventArgs e)
        {
            textBoxCodCamera.Text = "";
            PopulateTreeView(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
        }
        private void dateTimePickerCheckOut_ValueChanged(object sender, EventArgs e)
        {
            textBoxCodCamera.Text = "";
            PopulateTreeView(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
        }

        private void PopulateTreeView(DateTime checkIn, DateTime checkOut)
        {
            List<Camere> camereDisponibile = GetCamereDisponibile(checkIn, checkOut);
            PopulateTreeViewWithRooms(camereDisponibile);
        }
        private void PopulateTreeViewWithRooms(List<Camere> camere)
        {
            
            foreach (TreeNode capacitateNode in treeViewCamere.Nodes)
            {
                foreach (TreeNode tipNode in capacitateNode.Nodes)
                {
                    tipNode.Nodes.Clear();
                    foreach (Camere camera in camere)
                    {
                        if (camera.CapCam.ToString().Equals(capacitateNode.Text) && camera.TipCam.ToString().Equals(tipNode.Text))
                        {
                            TreeNode cameraNode = new TreeNode();
                            cameraNode.Text = "cod camera: " + camera.Cod + ", pret: " + camera.pretPeNoapte() + " lei pe noapte";
                            cameraNode.Tag = camera.Cod;
                            tipNode.Nodes.Add(cameraNode);
                        }
                    }
                }
            }
        }

        private List<Camere> GetCamereDisponibile(DateTime checkIn, DateTime checkOut)
        {
            List<Camere> camereDisponibile = new List<Camere>();

            foreach (Camere camera in listaCamere)
            {
                if (!CameraEsteRezervataInInterval(camera, checkIn, checkOut))
                {
                    camereDisponibile.Add(camera);
                }
            }

            return camereDisponibile;
        }

        private bool CameraEsteRezervataInInterval(Camere camera, DateTime checkIn, DateTime checkOut)
        {
            foreach (Rezervari rezervare in listaRezervari)
            {
                if (rezervare.Camera.Cod == camera.Cod && 
                    ( rezervare.CheckIn > checkOut || rezervare.CheckOut > checkIn)
                   )
                   { return true; }
            }
            return false; 
        }


        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void checkBoxParcare_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxParcare.Checked ) { labelTaxaParcare.Visible = true; }
            else { labelTaxaParcare.Visible = false; }
            textBoxPretFinal.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void clientNou_Click(object sender, EventArgs e)
        {
            Clienti cl = new Clienti();
            cl.CodClient = listaClienti.Max(client => client.CodClient) + 3;
            cl.DataNasterii = DateTime.Now;
            using(ClientNouForm form = new ClientNouForm(listaRezervari,listaCamere,listaClienti, cl))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxCodClient.Text = cl.CodClient.ToString();
                    listaClienti.Add(cl);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopulateTreeView(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
        }

        private void Rezervare_Load(object sender, EventArgs e)
        {

        }

        private void treeViewCamere_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeViewCamere.SelectedNode.Level == 2)
                textBoxCodCamera.Text = treeViewCamere.SelectedNode.Tag.ToString();
        }

        private void clientExistent_Click(object sender, EventArgs e)
        {
            Clienti c = new Clienti();
            using (ClientiForm form = new ClientiForm(listaRezervari , listaCamere, listaClienti, c))
            {
                DialogResult result = form.ShowDialog();

                if(result == DialogResult.OK) textBoxCodClient.Text = c.CodClient.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodCamera.Text) &&
                !string.IsNullOrWhiteSpace(textBoxCodClient.Text) &&
                dateTimePickerCheckIn.Value.Date <= dateTimePickerCheckOut.Value.Date)
            {
                Camere c = listaCamere.Find(camera => camera.Cod == textBoxCodCamera.Text);
                Clienti cl = listaClienti.Find(client => client.CodClient == int.Parse(textBoxCodClient.Text));

                if (c != null && cl != null)
                {
                    Rezervari r = new Rezervari(c, cl, dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value, checkBoxParcare.Checked);
                    double pretFinal = r.calculPretFinal();
                    textBoxPretFinal.Text = pretFinal.ToString("N2", CultureInfo.InvariantCulture);

                }
            }
            else
            {
                textBoxPretFinal.Text = "";
                MessageBox.Show("Trebuie sa introduci corect toate datele pentru a calcula pretul final!");
            }
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxCodCamera.Text))
            {
                MessageBox.Show("Codul camerei este gol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCodClient.Text))
            {
                MessageBox.Show("Codul clientului este gol.");
                return;
            }

            if (dateTimePickerCheckIn.Value > dateTimePickerCheckOut.Value)
            {
                MessageBox.Show("Data de check-in trebuie să fie mai mică sau egală cu data de check-out.");
                return;
            }

            Camere c = listaCamere.Find(camera => camera.Cod == textBoxCodCamera.Text);
            if (c == null)
            {
                MessageBox.Show("Camera nu a fost găsită.");
                return;
            }

            if (!int.TryParse(textBoxCodClient.Text, out int codClient))
            {
                MessageBox.Show("Codul clientului nu este valid.");
                return;
            }

            Clienti cl = listaClienti.Find(client => client.CodClient == codClient);
            if (cl == null)
            {
                MessageBox.Show("Clientul nu a fost găsit.");
                return;
            }
            if (rezervare != null)
            {
                listaRezervari.Remove(rezervare);
                rezervare.Camera = c;
                rezervare.Client = cl;
                rezervare.CheckIn = dateTimePickerCheckIn.Value;
                rezervare.CheckOut = dateTimePickerCheckOut.Value;
                rezervare.ParcareInclusa = checkBoxParcare.Checked;
                rezervare.PretFinal = rezervare.calculPretFinal();
                listaRezervari.Add(rezervare);
                MessageBox.Show($"Rezervarea {rezervare.CodRezervare} a fost modificata cu succes!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                Rezervari r = new Rezervari(c, cl, dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value, checkBoxParcare.Checked);
                listaRezervari.Add(r);
                MessageBox.Show($"Rezervarea {r.CodRezervare} a fost adăugată cu succes!");
                DialogResult = DialogResult.OK;
            }
        }

        private void textBoxCodClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshCamereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonVeziCamere.PerformClick();
        }
    }
}
