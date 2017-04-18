using System;

//You need to include the namespace to access the Line class
using E002_LineObjectExample.src;

namespace E002_LineObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(); //new creates a new instance
            line1.lengthCm = 45;

            Line line2 = new Line(); //line2 is not the same as line1
            line2.lengthCm = 50;

            Console.WriteLine("Line 1 is {0}cm, Line 2 is {1}cm.",
                line1.lengthCm, line2.lengthCm);

            // you can also write
            Console.WriteLine("\nLine 1 is " + line1.lengthCm + " + cm," +
                "Line 2 is " + line2.lengthCm + "cm.");

            //but {0} is useful if you want to repeat the value many times
            double square = line1.lengthCm * line1.lengthCm;
            Console.WriteLine("\n {0} * {0} = {1}", line1.lengthCm, square);

            //Select this exercise as the startup project
            //press Ctrl+F5 to run the program
        }
    }
}
