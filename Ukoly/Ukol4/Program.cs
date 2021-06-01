using System;
using System.IO;

namespace Ukol4
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = null;
            double i;
            int n = 0;
            double sum = 0;
            double avg;
            using (StreamWriter w = new StreamWriter("site.html"))
            {
                Console.WriteLine("Push enter to start");
                Console.WriteLine("To end the app write end at the end of program");
                while (end != "end")
                {
                    Console.Write("Zadej cisla: ");
                    end = Console.ReadLine();
                    if(Double.TryParse(end, out i))
                    {
                        sum = sum + i;
                        n++;
                    }
                }

                avg = sum / n;                
                w.WriteLine("<!DOCTYPE HTML>\n<html><head>");
                w.WriteLine("<title>Summary</title>");
                w.WriteLine("</head><body>");
                w.WriteLine("<h1>Summary</h1>");
                w.WriteLine("<ul>");
                w.WriteLine("<li>Součet je:"+sum+"</li>");
                w.WriteLine("<li>Průměr je:"+avg+"</li>");
                w.WriteLine("<ul>");
                w.WriteLine("</body></html>");            
            }                             
        }
    }
}
