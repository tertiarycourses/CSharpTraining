using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E009_1_Exercise.src
{
    class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return base.GetType().Name+": I am " + name;
        }
    }
}
