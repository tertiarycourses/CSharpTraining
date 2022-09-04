using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_1_Solution
{
    class Program
    {
        //array manipulation
        static void Main(string[] args)
        {
            Print("Enter 5 Integers");
            int num1 = GetInteger("Enter 1st Integer: ");
            int num2 = GetInteger("Enter 2nd Integer: ");
            int num3 = GetInteger("Enter 3rd Integer: ");
            int num4 = GetInteger("Enter 4th Integer: ");
            int num5 = GetInteger("Enter 5th Integer: ");

            //let's create an array of these 5 integers
            int[] intArray; //we first define the array (currently it is pointing to null)
            intArray = new int[5]; //then we allocate the space for the array

            //then we populate the array.
            intArray[0] = num1; //remember that arrays start from 0
            intArray[1] = num2;  
            intArray[2] = num3;  
            intArray[3] = num4;  
            intArray[4] = num5;

            //We can also create the array with the values pre-initialized
            int[] intArrayPreInit1 = { num1, num2, num3, num4, num5 };
            //you need to add "new int[]" if the variable is already defined
            int[] intArrayPreInit2;
            intArrayPreInit2 = new int[] { num1, num2, num3, num4, num5 };

            //let's see what we've got now
            Print("\nOriginal array is : " ,intArray);

            //let's sort the integer from smallest to biggest
            Array.Sort(intArray);
            Print("\nAfter Sorting we get: " ,intArray);

            //now let's arrange from the biggest to the smallest
            Array.Reverse(intArray);
            Print("\nAfter reversing we get: ", intArray);

            ////we can also use the delegate method. 
            //Array.Sort(intArray, delegate(int int1, int int2)
            //{
            //    return int1.CompareTo(int2);
            //});
            ////and lambda expressions
            //Array.Sort(intArray, 
            //    new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            //press CTRL F5 to run the program

        }

        private static void Print(string v, int[] intArray)
        {
            Print(v);
            for(int i = 0; i < intArray.Length; i++){
                Console.Write (" {0}", intArray[i]);
            }
            Console.WriteLine();
        }

        private static void Print(string v)
        {
            Console.WriteLine(v);
        }

        static int GetInteger(String prompt)
        {
            int result = 0;
            bool ok = true;
            do
            {
                //what happens when you enter a non numeric character?
                // - a FormatException is thrown by the system
                //add a try catch here to catch that exception.
                Console.Write(prompt);

                try
                {
                    result = int.Parse(Console.ReadLine());
                    ok = true;

                }
                catch (FormatException e)
                {
                    //when an exception is caught, set ok =false;
                    Console.WriteLine("Invalid input\n");
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
    }
}
