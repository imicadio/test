using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Towarowy : Wagon
    {
        private string ladunek;

        public Towarowy(string model, int masa, string ladunek)
        {
            this.model = model;
            this.masa = masa;
            this.ladunek = ladunek;
        }

        public override string Informacje()
        {
            return "Wagon towarowy: model: " + this.model + ", waga: " + this.masa + ", ladunek: " + this.ladunek;
        }
    }
}
