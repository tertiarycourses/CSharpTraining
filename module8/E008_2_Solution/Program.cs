using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E008_2_Solution.src;

namespace E008_2_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitApp = false;

            String prompt = "\nEnter Operations:\n" +
                "(A)dd\n" +
                "(S)ubtract\n" +
                "(M)ultiply\n" +
                "(D)ivide\n" +
                "(E)xit\n";

            do
            {
                double number1 = GetDouble("Enter a number: ");
                double number2 = GetDouble("Enter another number: ");
                double result;
                char c = GetChar(prompt);
                switch (c)
                {
                    case 'A':
                        result = CalculatorUtility.Add(number1, number2);
                        PrintResult(number1, number2, " + ",result);
                            break; 
                    case 'S': 
                        result = CalculatorUtility.Minus(number1, number2);
                        PrintResult(number1, number2, " - ",result);
                           break;
                    case 'M': 
                        result = CalculatorUtility.Multiply(number1, number2);
                        PrintResult(number1, number2, " x ",result);
                           break;
                    case 'D':
                        result = CalculatorUtility.Divide(number1, number2);
                        PrintResult(number1, number2, " / ", result);
                        break;
                    case 'E':
                        exitApp = true;
                        break;

                }

            } while (!exitApp);
        }

        private static void PrintResult(double number1, double number2, string o, double result)
        {
            Console.WriteLine("\n{0}{2}{1} = {3}\n", number1, number2, o, result);
        }

        private static double GetDouble(string v)
        {
            double result = 0;
            do
            {
                Console.WriteLine(v);
            } while (
                !double.TryParse(Console.ReadLine(),
                    out result));
            return result;
        }

        private static char GetChar(string prompt)
        {
            char result ;
            bool resultOk = false;
            do
            {
                Console.WriteLine(prompt);
                if(char.TryParse(Console.ReadLine().ToUpper(), out result))
                {
                    resultOk = result == 'A'
                       || result == 'S'
                        || result == 'M'
                        || result == 'D'
                        || result == 'E';  
                }
            } while (!resultOk);

            return result;
        }
    }
}
