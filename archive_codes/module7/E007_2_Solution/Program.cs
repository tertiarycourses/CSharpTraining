using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_2_Solution
{

    class Program
    {
        //Previously we looked at int[] arrays
        //now we look at a Collection class List<> 
        //int[] is fixed sized, but the size in List<> can grow.
        static void Main(string[] args)
        {
            List<int> intArray = new List<int> { 2, 4, 5 };
            Print("Initial list: ", intArray);
            //now: add 1, and 3 such that the list is now 1,2,3,4,5
            //intArray.Add( value) will append 'value' to the end of the list 
            //intArray.Insert( n, value) will append 'value' to nth position 
            intArray.Insert(0, 1);
            Print("After adding '1': ", intArray);
            intArray.Insert(2, 3);
            Print("After adding '3': ", intArray);

            //let's change 5 to 7
            intArray[4] = 7;
            Print("After replacing '5' with '7': ", intArray);

            //and finally we reverse the list. 
            intArray.Reverse();
            Print("After reversing the array: ", intArray);
        }

        private static void Print(string v, List<int> intArray)
        {
            Console.WriteLine(v);
            //how do we loop through a List?
            // we use the foreach loop
            Console.WriteLine("there are {0} items in the list.", intArray.Count());

            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            ////we can also iterate though using the for loop
            //for (int i =0; i< intArray.Count(); i++)
            //{

            //}
        }
    }
}
