using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KasaFiskalnaWPF
{
    /// <summary>
    /// Klasa dla koszyków.
    /// </summary>
    
    class Koszyk : IKoszyk
    {
        //deklarcja pola w klasie
        private List<Produkt> zakupy;

        public Koszyk() //konstruktor domyślny
        {
            zakupy = new List<Produkt>(); //inicjacja listy
        }

        public void DodajProdukt(string nazwa, double cenaJednostkowa, double ilosc)  //implementaca metody na dodanie produku do zakupów
        {
            zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
        }

        public void SkopiujOstatni() //metoda kopiująca ostatni element na liście zakupy
        {
            if (zakupy.Count > 0) zakupy.Add(zakupy.Last());
        }

        public void Skasuj(int indeks) //metoda kasująca element o wskazanym indeksie
        {
            if (zakupy.Count > 0) zakupy.Remove(zakupy.Last());
        }

        public void Wydrukuj() //drukowanie paragonu
        {
            string nazwa = DateTime.Now.ToString("yyyyMMddHHmmss")+".txt";
            
            using (StreamWriter sw = new StreamWriter(nazwa))
            {
                sw.Write(PodajZawartosc());               
            }       
            Wyczysc();
        }

        public void Wyczysc() //metoda na czyszczenie listy zakupów
        {
            zakupy.Clear();
        }

        public string PodajZawartosc() //metoda zwracająca zawartość koszyka
        {
            string info = "Zawartość koszyka:";
            double suma = 0;
            for(int i=0; i<zakupy.Count;i++)
            {
                info += Environment.NewLine + "["+i+"] "+zakupy[i].ToString();
                suma += zakupy[i].PodajCeneLaczna();
            }
            info += Environment.NewLine + "Suma: " + suma;
            return info;
        }
    }
}

