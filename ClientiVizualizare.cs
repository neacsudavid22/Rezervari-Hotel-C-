using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw_Hotel
{
    public partial class ClientiVizualizare : Form
    {
        private Clienti client;
        private Camere camera;
        private Rezervari rezervare;
        private List<Rezervari> listaRezervari;
        private List<Camere> listaCamere;
        private List<Clienti> listaClienti;

        public ClientiVizualizare(List<Rezervari> listaRezervariRef, List<Camere> listaCamereRef, List<Clienti> listaClientiRef)
        {
            InitializeComponent();
            populareListView(listaClientiRef);
            listaRezervari = listaRezervariRef;
            listaCamere = listaCamereRef;
            listaClienti = listaClientiRef;
            KeyDown += new KeyEventHandler(ClientNou_KeyDown);
            KeyPreview = true;

            listViewClienti.ContextMenuStrip = contextMenuStrip1;

            Clienti.cod = listaClienti.Max(client => client.CodClient);
            Rezervari.currentValue = listaRezervari.Max(rezervare => rezervare.CodRezervare);
        }

        private void Refresh()
        {
            string caleFisier = "..//..//camere.txt";
            string caleFisier2 = "..//..//clienti.txt";
            string caleFisier3 = "..//..//rezervari.txt";

            SalveazaCamereInFisier(caleFisier, listaCamere);
            SalveazaClientiInFisier(caleFisier2, listaClienti);
            SalveazaRezervariInFisier(caleFisier3, listaRezervari);
            listViewClienti.Items.Clear();

            populareListView(listaClienti);
        }
        public static void SalveazaCamereInFisier(string caleFisier, List<Camere> camere)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caleFisier))
                {
                    foreach (Camere camera in camere)
                    {
                        writer.WriteLine($"{camera.Cod},{camera.CapCam},{camera.TipCam}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la scrierea în fișier: " + ex.Message);
            }
        }
        public static void SalveazaClientiInFisier(string caleFisier, List<Clienti> clienti)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caleFisier))
                {
                    foreach (Clienti client in clienti)
                    {
                        writer.WriteLine($"{client.CodClient},{client.Nume},{client.Prenume},{client.DataNasterii:yyyy-MM-dd},{client.Telefon},{client.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la scrierea în fișier: " + ex.Message);
            }
        }
        public static void SalveazaRezervariInFisier(string caleFisier, List<Rezervari> rezervari)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(caleFisier))
                {
                    foreach (Rezervari rezervare in rezervari)
                    {
                        writer.WriteLine($"{rezervare.CodRezervare},{rezervare.Camera.Cod},{rezervare.Client.CodClient},{rezervare.CheckIn:yyyy-MM-dd},{rezervare.CheckOut:yyyy-MM-dd},{rezervare.ParcareInclusa},{rezervare.PretFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la scrierea în fișier: " + ex.Message);
            }
        }

        private void ClientNou_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                buttonAdaugaClient.PerformClick();
            }
            else if (e.KeyCode == Keys.M)
            {
                buttonModificaClient.PerformClick();
            }
            else if (e.KeyCode == Keys.P)
            {
                printeaza.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                buttonStergeClient.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintListView(e.Graphics);
        }

        private void PrintListView(Graphics graphics)
        {
            int startX = 50;
            int startY = 50;
            int offsetX = 10;
            int offsetY = 25;

            foreach (ColumnHeader column in listViewClienti.Columns)
            {
                graphics.DrawString(column.Text, listViewClienti.Font, Brushes.Black, startX, startY);
                startX += column.Width + offsetX;
            }

            startX = 50;
            startY += offsetY;

            foreach (ListViewItem item in listViewClienti.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    graphics.DrawString(subItem.Text, listViewClienti.Font, Brushes.Black, startX, startY);
                    startX += listViewClienti.Columns[item.SubItems.IndexOf(subItem)].Width + offsetX;
                }

                startX = 50;
                startY += offsetY;
            }
        }

        public void populareListView(List<Clienti> listaClienti)
        {
            foreach (Clienti cl in listaClienti)
            {
                ListViewItem item = new ListViewItem(cl.CodClient.ToString());
                item.SubItems.Add(cl.Nume);
                item.SubItems.Add(cl.Prenume);
                item.SubItems.Add(cl.DataNasterii.ToString("dd MMMM yyyy"));
                item.SubItems.Add(cl.Telefon);
                item.SubItems.Add(cl.Email);

                listViewClienti.Items.Add(item);
            }
        }
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintListViewSelectedItems(e.Graphics);
        }

        private void rezervarileSelectateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument2;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }
        private void PrintListViewSelectedItems(Graphics graphics)
        {
            int startX = 50;
            int startY = 50;
            int offsetX = 10;
            int offsetY = 25;

            foreach (ColumnHeader column in listViewClienti.Columns)
            {
                graphics.DrawString(column.Text, listViewClienti.Font, Brushes.Black, startX, startY);
                startX += column.Width + offsetX;
            }

            startX = 50;
            startY += offsetY;

            foreach (ListViewItem item in listViewClienti.SelectedItems)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    graphics.DrawString(subItem.Text, listViewClienti.Font, Brushes.Black, startX, startY);
                    startX += listViewClienti.Columns[item.SubItems.IndexOf(subItem)].Width + offsetX;
                }

                startX = 50;
                startY += offsetY;
            }
        }

        private void listViewClienti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientExistent_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void documentulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printeaza.PerformClick();
        }

        private void inregistrarileSelectateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument2;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void buttonAdaugaRez_Click(object sender, EventArgs e)
        {
            Hide();
            using (ClientNouForm ClientiNouForm = new ClientNouForm(listaRezervari, listaCamere, listaClienti, null))
            {
                DialogResult result = ClientiNouForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listViewClienti.Items.Clear();
                    populareListView(listaClienti);
                }
            }
            Show();
        }

        private void buttonModificaRez_Click(object sender, EventArgs e)
        {
            if (listViewClienti.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listViewClienti.SelectedItems[0];

                string codClient = selectedItem.SubItems[0].Text;
                Clienti cl = listaClienti.Find(client => client.CodClient == int.Parse(codClient));

                if (cl != null)
                {
                    using (ClientNouForm rezForm = new ClientNouForm(listaRezervari, listaCamere, listaClienti, cl))
                    {
                        DialogResult result = rezForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            listViewClienti.Items.Clear();
                            populareListView(listaClienti);
                        }
                    }
                }
            }
            else if (listViewClienti.SelectedItems.Count > 1)
            {
                MessageBox.Show("Vă rugăm să selectați doar un singur client pentru a modifica!");
            }
            else MessageBox.Show("Trebuie să selectați un client pentru a putea modifica!");
        }

        private void buttonStergeRez_Click(object sender, EventArgs e)
        {
            if (listViewClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nu există Clienții selectați de șters.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Sigur doriți să ștergeți clienții selectați?", "Confirmare Ștergere", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (ListViewItem selectedItem in listViewClienti.SelectedItems)
                {
                    int codClientDeSters = int.Parse(selectedItem.SubItems[0].Text);
                    Clienti clientDeSters = listaClienti.Find(client => client.CodClient == codClientDeSters);
                    if (clientDeSters != null)
                    {
                        listaClienti.Remove(clientDeSters);
                    }

                    listViewClienti.Items.Remove(selectedItem);
                }

                MessageBox.Show("Clienții selectați au fost șterși.");
            }
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdaugaClient.PerformClick();
        }

        private void stergeClientiSelectatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStergeClient.PerformClick();
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdaugaClient.PerformClick();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonModificaClient.PerformClick();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStergeClient.PerformClick();
        }
        private void ClientiVizualizare_Load(object sender, EventArgs e) 
        {

        }

        private void modificaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonModificaClient.PerformClick();
        }
    }
}
