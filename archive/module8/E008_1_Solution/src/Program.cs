using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E008_1_Solution.src;

namespace E008_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //create two lists (one for Fruit, another for Vegetable)
            List<Fruit> fruitList = new List<Fruit>();
            List<Vegetable> vegeList = new List<Vegetable>();

            //populate the two lists
            fruitList.Add(new Fruit("Apple", 100, 5));
            //what happens if we add apples again??
            fruitList.Add(new Fruit("Apple", 200, 10)); 
            fruitList.Add(new Fruit("Pear", 300, 5));

            vegeList.Add(new Vegetable("Brocolli", 80, 4));
            vegeList.Add(new Vegetable("Spinach", 10, 40));

            //display the contents of the two lists.
            PrintFruitLoop("Displaying Fruits", fruitList);
            PrintVegeLoop("Displaying Vegetables", vegeList);


            //Press Ctrl F5 to run the program
        }

        private static void PrintFruitLoop(string v, List<Fruit> list)
        {
            Console.WriteLine(v);
            Console.WriteLine("There are {0} items", list.Count());
            foreach (Fruit i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }
        private static void PrintVegeLoop(string v, List<Vegetable> list)
        {
            Console.WriteLine(v);
            Console.WriteLine("There are {0} items", list.Count());
            foreach (Vegetable i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
