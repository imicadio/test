using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Przychodnia2
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci = new Stack<Pacjent>();
        public void UstawLekarz(string imieN, string specjalnosc)
        {
            lekarz = new Lekarz(imieN, specjalnosc);
        }
        public void ZapiszDoLekarza(string imieN, int wiek, string choroba)
        {
            Pacjent pacjent = new Pacjent(imieN, wiek, choroba);
            pacjenci.Push(pacjent);
        }
        public string WykonajPorade()
        {
            return "Wykonano porade! " + pacjenci.Pop();
        }
        public string WykonajBadanie()
        {
            return "Wykonano badanie! " + pacjenci.Peek();
        }
        public int CzasOczekiwania()
        {
            int ile = 0;
            foreach (var element in pacjenci)
            {
                ile += 1;
            }

            return ile / 5;
        }
        public string Oczekujacy()
        {
            string info = "";
            foreach (var element in pacjenci)
            {
                info += Environment.NewLine + element+ "\n###############";
            }
            return info;
        }
        public override string ToString()
        {
            return lekarz.ToString() + Environment.NewLine + "Oczekujacy pacjenci: " + Oczekujacy();
        }
        public void GenerujRaport()
        {
            //string nazwa = "Raport" + DateTime.Now.ToString("ddMMyyyyHHmm") + ".txt";
            string nazwa = DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            using (StreamWriter sw = new StreamWriter(nazwa))
            {
                sw.Write(Oczekujacy());
            }
        }
        public bool CzyLekarz()
        {
            if (lekarz != null)
                return true;
            else
                return false;
        }
    }
}
