using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E004_1_Exercise.src;

namespace E004_1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            String s = Console.ReadLine();
            if (s.Length > 0)
            {
                char c = s[0]; 
                if (Vowel.IsVowel(c))
                { 
                    Console.WriteLine(c + " is a vowel");
                }
                else
                {
                    Console.WriteLine(c + " is a NOT vowel");
                }
            }else
            {
                Console.WriteLine("nothing is entered");
            }

            //Select this exercise as the startup project
            //press CTRL-F5 to run the program
        }
    }
}
