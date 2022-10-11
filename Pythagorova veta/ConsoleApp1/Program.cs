using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > c)
            {
                int tmp = c;
                c = a;
                a = tmp;
            }
            if (b > c)
            {
                int tmp = c;
                c = b;
                b = tmp;
            }
            
            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Je pravouhly\n");
            }
            else
            {
                Console.WriteLine("Neni pravouhly\n");
            }


            Console.ReadKey();
        }
    }
}
