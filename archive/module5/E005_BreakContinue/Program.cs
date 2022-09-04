using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E005_BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    System.Console.WriteLine("    continue " + i);
                    continue;  //skip this iteration   
                }

                if (i == 8)
                {
                    System.Console.WriteLine("    break " + i);
                    break;  //exit the for loop
                }
                System.Console.WriteLine("value is " + i);
            }
            System.Console.ReadLine();
        }
    }
}
