using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukiernia
{
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;

        public virtual bool PoprawnyCzas()
        {
            if (DateTime.Compare(czasDostawy, DateTime.Today) > 0)
                return true;
            return false;
        }
        public void UstawCzasDostawy(DateTime data)
        {
            czasDostawy = data;
        }
    }
}
