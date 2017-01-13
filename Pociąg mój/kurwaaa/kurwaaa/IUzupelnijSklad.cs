using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurwaaa
{
    interface IUzupelnijSklad
    {
        void DodajOsobowy(string model, int masa, string rodzaj);
        void DodajTowarowy(string model, int masa, string ladunek);
        void DodajLokomotywe(string model, int masa);
    }
}
