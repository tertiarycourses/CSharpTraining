using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_1_Exercise
{
    class Program
    {
        //array manipulation
        static void Main(string[] args)
        {
            Print("Enter 5 Integers");
            int num1 = GetInteger("Enter 1st Integer: ");
            int num2 = GetInteger("Enter 2nd Integer: ");
            int num3 = GetInteger("Enter 3rd Integer: ");
            int num4 = GetInteger("Enter 4th Integer: ");
            int num5 = GetInteger("Enter 5th Integer: ");

            //let's create an array of these 5 integers
            // we want to create an int[] array with a length of 5
            // we also want to initialize this array with values from num1 to num5
            int[] intArray = ??? 
              
            //let's see what we've got now
            Print("\nOriginal array is : ", intArray);

            //let's sort the integer from smallest to biggest
            // now: let's try to do sorting (hint: use Array.Sort)
            Print("\nAfter Sorting we get: ", intArray);
           

            //now let's arrange from the biggest to the smallest
            // now: how do we reverse the sort? (hint: Array.Reverse)
            Print("\nAfter reversing we get: ", intArray);
           

            //press CTRL F5 to run the program

        }

        private static void Print(string v, int[] intArray)
        {
            Print(v);
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(" {0}", intArray[i]);
            }
            Console.WriteLine();
        }

        private static void Print(string v)
        {
            Console.WriteLine(v);
        }

        static int GetInteger(String prompt)
        {
            int result = 0;
            bool ok = true;
            do
            {
                //what happens when you enter a non numeric character?
                // - a FormatException is thrown by the system
                //add a try catch here to catch that exception.
                Console.Write(prompt);

                try
                {
                    result = int.Parse(Console.ReadLine());
                    ok = true;

                }
                catch (FormatException e)
                {
                    //when an exception is caught, set ok =false;
                    Console.WriteLine("Invalid input\n");
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
    }
}
