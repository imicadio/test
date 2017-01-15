using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia2
{
    interface IPrzychodnia
    {
        void UstawLekarz(string imieN, string specjalnosc);
        void ZapiszDoLekarza(string imieN, int wiek, string choroba);
        string WykonajPorade();
        string WykonajBadanie();
        int CzasOczekiwania();
        void GenerujRaport();
    }
}
