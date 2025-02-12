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
        public string Celallomas { get; }

        public Csomag(string azonosito, string celallomas)
        {
            Azonosito = azonosito;
            Celallomas = celallomas;
        }
    }
}
