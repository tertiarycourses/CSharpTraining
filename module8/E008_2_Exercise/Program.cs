using System; 

using E008_2_Solution.src;

namespace E008_2_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create a CalculatorUtility class with 
            // Add, Subtract, Multiply and Divide methods
            // these methods take in 2 double parameters
            // and return a double result
            CalculatorUtility cal = new CalculatorUtility();

            bool exitApp = false;

            String prompt = "\nEnter Operations:\n" +
                "(A)dd\n" +
                "(S)ubtract\n" +
                "(M)ultiply\n" +
                "(D)ivide\n" +
                "(E)xit\n";

            do
            {
                char c = GetChar(prompt);
                if (c != 'E')
                { 
                    double number1 = GetDouble("Enter a number: ");
                    double number2 = GetDouble("Enter another number: ");
                    double result;
                    switch (c)
                    {
                        case 'A':
                            result = cal.Add(number1, number2);
                            PrintResult(number1, number2, "+", result);
                            break;
                        
                            // do the same for -, *, / operations

                        case 'E':
                            exitApp = true;
                            break;
                    }
                }

            } while (!exitApp);
        }

        private static void PrintResult(double number1, double number2, string o, double result)
        {
            Console.WriteLine("\n{0} {2} {1} = {3}\n", number1, number2, o, result);
        }

        private static double GetDouble(string prompt)
        {
            double result = 0;

            // retrieve an input from Console,
            // convert to double (check validity)
            // save the value into double and returns it

            return result;
        }

        private static char GetChar(string prompt)
        {
            char result;
            bool resultOk = false;
            do
            {
                Console.WriteLine(prompt);
                if (char.TryParse(Console.ReadLine().ToUpper(), out result))
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

