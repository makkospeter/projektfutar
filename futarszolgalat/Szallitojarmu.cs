using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    internal class Szallitojarmu
    {
        public string Rendszam { get; }
        public double UzemanyagSzint { get; private set; }

        private const double FogyasztasPerCsomag = 2.0;
        public List<Csomag> Rakomany { get; } = new List<Csomag>();

        public Szallitojarmu(string rendszam, double kezdoUzemanyag)
        {
            Rendszam = rendszam;
            kezdoUzemanyag = 50;
            UzemanyagSzint = kezdoUzemanyag;

            
        }

        public void Tankol(double mennyiseg)
        {
            if (UzemanyagSzint >= 50)
            {
                throw new Exception("Tele a tank!");
            }
            
            if((UzemanyagSzint + mennyiseg) >= 50)
            {
                UzemanyagSzint = 50;            }
            else
            {
                UzemanyagSzint += mennyiseg;
            }
        }

        public bool FelveszCsomagot(Csomag csomag)
        {
            Rakomany.Add(csomag);
            return true;
        }

        public bool Kiszallit()
        {
            if (Rakomany.Count == 0)
            {
                throw new Exception("Nincs felvéve csomag jelenleg!");
            }
            double szuksegesUzemanyag = Rakomany.Count * FogyasztasPerCsomag;

            if (UzemanyagSzint < szuksegesUzemanyag)
                return false;

            UzemanyagSzint -= szuksegesUzemanyag;
            Rakomany.Clear();
            return true;
        }
    }
}
