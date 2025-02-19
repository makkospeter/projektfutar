using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    internal class Csomag
    {
        public string Azonosito { get; }
        public Celallomas Cel { get; }

        public Csomag(string azonosito, Celallomas cel)
        {
            Azonosito = azonosito;
            Cel = cel;
        }
    }
}
