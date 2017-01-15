using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia2
{
    class Lekarz : Osoba
    {
        private string specjalnosc;
        public Lekarz(string imieNazwisko, string specjalnosc)
            : base(imieNazwisko)
        {
            this.specjalnosc = specjalnosc;
        }
        public override string ToString()
        {
            return "Imie Nazwisko: " + imieNazwisko + ", Specjalnosc: " + specjalnosc;
        }
    }
}
