using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalnaWPF
{
    /// <summary>
    /// Klasa dla produktów.
    /// </summary>
    
    class Produkt :ICloneable
    {
        //deklaracja pól
        private string nazwa;
        private double cenaJednostkowa;
        private double ilosc;

        public Produkt() { } //konstruktor domyślny

        public Produkt(string nazwa, double cenaJednostkowa, double ilosc) //konstruktor parametryczny
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        public Object Clone() //implementacja metody Clone (płytka kopia)
        {
            return MemberwiseClone();
        }

        public double PodajCeneLaczna() //metoda zwracająca cenę łączną
        {
            return Math.Round(ilosc * cenaJednostkowa, 2);
        }

        public override string ToString() //metoda zwracająca informacje o produkcie
        {
            return nazwa + ", " + ilosc + " * " + cenaJednostkowa + " = " + PodajCeneLaczna();
        }
    }
}
