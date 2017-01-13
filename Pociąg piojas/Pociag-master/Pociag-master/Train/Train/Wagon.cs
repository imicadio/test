using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public abstract class Wagon
    {
        protected string model;
        protected int masa;

        public abstract string Informacje();

        public int ReturnMasa()
        {
            return this.masa;
        }
    }
}
