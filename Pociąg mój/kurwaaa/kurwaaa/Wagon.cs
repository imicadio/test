using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa
{
    abstract class Wagon
    {
        // dekklaracja pól w klasie
        protected string model;
        protected int masa;

        abstract public string Informacje(); // deklaracja abstrakcyjnej metody Informacje() dla zwracania informacji o wagonie

        public int PobierzMase()
        {
            return masa;
        }

        public Wagon(string model, int masa)
        {
            this.model = model;
            this.masa = masa;
        }
    }
}
