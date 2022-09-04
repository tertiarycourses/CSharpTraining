using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E005_1_Solution
{
    class Program
    { 
        private static int ReadInteger(string prompt)
        {
            //show the prompt
            Console.Write(prompt);
            // read in the console input using Console.ReadLine()
            String s;
            s = Console.ReadLine();

            //and then convert to a integer value
            //Convert.ToInt32(string)
            int returnValue;
            returnValue = Convert.ToInt32(s);
            return returnValue;
        }

        //checks if the input is Even or Odd
        static void Main(string[] args)
        {
            int myValue = ReadInteger("Enter a number: ");
            //ReadIntegerWithErrorChecking try using this for more robust input

            //check if this number is Odd or Even?
            // use the remainder operator ( a % b = ?)
            bool isEven;
            // all numbers when divided by 2 has zero remainder are EVEN
            isEven = myValue % 2 == 0 ;

            if (isEven)
            {
                Console.WriteLine(myValue + " is EVEN");
            }
            else
            {
                Console.WriteLine(myValue + " is ODD");
            }

        }

           
        private static int ReadIntegerWithErrorChecking(string prompt)
        {
            int returnValue;
            do
            {
                Console.Write(prompt);

                //keep repeating if tryParse fails (return false)
            } while (!int.TryParse(Console.ReadLine(), out returnValue));
            return returnValue;
        } 
    }
}
