using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E009_2_Solution.src;

namespace E009_2_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //remember previously in 8.1, we declared 2 lists ?
            // one for fruits and one for Vegetables?
            // now just create one list for both fruits and vegetables
            List<Food> list = new List<Food>();

            // create some fruit objects in this list.
            list.Add(new Fruit("Apple", 100, 25));
            list.Add(new Fruit("Pear", 150, 2));

            // create some vegetable objects in this list.
            list.Add(new Vegetable("Brocolli", 20, 100));
            list.Add(new Vegetable("Capsicans", 12, 30));

            // loop through the list now. 
            Console.WriteLine("There are {0} items in the list", list.Count());
            foreach(Food f in list)
            {
                Console.WriteLine(f.ToString());  
            }

            //Press Ctrl F5 to run the app
        }
    }
}
