using System;
using System.IO;

namespace Ukol1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string surname;            
            using (StreamWriter w = new StreamWriter("zapis.txt"))
            {
                Console.WriteLine("Zadejte křestní jméno: ");
                firstname = Console.ReadLine();

                Console.WriteLine("Zadejte příjmení: ");
                surname = Console.ReadLine();

                w.WriteLine("Křestní jméno: " + firstname + " příjmení: " + surname);
            }
            
            
        }
    }
}
