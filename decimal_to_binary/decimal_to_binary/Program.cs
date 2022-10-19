using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte decimalni cislo: ");
            int dec = int.Parse(Console.ReadLine());
            string bin = "";

            do
            {
                int tmp = dec % 2;
                bin = tmp + bin;

                dec -= tmp;
                dec = dec / 2;
            } while (dec >= 1);

            Console.WriteLine(bin);
            Console.ReadKey();
        }
    }
}
