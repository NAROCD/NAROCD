using System.IO;
using System;

namespace Ukol6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "vstup2.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    w.WriteLine("Spolecnost: ABC a.s. ,");
                    w.WriteLine("ICO: 12345678,");                  
                    w.WriteLine("se sidlem: Moskevska, Praha 10");
                }
                Console.WriteLine("Soubor nenalezen vytvářím...");
            }
            else
            {               
                string[] tokens = File.ReadAllLines(path);
                foreach(string line in tokens)
                {
                    Console.Write(line + " ");
                }
            }
        }
    }
}
