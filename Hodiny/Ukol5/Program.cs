using System;
using System.IO;

namespace Ukol5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader r = new r StreamReader(@"F:\Škola\2020-2021\PGA\Úkoly\Pracesesoubory\Hodiny\Ukol5\text.txt"))
            {
                string line = r.ReadLine();
                string[] tokens = line.Split(' ');

                string CN = tokens[0];
                string CHQ = tokens[1];
                string ICO = tokens[2];

                Console.WriteLine("Společnost: "+CN+", IČO: "+ICO+" ,y se sídlem: "+ CHQ);
            }
            
        }
    }
}
