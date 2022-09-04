using System;
using E003_1_Exercise.src;

namespace E003_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //populate the dimensions of Box
            box.lengthCm = 10;
            box.widthCm = 20;
            box.heightCm = 30;

            Console.WriteLine("The box's volume is: " + box.GetVolume() + " cm³");

            //Select this exercise as the startup project
            //press CTRL-F5 to run the program
        }
    }
}
