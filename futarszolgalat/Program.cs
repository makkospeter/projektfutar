using futarszolgalat;

Futar? loggedInFutar = null;

Celallomas budapest = new Celallomas("Budapest");
Celallomas debrecen = new Celallomas("Debrecen");
Celallomas szeged = new Celallomas("Szeged");

Szallitojarmu auto = new Szallitojarmu("ABC-123", 50);



while (true)
{
    Console.Clear();
    Console.WriteLine("1. Csomag felvétele\n2. Kiszállítás\n3. Tankolás\n4. Üzemanyagszint\n5. Bejelentkezés\n6. Profil megtekintése\n0. Kijelentkezés és Kilépés");
    Console.Write("Válassz egy opciót: ");
    string valasztas = Console.ReadLine();

    switch (valasztas)
    {
        case "1":
            Console.WriteLine("");
            Console.Write("Célállomás neve: ");
            string celNev = Console.ReadLine();
            Celallomas cel = new Celallomas(celNev);
            Csomag ujCsomag = new Csomag("CS" + new Random().Next(100, 999), cel);
            auto.FelveszCsomagot(ujCsomag);
            Console.WriteLine("Csomag felvéve!");
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;

        case "2":
            Console.WriteLine("");
            try
            {
                if (auto.Kiszallit())
                    Console.WriteLine("Sikeres kiszállítás!");
                else
                {
                    Console.WriteLine("Nincs elég üzemanyag a kiszállításhoz!");
                }
            }
            catch (Exception i)
            {
                Console.WriteLine(i.Message);
            }
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;



        case "3":
            Console.WriteLine("");
            Console.Write("Mennyi üzemanyagot tankol?: ");
            double mennyiseg = double.Parse(Console.ReadLine());
            try
            {
                auto.Tankol(mennyiseg);
                Console.WriteLine("Tankolás sikeres!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("");
            Console.WriteLine($"Az üzemanyag szintje jelenleg: {auto.UzemanyagSzint}L ({Math.Round((auto.UzemanyagSzint / 50) * 100, 1)}%)");
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("");
            Console.Write("Adja meg a nevét: ");
            string nev = Console.ReadLine();
            loggedInFutar = new Futar(nev);
            Console.WriteLine("Bejelentkezett!");
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;

        case "6":
            string adat = loggedInFutar.FutarNev; 
            Console.WriteLine("");
            if (adat != null)
            {
                Console.WriteLine($"{adat} vezeti jelenleg a futárautót.");
            }
            else
            {
                Console.WriteLine("Jelenleg nincs bejelentkezve senki.");
            }
            Console.WriteLine("Tovább...");
            Console.ReadLine();
            break;

        case "0":
            Console.WriteLine("");
            Console.WriteLine("Tovább...");
            return;

        default:
            Console.WriteLine("Érvénytelen opció!");
            break;
    }
}
