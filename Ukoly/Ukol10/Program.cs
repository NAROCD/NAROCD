using System;
using System.IO;
using System.Linq;

namespace Ukol10
{
    class Program
    {
        // Narovec, Good, Černý, Le The Son, Trubička
        static void Main(string[] args)
        {
            //Path to file
            string path  = "input.txt";
            //Check if file exists if not create new one
            if(!File.Exists(path))
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    //If text wouldn't be trimmed the input file would contain one more line.
                   w.Write("Nor hence hoped her after other known defer his. For county now sister engage had season better had waited. Occasional mrs interested far expression acceptance.");
                    Console.WriteLine("Creating file");
                }
            }
            else
            {
                //Read the whole file
                string Text = File.ReadAllText(path);
                //Display entry file content
                Console.WriteLine("Entry text: "+ Text);
                //Count all the chars
                Console.WriteLine("Character count with spaces: " + Text.Length);
                /*Count all the chars without spaces
                String.Concat() concatenates one or more instances of String, or the String representations of the values of one or more instances of Object.
                Where() specifies what to select in this case c should not contain white spaces.
                => (lambda expression) */
                Console.WriteLine("Character count without white spaces: " + String.Concat(Text.Where(c => !Char.IsWhiteSpace(c))).Length);
                //Count all the sentences
                Console.WriteLine("Sentence count: " + Text.Split(". ").Length);
                //Count all the words
                Console.WriteLine("Words count: "+Text.Split(" ").Length);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}