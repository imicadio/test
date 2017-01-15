using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukiernia
{
    class Skladnik : IComparable<Skladnik>
    {
        private string nazwaSkladnika;
        private string ilosc;
        private double cenaSkladnika;
        public Skladnik (string nazwaSkladnika, string ilosc, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.ilosc = ilosc;
            this.cenaSkladnika = cenaSkladnika;
        }
        public override string ToString()
        {
            return "Nazwa: " + nazwaSkladnika + ", ilość:" + ilosc + ", cena:" + cenaSkladnika;
        }
        public double GetCena()
        {
            return cenaSkladnika;
        }
        public int CompareTo(Skladnik skladnik)
        {
            return this.nazwaSkladnika.CompareTo(skladnik.nazwaSkladnika);
        }
    }
}
