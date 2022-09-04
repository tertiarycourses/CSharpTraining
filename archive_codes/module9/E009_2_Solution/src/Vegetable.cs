using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E009_2_Solution.src
{
    //create a class Vegetable that inherits Food
    class Vegetable : Food
    {
        public Vegetable(string name, double weightGrams, int quantity) : base(name, weightGrams, quantity)
        {
        }
    }

}
