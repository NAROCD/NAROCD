using System;
using System.IO;
using System.Linq;

namespace Ukol9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";

            int sum = File.ReadAllLines(path).Sum(x => int.Parse(x));
            Console.WriteLine(sum);

            double avg = File.ReadAllLines(path).Average(y => double.Parse(y));
            Console.WriteLine(avg);
        }
    }
}
