using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E006_1_Exercise
{
    class Program
    { 

        // Try and Catch Exercise
        // Using Try-Catch to prevent system crashes
        static void Main(string[] args)
        { 
           int num1 = GetInteger("Enter a number: ");
           int num2 = GetInteger("Enter another number: ");

            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            //what happens when num2 is zero?? 
            //a DivideByZero Exception is thrown
            //try fixing it with a try catch.

            //press F5 to debug the program
        
        }

        static int GetInteger(String prompt)
        {
            int result =0;
            bool ok ;
            do
            {
                //what happens when you enter a non numeric character?
                // - a FormatException is thrown by the system
                //add a try catch here to catch that exception.
                Console.Write(prompt);
                result = int.Parse(Console.ReadLine());
                ok = true;

                //when an exception is caught, set ok =false;
            }
            while (!ok);
            return result;
        }
    }
}
