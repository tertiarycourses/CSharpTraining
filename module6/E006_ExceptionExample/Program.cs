using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E006_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOf5 = { 1, 2, 3, 4, 5 };
            //loop 6 times in an array of 5
            for (int i =0; i<6; i++)
            {
                //Index i goes out of bound!
                Console.WriteLine(i + ") " + arrayOf5[i]);
            }

            // we can catch it using
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine("Number = " + arrayOf5[i]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("error  " + i + ", " +
                                                      e.Message);
                }
            }
        }
    }
}
