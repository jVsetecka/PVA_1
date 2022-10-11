using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pocet = int.Parse(Console.ReadLine());
            int max = -1, min = Int32.MaxValue, soucet = 0;

            Console.WriteLine();

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Číslo: " + (i+1));
                int vstup = int.Parse(Console.ReadLine());

                soucet += vstup;
                if (vstup > max)
                {
                    max = vstup;
                }
                if (vstup < min)
                {
                    min = vstup;
                }
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Prumer: " + (soucet / pocet));

            Console.ReadKey();
          
        }
    }
}
