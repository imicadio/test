using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa
{
    class Lokomotywa
    {
        private string model;
        private int masa;

        public Lokomotywa(string model, int masa) // konstruktor parametyczny
        {
            this.model = model;
            this.masa = masa;
        }

        public int PobierzMase() // metoda bez parametru
        {
            return masa;
        }

        public string Informacje()
        {
            return "Lokomotywa: " + model + ", " + masa;
        }
    }
}
