using System;
using System.IO;

namespace Ukol5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "vstup1.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    w.WriteLine("Ahoj jak se máš?");                   
                    Console.WriteLine("Soubor nenalezen vytvářím...");
                }
            }
            else
            {
                string text = File.ReadAllText(path);

                Console.WriteLine(text);
            }
        }
    }
}
