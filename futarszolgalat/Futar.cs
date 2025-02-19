using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futarszolgalat
{
    internal class Futar
    {
        public string FutarNev { get; }
        private List<Csomag> Csomagok = new List<Csomag>();

        public Futar(string nev)
        {
            FutarNev = nev;
        }

        //public string NEV(string nev) 
        //{
        //    if(nev == null)
        //    {
        //        return (null);
        //    }
        //    else
        //    {
        //        return(nev);
        //    }
        //}
    }
}