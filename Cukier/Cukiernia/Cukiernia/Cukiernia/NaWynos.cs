using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukiernia
{
    class NaWynos : Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (DateTime.Today.Hour - czasDostawy.Hour > 2)
                return true;
            return false;
        }
    }
}
