using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw_Hotel
{
    public partial class ClientiForm : Form
    {
        private Clienti client;
        private Camere camera;
        private Rezervari rezervare;
        private List<Rezervari> listaRezervari;
        private List<Camere> listaCamere;
        private List<Clienti> listaClienti;
        public ClientiForm(List<Rezervari> listaRezervariRef, List<Camere> listaCamereRef, List<Clienti> listaClientiRef, Clienti c_selected)
        {
            InitializeComponent();
            populareListView(listaClientiRef);
            listaRezervari = listaRezervariRef;
            listaCamere = listaCamereRef;
            listaClienti = listaClientiRef;
            client = c_selected;

            KeyPreview = true;

            Clienti.cod = listaClienti.Max(client => client.CodClient);
            Rezervari.currentValue = listaRezervari.Max(rezervare => rezervare.CodRezervare);
        }
        
        private void ClientiForm_Load(object sender, EventArgs e)
        {

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
        private void clientExistent_Click(object sender, EventArgs e)
        {
            Hide();
            if (listViewClienti.SelectedItems.Count == 1) {
                ListViewItem item = listViewClienti.SelectedItems[0]; 

                client.CodClient = int.Parse(item.SubItems[0].Text);
                client.Nume = item.SubItems[1].Text;
                client.Prenume = item.SubItems[2].Text;
                client.DataNasterii = DateTime.Parse(item.SubItems[3].Text);
                client.Telefon = item.SubItems[4].Text;
                client.Email = item.SubItems[5].Text;

                DialogResult = DialogResult.OK;
            }
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void clientNou_Click(object sender, EventArgs e)
        {
            Hide();
            using (ClientNouForm form = new ClientNouForm(listaRezervari,
                listaCamere, listaClienti, client))
            {
                DialogResult result = form.ShowDialog();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
