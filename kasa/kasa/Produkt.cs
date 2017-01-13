using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasa
{
    class Produkt : IClonable
    {
        string nazwa;
        double cenaJednostkowa;
        double ilosc;

        public Produkt() { }

        public Produkt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }        

        public double PodajCeneLaczna()
        {
            double cena = ilosc * cenaJednostkowa;
            cena = Math.Round(cena, 2);
            return cena;
        }

        public override string ToString()
        {
            return "Nazwa" + ilosc + " * " + cenaJednostkowa.ToString() + " = " + PodajCeneLaczna();
        }
    }
}
