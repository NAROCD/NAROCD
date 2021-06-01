using System;
using System.IO;

namespace Ukol3
{
    class Program
    {
        static void Main(string[] args)
        {           
            using (StreamWriter w = new StreamWriter("nasobky.txt"))
            {
                
                    Console.WriteLine("Zadej cislo od 1 do 10: ");
                    int range;
                    int.TryParse(Console.ReadLine(), out range);
                    if (range >= 1  && range <=10)
                    {                      
                        int i = 1;
                        while (i <=10)
                        {
                            int res;                            
                            res = range * i;
                            w.WriteLine(res);
                            i++;
                        }                                                                                                                                                                                                                                                                                 
                    }
                    else
                    {
                         Console.WriteLine("Chyba. Zadané číslo není v rozsahu");
                         return;
                    }            
            }
        }       
    }
}
