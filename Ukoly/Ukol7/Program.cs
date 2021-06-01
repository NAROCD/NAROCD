using System;
using System.IO;

namespace Ukol7
{
    class Program
    {
         static void Main(string[] args)
        {
            string path = "A.txt";
            string pathO = "A-vysledek.txt";
            using (StreamReader r = new StreamReader(pathA)) {
                using(StreamWriter w = new StreamWriter(pathO)) 
                {            
                    int a = int.Parse(r.ReadLine());
                    int b = int.Parse(r.ReadLine());
                    int c = int.Parse(r.ReadLine());
                        
                    int V;
                    V = a*b*c;
                    w.WriteLine(V);
                }
            }
        }
    }
}
