using System;

namespace ppp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uloha 3

            string vstup = Console.ReadLine();
            string[] pole = { "Jaguar", "Unique", "Pagani", "Campagna", "Alfa Romeo", "Elfin", "Ferrari", "NIE", "Volkswagen", "Suzuki", "Audi", "Opel", "Volvo", "Mitsubishi", "Lobini", "Maserati", "Callaway", "Seat", "Gumpert", "Chevrolet", "ChryslerLotus" };

            // seradi pole podle abecedy
            Array.Sort(pole);

            foreach (string name in pole)
            {
                if (vstup.ToLower() == name.ToLower())
                {
                    Console.WriteLine("znacka " + name + " nalezena");
                    Console.ReadKey();
                    return;   // ukonci program pokud byl nalezen vstup v poli
                }
            }

            // --------Provede se pouze pokud vstup nebyl nalezen v poli--------

            Console.WriteLine("znacka " + vstup + " NEBYLA nalezena\n");
            Console.WriteLine("---------Vypis---------");
            foreach (string name in pole)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

            /*
            Uloha 2
             
            Console.Write("Zadejte pocet cisel: ");
            int pocet = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            
            Console.WriteLine("Zadejte " + pocet + " cisel: ");

            int[] pole = new int[pocet];

            for (int i = 0; i < pocet; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nVypis:");

            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
                if (max < pole[i])
                {
                    max = pole[i];
                }
            }
            Console.WriteLine("\nMax: " + max);
            Console.ReadKey();
           */


            /*
            Uloha 1

            int[] pole = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Delka pole: " + pole.Length);
            Console.WriteLine(pole[0]);
            Console.WriteLine(pole[pole.Length - 1]);

            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.ReadKey();
            */


        }
    }
}
