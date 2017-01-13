using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Osobowy : Wagon
    {
        private string rodzaj;

        public Osobowy(string model, int masa, string rodzaj)
        {
            this.model = model;
            this.masa = masa;
            this.rodzaj = rodzaj;
        }

        public override string Informacje()
        {
            return "Wagon osobowy: model: " + this.model + ", waga: " + this.masa + ", rodzaj: " + this.rodzaj;
        }

    }
}
