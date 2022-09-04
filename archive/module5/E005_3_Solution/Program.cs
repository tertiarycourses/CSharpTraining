using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E005_3_Solution
{
    class Program
    {
        //use a for loop recursively
        static void Main(string[] args)
        {
            int maxNumberOfTimes = 5;

            for (int i = 1; i <= maxNumberOfTimes; i++) // the outer loop
            {
                for (int j = 1; j <= maxNumberOfTimes; j++) // the inner loop
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }

            Console.ReadLine(); 
            Console.WriteLine("\nthis is how it looks like internally\n");

            for (int i = 1; i <= maxNumberOfTimes; i++) // the outer loop
            {
                Console.WriteLine("\ninside i loop: value =" + i );
                for (int j = 1; j <= maxNumberOfTimes; j++) // the inner loop
                {
                    Console.WriteLine("    in j loop: value =" + j);
                }

                Console.WriteLine("    exiting i loop: "+ i);
            }

            Console.ReadLine();

        }
    }
}
