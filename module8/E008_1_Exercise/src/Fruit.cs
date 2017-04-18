using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E008_1_Solution.src
{
    class Fruit
    {
        String name;
        double weightGrams;
        int quantity;

        public Fruit(string name, double weightGrams, int quantity)
        {
            this.name = name;
            this.weightGrams = weightGrams;
            this.quantity = quantity;
        }

        // create a method called ComputeTotalWeight()
        // which returns the total weight of the item
        // weightGrams x quantity
         

        //how do we override ToString ?
        // we use the "override" keyword
        //try typing "override" followed by tab.
    }
}

