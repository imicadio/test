using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalnaWPF
{
    interface IKoszyk
    {
        //deklaracja metod
        void DodajProdukt(string nazwa, double cenaJednostkowa, double ilosc);
        void SkopiujOstatni();
        void Skasuj(int indeks);
        void Wydrukuj();
        void Wyczysc();
        string PodajZawartosc();
    }
}
