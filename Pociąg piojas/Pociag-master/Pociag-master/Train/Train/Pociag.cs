using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Pociag:IPoprawnyPociag,IUzupelnijSklad
    {
        private List<Wagon> wagony = new List<Wagon>();
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();

        public void DodajOsobowy(int masa, string model, string rodzaj)
        {
            wagony.Add(new Osobowy(model,masa,rodzaj));
        }
        public void DodajTowarowy(int masa, string model, string ladunek)
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }
        public void DodajLokomotywe(int masa, string model)
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public bool MozeJechac()
        {
            int l = 0;
            int w = 0;

            foreach (var element in lokomotywy)
            {
                l += element.ReturnMasa();
            }

            foreach (var element in wagony)
            {
                w+=element.ReturnMasa();
            }

            if (l >= w) return true;
            return false;

        }

        public string Informacje()
        {
            string typ = "Skład pociągu:\n";
            foreach (var element in lokomotywy)
            {
                typ +=element.Informacje();
                typ += "\n";
            }

            foreach (var element in wagony)
            {
                typ += element.Informacje();
                typ += "\n";
            }
            return typ;
        }
    }
}
