using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E005_4_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            double num1 = ReadDoubleWithErrorChecking("Enter 1st Number: ");
            double num2 = ReadDoubleWithErrorChecking("Enter 2nd Number: ");

            String prompt = "Enter Operator: (M)ultiply, (D)ivide, (S)ubtract, (A)dd: ");
            //query for the M, D, S or A (refer to the Vowels example)

            //call the different operations based on user input 

            //press CTRL F5 to run the program
        }


        private static double Add(double double1, double double2)
        {
            return /*enter codes here*/;
        }
        //
        // repeat for - * and /
        //

        private static int ReadDoubleWithErrorChecking(string prompt)
        {
            int returnValue;
            do
            {
                Console.Write(prompt);

                //keep repeating if tryParse fails (return false)
            } while (!double.TryParse(Console.ReadLine(), out returnValue));
            return returnValue;
        }
    }
}
