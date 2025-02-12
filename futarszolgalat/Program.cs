namespace futarszolgalat
{
    class Program
    {
        static void Main(string[] args)
        {
            Futar futar = new Futar("Kiss Péter");
            Csomag cs1 = new Csomag("CS001", "Budapest");
            Csomag cs2 = new Csomag("CS002", "Debrecen");

            futar.FelveszCsomag(cs1);
            futar.FelveszCsomag(cs2);

            futar.Kiszallit();
        }
    }
}
