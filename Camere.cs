using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Hotel
{
    public enum Capacitate
    {
        Single, 
        Double,
        Triple,
        Quad
    }
    public enum Tip
    {
        Standard,
        Superior,
        Deluxe
    }
    public class Camere : ICloneable, IComparable
    {
        private string cod;
        private Capacitate capCam;
        private Tip tipCam;
        public Camere() {}
        public Camere(string codP, Capacitate capCamP, Tip tipCamP)
        {
            cod = codP;
            tipCam = tipCamP;
            capCam = capCamP;
        }
        public string Cod { get { return cod; } set { cod = value; } }
        public Capacitate CapCam { get { return capCam; } set {  capCam = value; } }
        public Tip TipCam { get { return tipCam; } set {  tipCam = value; } }

        public double pretPeNoapte()
        {
            double pret = 0.99;

            if (capCam == Capacitate.Single) { pret += 39; }
            else if (capCam == Capacitate.Double) { pret += 59; }
            else if (capCam == Capacitate.Triple) { pret += 79; }
            else if (capCam == Capacitate.Quad){ pret += 99; }

            if(tipCam == Tip.Standard) { pret += 20; }
            else if(tipCam == Tip.Superior) { pret += 40; }
            else if(tipCam == Tip.Deluxe) { pret += 70; }

            return pret;
        }
        public object Clone()
        {
            var clone = (Camere)this.MemberwiseClone();
            return clone;
        }

        public int CompareTo(object ob)
        {
            Camere camera = (Camere)ob;
            if (pretPeNoapte() == camera.pretPeNoapte()) return 0;
            else if (pretPeNoapte() < camera.pretPeNoapte()) return -1;
            else return 1;
        }

        public string ToString()
        {
            return cod.ToString() + ',' + capCam + ',' + tipCam + '\n';
        }
    }
}
