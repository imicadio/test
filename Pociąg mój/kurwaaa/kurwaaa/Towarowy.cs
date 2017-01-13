using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa
{
    class Towarowy : Wagon
    {
        private string ladunek;

        public Towarowy(string model, int masa, string ladunek)
            : base(model, masa)
        {
            this.ladunek = ladunek;
        }

        public override string Informacje()
        {
            return "Wagon towarowy: " + model + ", " + masa + ", " + ladunek;
        }
    }
}
