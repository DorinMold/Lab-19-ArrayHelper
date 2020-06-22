using System;
using System.Collections.Generic;

namespace Lab_19_ArrayHelper
{
    public delegate T[] AdunareSiruriEgale<T>(T[] SirUnu, T[] SirDoi);

    class Program
    {
        
        static void Main(string[] args)
        {
            int[] SirUnu = new int[] { 7, 15, 12, 30 };
            int[] SirDoi = new int[] { 27, 4, 44, 17 };
            int[] Rezultat = new int[4];
            int x = 0;
      
            ArrayHelper<int> Colectie = new ArrayHelper<int>(40, 18, 25, 10, 30, 28);
            AdunareSiruriEgale<int> AdunareSiruri = Colectie.AdunareDouaSiruri;
            Rezultat = AdunareSiruri(SirUnu, SirDoi);

            foreach (int i in Rezultat )
            {
                //Se afiseaza rezultatul adunarii celor doua colectii de 4 elemente
                Console.WriteLine($"Adunare doua siruri, elementul {x + 1}: {i.ToString()}");
                x++;
            }
           // Colectie.Finder(25);

            Predicate<int>FinderItemFirst = Colectie.Finder;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Elementul este gasit in sir: " + (FinderItemFirst.Invoke(25) ? "DA" : "NU"));
            Func<int, string, dynamic> FinderItemSecond = Colectie.Finder;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Indexul elementului gasit in sir: " + FinderItemSecond.Invoke(25, "index"));
            Func<int, string, dynamic> FinderItemThird = Colectie.Finder;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Elementul propriu zis gasit in sir: " + FinderItemThird.Invoke(25, "element"));
        }
    }
}
