using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasa
{
    class Koszyk : IKoszyk
    {
        private List<Produkt> zakupy = new List<Produkt>();
        
        public Koszyk() { }

        public void DodajProdukt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
        }

        public void SkopiujOstatni()
        {
            if (zakupy.Count > 0)
            {
                //Produkt ostatni = (Produkt)zakupy[zakupy.Count - 1].Clone();
                //zakupy.Add(ostatni);
                zakupy.Add(zakupy.Last());
            }
        }

        public void Skasuj(int pozycja)
        {
            if (pozycja >= 0 )            
                zakupy.RemoveAt(pozycja);
            
        }

        public void Wydrukuj() //drukowanie paragonu
        {
            string nazwa = DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            using (StreamWriter sw = new StreamWriter(nazwa))
            {
                sw.Write(PodajZawartosc());
            }
            Wyczysc();
        }

        public void Wyczysc()
        {
            zakupy.Clear();
        }

        public string PodajZawartosc()
        {
            string info = "Zawartość koszyka: ";
            double suma = 0;
            for (int i = 0; i < zakupy.Count; i++)
            {
                info += Environment.NewLine + "[" + i + "]" + zakupy[i].ToString();
                suma += zakupy[i].PodajCeneLaczna();
            }

            info += Environment.NewLine + "Suma: " + suma;
            return info;
        }        
    }
}
