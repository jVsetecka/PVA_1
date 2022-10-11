using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = int.Parse(Console.ReadLine());
            int cislo2 = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            double vysledek = 0;

   
            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
            }
            else if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
            }
            else if (operace == "*")
            {
                vysledek = cislo1 * cislo2;
            }
            else if (operace == "/")
            {
                vysledek = cislo1 / cislo2;
            }
            else if (operace == "%")
            {
                vysledek = cislo1 % cislo2;
            }
            else
            {
                Console.WriteLine("Špatná operace");
            }


            Console.WriteLine("Výsledek: " + vysledek);
            Console.ReadKey();
        }
    }
}
