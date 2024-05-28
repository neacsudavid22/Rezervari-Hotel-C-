using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect_Paw_Hotel
{
    public partial class ClientNouForm : Form
    {
        private Clienti client;
        private Camere camera;
        private Rezervari rezervare;
        private List<Rezervari> listaRezervari;
        private List<Camere> listaCamere;
        private List<Clienti> listaClienti;
        private bool flagModf;

        public ClientNouForm(List<Rezervari> listaRezervariRef, List<Camere> listaCamereRef, List<Clienti> listaClientiRef, Clienti c_ref)
        {
            InitializeComponent();
            listaRezervari = listaRezervariRef;
            listaCamere = listaCamereRef;
            listaClienti = listaClientiRef;

            client = c_ref;
            flagModf = false;
            if (c_ref != null)
            {
                textBoxNume.Text = c_ref.Nume;
                textBoxPrenume.Text = c_ref.Prenume;
                textBoxNrTelefon.Text = c_ref.Telefon;
                textBoxEmail.Text = c_ref.Email;

                if(c_ref.DataNasterii > new DateTime(1900,1,1) 
                    && c_ref.DataNasterii < DateTime.Now)
                {
                    dateTimePickerDNasterii.Value = c_ref.DataNasterii;
                }
                        
                else dateTimePickerDNasterii.Value = DateTime.Now;
                flagModf = true;
                
            }
            else
            {
                client = new Clienti();
            }

            KeyDown += new KeyEventHandler(ClientNou_KeyDown);
            KeyPreview = true;

            textBoxNume.KeyPress += textBoxNume_KeyPress;
            textBoxPrenume.KeyPress += textBoxPrenume_KeyPress;
            textBoxEmail.Validating += textBoxEmail_Validating;
            textBoxNrTelefon.Validating += textBoxNrTelefon_Validating;
            textBoxNrTelefon.KeyPress += textBoxNrTelefon_KeyPress;

            Clienti.cod = listaClienti.Max(client => client.CodClient);
            Rezervari.currentValue = listaRezervari.Max(rezervare => rezervare.CodRezervare);
        }
        private void ClientNou_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                buttonA.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                buttonR.PerformClick();
            } 
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNume.Text))
            {
                MessageBox.Show("Numele este gol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrenume.Text))
            {
                MessageBox.Show("Prenumele este gol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNrTelefon.Text))
            {
                MessageBox.Show("Numărul de telefon este gol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Email-ul este gol.");
                return;
            }

            if ((DateTime.Now - dateTimePickerDNasterii.Value).Days <= 18 * 365)
            {
                MessageBox.Show("Vârsta clientului trebuie să fie minim de 18 ani!");
                return;
            }

            if (flagModf == true)
            {
                client.Nume = textBoxNume.Text;
                client.Prenume = textBoxPrenume.Text;
                client.DataNasterii = dateTimePickerDNasterii.Value;
                client.Telefon = textBoxNrTelefon.Text;
                client.Email = textBoxEmail.Text;
                MessageBox.Show($"Clientul {client.CodClient} a fost modificat cu succes!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                Clienti cl = new Clienti(textBoxNume.Text, textBoxPrenume.Text,
                    dateTimePickerDNasterii.Value, textBoxNrTelefon.Text, textBoxEmail.Text);
                cl.CodClient = listaClienti.Max(client => client.CodClient) + 3;
                listaClienti.Add(cl);
                MessageBox.Show($"Clientul {cl.CodClient} a fost adăugat cu succes!");
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNume.Text = string.Empty;
            textBoxPrenume.Text = string.Empty;
            dateTimePickerDNasterii.Value = DateTime.Now;
            textBoxNrTelefon.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

        private void ClientNouForm_Load(object sender, EventArgs e)
        {
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Format simplu pentru email
            if (!Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                errorProvider1.SetError(textBoxEmail, "Email invalid.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxEmail, "");
            }
        }

        private void textBoxNrTelefon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string patternTelefon = @"^07\d{8}$";

            if (!Regex.IsMatch(textBoxNrTelefon.Text, patternTelefon))
            {
                errorProvider2.SetError(textBoxNrTelefon, "Nr telefon invalid.");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(textBoxNrTelefon, "");
            }
        }

        private void textBoxNrTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
