using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa 
{
    class Pociag : IUzupelnijSklad, IPoprawnyPociag
    {
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();
        private List<Wagon> wagony = new List<Wagon>();

        public bool MozeJechac()
        {
            int masaL = 0;
            for (int i = 0; i<lokomotywy.Count; i++)
            {
                masaL += lokomotywy[i].PobierzMase();
            }

            int masaW = 0;
            foreach (var element in wagony)
            {
                masaW += element.PobierzMase();
            }

            if(masaL >= masaW && lokomotywy.Count > 0) 
                return true;
            else
                return false;
        }

        public void DodajLokomotywe(string model, int masa)
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public void DodajTowarowy(string model, int masa, string ladunek)
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }

        public void DodajOsobowy(string model, int masa, string rodzaj)
        {
            wagony.Add(new Osobowy(model, masa, rodzaj));
        }
        
        public string Informacje()
        {
            string info = "Skład pociągu";

            for (int i = 0; i<lokomotywy.Count; i++)
            {
                info += Environment.NewLine + lokomotywy[i].Informacje();
            }

            foreach (var element in wagony)
            {
                info += Environment.NewLine + element.Informacje();
            }
            return info;
        }

    }
}
