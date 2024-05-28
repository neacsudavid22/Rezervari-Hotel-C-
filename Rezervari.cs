using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Hotel
{
    public class Rezervari : ICloneable, IComparable
    {
        public static int currentValue = 100;

        private int codRezervare;
        private Camere camera;
        private Clienti client;
        private DateTime checkIn;
        private DateTime checkOut;
        private bool parcareInclusa;
        private double pretFinal;
        public Rezervari() {
            if (currentValue > 900) currentValue = 0;
            currentValue += 5;
            codRezervare = currentValue;
        }
        public Rezervari(Camere cameraP, Clienti clientP, DateTime checkInP, DateTime checkOutP, bool parcareInclusaP)
        {
            if (currentValue > 900) currentValue = 0;
            currentValue += 5;
            codRezervare = currentValue;
            camera = cameraP;
            client = clientP;
            parcareInclusa = parcareInclusaP;
            checkIn = checkInP;
            checkOut = checkOutP;
            pretFinal = calculPretFinal();
        }
        public int CodRezervare { get { return codRezervare; } set { codRezervare = value; } }
        public Camere Camera { get { return camera; } set { camera = value; } }
        public Clienti Client { get { return client; } set { client = value; } }
        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }
        public bool ParcareInclusa { get { return parcareInclusa; } set {  parcareInclusa = value; } }
        public double PretFinal { get {  return pretFinal; } set {  pretFinal = value; } }
        public int nrZile()
        {
            return (checkOut - checkIn).Days + 1;
        }
        public double calculPretFinal()
        {
            double pret = 0;
            pret += camera.pretPeNoapte() * nrZile();
            if (parcareInclusa) { pret += 50 * nrZile(); }
            return pret;
        }
        public object Clone()
        {
            var clone = (Rezervari)this.MemberwiseClone();
            return clone;
        }
        public int CompareTo(object ob)
        {
            Rezervari rezervare = (Rezervari)ob;
            if (calculPretFinal() == rezervare.calculPretFinal()) return 0;
            else if (calculPretFinal() < rezervare.calculPretFinal()) return -1;
            else return 1;
        }
        public string ToString()
        {
            return codRezervare.ToString() + ',' + camera.Cod + ',' + client.CodClient 
                + ',' + checkIn + ',' + checkOut + ',' + parcareInclusa + ',' + pretFinal + '\n';
        }
    }
}
