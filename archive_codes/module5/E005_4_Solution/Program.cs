using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E005_4_Solution
{
    class Program
    {

        static void Main(string[] args)
        {
            double num1 = ReadDoubleWithErrorChecking("Enter 1st Number: ");
            double num2 = ReadDoubleWithErrorChecking("Enter 2nd Number: ");

            String prompt = "Enter Operator: (M)ultiply, (D)ivide, (S)ubtract, (A)dd: ";
            //query for the M, D, S or A (refer to the Vowels example)
            char c;
            do
            {
                Console.WriteLine(prompt);
            } while (!char.TryParse(Console.ReadLine(), out c));

            //call the different operations
            switch (c)
            {
                case 'a': case 'A': Console.WriteLine(num1 + "+" + num2 + " = " + Add(num1, num2)); break;
                case 'S': case 's': Console.WriteLine(num1 + "-" + num2 + " = " + Minus(num1, num2)); break;
                case 'D': case 'd': Console.WriteLine(num1 + "/" + num2 + " = " + Divide(num1, num2)); break;
                case 'M': case 'm': Console.WriteLine(num1 + "*" + num2 + " = " + Multiply(num1, num2)); break; 
            }

            //press CTRL F5
        }


        private static double Add(double double1, double double2)
        {
            return double1 + double2;
        }
        private static double Minus(double double1, double double2)
        {
            return double1 - double2;
        }
        private static double Divide(double double1, double double2)
        {
            return double1 / double2;
        }
        private static double Multiply(double double1, double double2)
        {
            return double1 * double2;
        }

        private static double  ReadDoubleWithErrorChecking(string prompt)
        {
            double returnValue;
            do
            {
                Console.Write(prompt);

                //keep repeating if tryParse fails (return false)
            } while (!double.TryParse(Console.ReadLine(), out returnValue));
            return returnValue;
        }
    }
}
