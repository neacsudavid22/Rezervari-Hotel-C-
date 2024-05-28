using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Hotel
{
    public class Clienti : ICloneable, IComparable
    {
        public static int cod = 0;

        private int codClient;
        private string nume;
        private string prenume;
        private DateTime dataNasterii;
        private string telefon;
        private string email;
        public Clienti() {}
        public Clienti(string numeP, string prenumeP, DateTime dataNasteriiP, string telefonP, string emailP)
        {
            if (cod > 999) cod = 0;
            cod += 3;
            codClient = cod;
            nume = numeP;
            prenume = prenumeP;
            dataNasterii = dataNasteriiP;
            telefon = telefonP;
            email = emailP;
        }
        public int CodClient { get { return codClient; } set { codClient = value; } }
        public string Nume { get { return nume; } set { nume = value; } }
        public string Prenume { get { return prenume; } set { prenume = value; } }
        public DateTime DataNasterii { get {  return dataNasterii; } set { dataNasterii = value; } }
        public string Telefon { get {  return telefon; } set { telefon = value; } }
        public string Email { get { return email; } set { email = value; } }

        public object Clone()
        {
            var clone = (Clienti)this.MemberwiseClone();
            return clone;
        }
        public int CompareTo(object ob)
        {
            Clienti client = (Clienti)ob;
            if (dataNasterii == client.dataNasterii) return 0;
            else if (dataNasterii < client.dataNasterii) return -1;
            else return 1;
        }

        public string ToString()
        {
            return codClient.ToString() + ',' + nume + ',' + prenume + ',' + dataNasterii + ',' + telefon + email + '\n';
        }
    }
}
