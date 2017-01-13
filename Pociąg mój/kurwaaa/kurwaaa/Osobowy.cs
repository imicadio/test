﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa
{
    class Osobowy : Wagon
    {
        private string rodzaj;

        public Osobowy(string model, int masa, string rodzaj) // konstruktor parametryczny 
            :base(model, masa)
        {
            this.rodzaj = rodzaj;
        }

        public override string Informacje()
        {
            return "Wagon osobowy: " + model + ", " + masa + ", " + rodzaj;
        }
    }
}
