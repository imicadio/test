using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasa
{
    interface IKoszyk
    {
        void DodajProdukt(string nazwa, double cenaJednostkowa, double ilosc);
        void SkopiujOstatni();
        void Skasuj(int pozycja);
        void Wydrukuj();
        void Wyczysc();
        string PodajZawartosc(); 
    }
}
