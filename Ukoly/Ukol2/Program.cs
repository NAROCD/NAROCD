using System;
using System.IO;

namespace Ukol2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter("cisla.txt"))
            {
                int[] cisla = new int[10];
                for(int i = 0; i < cisla.Length; i++)
                {
                    Console.WriteLine("Napis cislo: ");
                    int tmp;
                    int.TryParse(Console.ReadLine(), out tmp);
                    cisla[i] = tmp;
                    if(cisla[i] >= 0)
                    {
                        w.WriteLine(cisla[i]);
                    }
                } 
            }

        }
    }
}
