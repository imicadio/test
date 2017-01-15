using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukiernia
{
    class Przepis
    {
        private string nazwa;
        private double suma = 0;
        private List<Skladnik> skladniki = new List<Skladnik>();
        private int czasPrzygotowania;

        public void DodajSkladnik(string nazwaSkladnika, string ilosc, double cenaSkladnika)
        {
            skladniki.Add(new Skladnik(nazwaSkladnika, ilosc, cenaSkladnika));
            suma += cenaSkladnika;
        }
        public void UstawNazweICzas(string nazwa, int czas)
        {
            this.nazwa = nazwa;
            this.czasPrzygotowania = czas;
        }
        public override string ToString()
        {
            string info="";
            double suma_cen=0;            
            skladniki.Sort();
            foreach (var element in skladniki)
            {
                info += Environment.NewLine + element;
                suma_cen += element.GetCena();
            }
            return info + Environment.NewLine +"Suma: "+Convert.ToString(suma_cen);
        }
        public bool CzyCzas()
        {
            if (czasPrzygotowania > 0)
                return true;
            return false;
        }
        public int IleSkladnikow()
        {
            int ile = 0;
            foreach (var element in skladniki)
                ile += 1;
            return ile;
        }
    }
}
