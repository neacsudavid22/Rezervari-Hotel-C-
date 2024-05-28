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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_Paw_Hotel
{
    public partial class Home : Form
    {
        private List<Rezervari> listaRezervari = new List<Rezervari>();
        private List<Camere> listaCamere = new List<Camere>();
        private List<Clienti> listaClienti = new List<Clienti>();
        
        public Home()
        {
            InitializeComponent();

            string caleFisier = "..//..//camere.txt";
            listaCamere = IncarcaCamereDinFisier(caleFisier);

            string caleFisier2 = "..//..//clienti.txt";

            listaClienti = IncarcaClientiDinFisier(caleFisier2);

            string caleFisier3 = "..//..//rezervari.txt";

            listaRezervari = IncarcaRezervariDinFisier(caleFisier3, listaCamere, listaClienti);

            SalveazaCamereInFisier(caleFisier, listaCamere);
            SalveazaClientiInFisier(caleFisier2, listaClienti);
            SalveazaRezervariInFisier(caleFisier3, listaRezervari);

            populareListView(listaRezervari);
            KeyDown += new KeyEventHandler(Home_KeyDown);
            KeyPreview = true;

            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            listViewRezervari.ContextMenuStrip = contextMenuStrip1;

            Clienti.cod = listaClienti.Max(client => client.CodClient);
            Rezervari.currentValue = listaRezervari.Max(rezervare => rezervare.CodRezervare);
        }
        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                buttonAdaugaRez.PerformClick();
            }
            else if(e.KeyCode == Keys.M)
            {
                buttonModificaRez.PerformClick();
            }    
            else if(e.KeyCode == Keys.S)
            {
                buttonStergeRez.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Refresh()
        {
            string caleFisier = "..//..//camere.txt";
            string caleFisier2 = "..//..//clienti.txt";
            string caleFisier3 = "..//..//rezervari.txt";

            SalveazaCamereInFisier(caleFisier, listaCamere);
            SalveazaClientiInFisier(caleFisier2, listaClienti);
            SalveazaRezervariInFisier(caleFisier3, listaRezervari);
            listViewRezervari.Items.Clear();

            populareListView(listaRezervari);
        }

        private void buttonAdaugaRez_Click(object sender, EventArgs e)
        {
            Hide();
            using (Rezervare rezForm = new Rezervare(listaRezervari, listaCamere, listaClienti, null))
            {
                DialogResult result = rezForm.ShowDialog();
            }
            Refresh();
            Show();
        }
        public static List<Camere> IncarcaCamereDinFisier(string caleFisier)
        {
            List<Camere> camere = new List<Camere>();

            try
            {
                using (StreamReader reader = new StreamReader(caleFisier))
                {
                    string linie;
                    while ((linie = reader.ReadLine()) != null)
                    {
                        string[] dateCamera = linie.Split(',');

                        if (dateCamera.Length >= 3)
                        {
                            string cod = dateCamera[0];
                            Capacitate capacitate = (Capacitate)Enum.Parse(typeof(Capacitate), dateCamera[1]);
                            Tip tip = (Tip)Enum.Parse(typeof(Tip), dateCamera[2]);

                            Camere camera = new Camere(cod, capacitate, tip);
                            camere.Add(camera);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea din fișier: " + ex.Message);
            }
            return camere;
        }


        public static List<Clienti> IncarcaClientiDinFisier(string caleFisier)
        {
            List<Clienti> clienti = new List<Clienti>();

            try
            {
                using (StreamReader reader = new StreamReader(caleFisier))
                {
                    string linie;
                    while ((linie = reader.ReadLine()) != null)
                    {
                        string[] dateClient = linie.Split(',');

                        if (dateClient.Length >= 3)
                        {
                            int codClientv = int.Parse(dateClient[0]);
                            string nume = dateClient[1];
                            string prenume = dateClient[2];
                            DateTime dataNastere = DateTime.Parse(dateClient[3]);
                            string telefon = dateClient[4];
                            string email = dateClient[5];

                            Clienti client = new Clienti(nume, prenume, dataNastere, telefon, email)
                            {
                                CodClient = codClientv
                            };

                            clienti.Add(client);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea din fișier: " + ex.Message);
            }
            return clienti;
        }



        public static List<Rezervari> IncarcaRezervariDinFisier(string caleFisier,
                    List<Camere> listaCamereP, List<Clienti> listaClientiP)
        {
            List<Rezervari> rezervari = new List<Rezervari>();
            try
            {
                using (StreamReader reader = new StreamReader(caleFisier))
                {
                    string linie;
                    while ((linie = reader.ReadLine()) != null)
                    {
                        string[] dateRezervare = linie.Split(',');

                        if (dateRezervare.Length >= 7)
                        {
                            int codRez = int.Parse(dateRezervare[0]);
                            string codCamera = dateRezervare[1];
                            Camere camera = listaCamereP.Find(cameraC => cameraC.Cod.Equals(codCamera));
                            int codClient = int.Parse(dateRezervare[2]);
                            Clienti client = listaClientiP.Find(clientC => clientC.CodClient.Equals(codClient));
                            DateTime checkIn = DateTime.Parse(dateRezervare[3]);
                            DateTime checkOut = DateTime.Parse(dateRezervare[4]);
                            bool parcareInclusa = bool.Parse(dateRezervare[5]);
                            double pretFinal = double.Parse(dateRezervare[6], CultureInfo.InvariantCulture);

                            Rezervari rezervare = new Rezervari(camera, client, checkIn, checkOut, parcareInclusa)
                            {
                                CodRezervare = codRez,
                                PretFinal = pretFinal
                            };

                            rezervari.Add(rezervare);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea din fișier: " + ex.Message);
            }
            return rezervari;
        }
        public void populareListView(List<Rezervari> listaRez)
        {
            listaRezervari.OrderBy(rez => rez.CodRezervare);
            foreach (Rezervari rez in listaRez) 
            {
                ListViewItem item = new ListViewItem(rez.CodRezervare.ToString());
                item.SubItems.Add(rez.CheckIn.ToString("dd MMMM yyyy"));
                item.SubItems.Add(rez.CheckOut.ToString("dd MMMM yyyy"));
                item.SubItems.Add(rez.Camera.Cod.ToString());
                item.SubItems.Add(rez.Client.CodClient.ToString());
                item.SubItems.Add(rez.ParcareInclusa.ToString());
                item.SubItems.Add(rez.PretFinal.ToString("N2"));

                listViewRezervari.Items.Add(item);
            }
            listViewRezervari.Refresh();
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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificaRez_Click(object sender, EventArgs e)
        {
            if (listViewRezervari.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listViewRezervari.SelectedItems[0];

                int codRezervareInt = int.Parse(selectedItem.SubItems[0].Text);
                string codCamera = selectedItem.SubItems[3].Text;
                Camere c = listaCamere.Find(camera => camera.Cod == codCamera);

                string codClient = selectedItem.SubItems[4].Text;
                Clienti cl = listaClienti.Find(client => client.CodClient == int.Parse(codClient));

                DateTime checkIn = DateTime.Parse(selectedItem.SubItems[1].Text);
                DateTime checkOut = DateTime.Parse(selectedItem.SubItems[2].Text);
                bool parcareInclusa = bool.Parse(selectedItem.SubItems[5].Text);
                string text = selectedItem.SubItems[6].Text;
                text = text.Replace(".", "");
                double pretFinal = double.Parse(text, CultureInfo.InvariantCulture);

                Rezervari rezervareExistenta = listaRezervari.Find(rezervare => rezervare.CodRezervare == codRezervareInt);

                if (rezervareExistenta != null)
                {
                    using (Rezervare rezForm = new Rezervare(listaRezervari, listaCamere, listaClienti, rezervareExistenta))
                    {
                        DialogResult result = rezForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string caleFisier3 = "..//..//rezervari.txt";
                            SalveazaRezervariInFisier(caleFisier3, listaRezervari);

                            listViewRezervari.Items.Clear();
                            populareListView(listaRezervari);
                        }
                    }
                }
            }
            else if(listViewRezervari.SelectedItems.Count > 1)
            {
                MessageBox.Show("Vă rugăm să selectați doar o singura rezervare pentru a o modifica!");
            }
            else MessageBox.Show("Trebuie să selectați o rezervare pentru a putea modifica!");
        }


        private void listViewRezervari_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonStergeRez_Click(object sender, EventArgs e)
        {
            if (listViewRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nu există rezervări selectate de șters.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Sigur doriți să ștergeți rezervările selectate?", "Confirmare Ștergere", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (ListViewItem selectedItem in listViewRezervari.SelectedItems)
                {
                    int codRezervareInt = int.Parse(selectedItem.SubItems[0].Text);
                    Rezervari rezervareDeSters = listaRezervari.Find(rezervare => rezervare.CodRezervare == codRezervareInt);
                    if (rezervareDeSters != null)
                    {
                        listaRezervari.Remove(rezervareDeSters);
                    }

                    listViewRezervari.Items.Remove(selectedItem);
                }

                string caleFisier = "..//..//rezervari.txt";
                SalveazaRezervariInFisier(caleFisier, listaRezervari);

                MessageBox.Show("Rezervările selectate au fost șterse.");
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

            foreach (ColumnHeader column in listViewRezervari.Columns)
            {
                graphics.DrawString(column.Text, listViewRezervari.Font, Brushes.Black, startX, startY);
                startX += column.Width + offsetX;
            }

            startX = 50;
            startY += offsetY;

            foreach (ListViewItem item in listViewRezervari.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    graphics.DrawString(subItem.Text, listViewRezervari.Font, Brushes.Black, startX, startY);
                    startX += listViewRezervari.Columns[item.SubItems.IndexOf(subItem)].Width + offsetX;
                }

                startX = 50;
                startY += offsetY;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdaugaRez.PerformClick();
        }

        private void modificaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonModificaRez.PerformClick();
        }

        private void stergeRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStergeRez.PerformClick();
        }

        private void rezervarileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonPrinteazaFull.PerformClick();
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

            foreach (ColumnHeader column in listViewRezervari.Columns)
            {
                graphics.DrawString(column.Text, listViewRezervari.Font, Brushes.Black, startX, startY);
                startX += column.Width + offsetX;
            }

            startX = 50;
            startY += offsetY;

            foreach (ListViewItem item in listViewRezervari.SelectedItems)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    graphics.DrawString(subItem.Text, listViewRezervari.Font, Brushes.Black, startX, startY);
                    startX += listViewRezervari.Columns[item.SubItems.IndexOf(subItem)].Width + offsetX;
                }

                startX = 50;
                startY += offsetY;
            }
        }

        private void buttonVizRez_Click(object sender, EventArgs e)
        {
            Hide();
            using(ClientiVizualizare form = new ClientiVizualizare(listaRezervari, listaCamere, listaClienti))
            {
                DialogResult result = form.ShowDialog();
            }
            Refresh();
            Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonModificaRez.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            buttonStergeRez.PerformClick();
        }

        private void adaugaRezervareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonAdaugaRez.PerformClick();
        }

        private void printeazaDocumentulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonPrinteazaFull.PerformClick();
        }

        private void printeazaValorileSelectateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument2;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }
    }
}