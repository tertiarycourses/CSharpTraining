using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E008_1_Solution.src
{
    class Vegetable
    { 
        String name;
        double weightGrams;
        int quantity;

        public Vegetable(string name, double weightGrams, int quantity)
        {
            this.name = name;
            this.weightGrams = weightGrams;
            this.quantity = quantity;
        }

        public double ComputeTotalWeight()
        {
            return weightGrams * quantity;
        }
        public override string ToString()
        {
            return name + "(a type of " + base.GetType().Name + "), "
                + weightGrams + "g x "
                + quantity + " = " + ComputeTotalWeight() +"g";
        }
    }
}
