using System;
using System.IO;

namespace Ukol8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";
            int num = 1;
            do
            {
                Console.WriteLine("Enter number: ");
                int.TryParse(Console.ReadLine(), out num);
                StreamWriter w = new StreamWriter(path, true);
                {
                    w.WriteLine(num);
                    w.Close();
                }
            }while(num != 0);
        } 
    }
}   
