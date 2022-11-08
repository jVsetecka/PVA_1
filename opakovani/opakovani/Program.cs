using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovani
{
    class Program
    {
        static void Main(string[] args)
        {
            string vstup = "0";
            long cislo = 0;
            bool spusteno = true;
            while (spusteno)
            {
                vstup = Console.ReadLine();
                if(vstup != "n")
                {
                    cislo = long.Parse(vstup);

                    for (int i = 0; i < cislo; i++)
                    {
                        Console.WriteLine("Cyklus: " + i);
                    }
                }
                else if(vstup == "n")
                {
                    spusteno = false;
                }
                else
                {
                    Console.WriteLine("spatny vstup");
                }
            }
        }
    }
}
