using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E010_2_Exercise.src
{
    class CalculatorUtility
    {
        //add the calculator utility class here
        public static double Add(double num1, double num2)
        { return num1 + num2; }
        public static double Minus(double num1, double num2)
        { return num1 - num2; }
        public static double Multiply(double num1, double num2)
        { return num1 * num2; }
        public static double Divide(double num1, double num2)
        { return num1 / num2; }
         
        public static double Evaluate(char ops, double num1, double num2)
        {
            switch (ops)
            {
                case '+': return Add(num1, num2);
                case '-': return Minus(num1, num2);
                case '*': return Multiply(num1, num2);
                case 'x': return Multiply(num1, num2);
                case '/':return Divide(num1, num2);
            }
            return Double.NaN;
        }
    }
}
