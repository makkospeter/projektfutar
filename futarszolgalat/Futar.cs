using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    internal class Futar
    {
        public string Nev { get; }
        private List<Csomag> Csomagok = new List<Csomag>();

        public Futar(string nev)
        {
            Nev = nev;
        }

        public void FelveszCsomag(Csomag csomag)
        {
            Csomagok.Add(csomag);
            Console.WriteLine($"{Nev} felvette a(z) {csomag.Azonosito} csomagot.");
        }

        public void Kiszallit()
        {
            foreach (var csomag in Csomagok)
            {
                Console.WriteLine($"{Nev} kiszállította a(z) {csomag.Azonosito} csomagot a {csomag.Celallomas} célállomásra.");
            }
            Csomagok.Clear();
        }
    }
}
