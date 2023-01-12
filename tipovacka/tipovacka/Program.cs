using System;
using System.Collections.Generic;
using System.Linq;

Random rand = new Random();
int[] cisla = new int[32];

for (int i = 0; i < 32; i++)
    cisla[i] = rand.Next(1, 101);
          
Console.WriteLine("Je 32 vygenerovanych cisel 1-100, vylosuj 6 stastnych cisel a vyhraj 326 milionu\n----------------------------");
while (true)
{
    string vstup = Console.ReadLine();
    List<string> temp = vstup.Split(' ').ToList();
    List<int> uzivatelCisla = new List<int>();

    bool flag = false;
    foreach (string s in temp)
    {
        int cislo;
        if (!int.TryParse(s, out cislo))
        {
            Console.WriteLine("Nespravny vstup, zadejte znovu");
            flag = true;
            break;
        }
        if (cislo > 100 || cislo < 1)
        {
            Console.WriteLine("Nespravny vstup, zadejte znovu");
            flag = true;
            break;
        }

        uzivatelCisla.Add(cislo);
    }
    if (flag)
        continue;
               
    uzivatelCisla = uzivatelCisla.Distinct().ToList();
    if (uzivatelCisla.Count < 6)
    {
        Console.WriteLine("Nespravny vstup, zadejte znovu");
        continue;
    }
    uzivatelCisla = uzivatelCisla.Intersect(cisla).ToList();

    if (uzivatelCisla.Count >= 1)
    {
        Console.Write("Vyherni cisla: ");
        foreach (int i in uzivatelCisla)
        {
            Console.Write(i + " ");
        }
    }
    else
    {
        Console.WriteLine("Thats not W for you");
    }
    break;
}

Console.ReadKey();

