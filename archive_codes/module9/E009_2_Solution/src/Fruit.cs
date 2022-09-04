using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace E009_2_Solution.src
{

    //create a class Fruit that inherits Food 
    class Fruit : Food
    {
        public Fruit(string name, double weightGrams, int quantity) : base(name, weightGrams, quantity)
        {
        }
    }

}
