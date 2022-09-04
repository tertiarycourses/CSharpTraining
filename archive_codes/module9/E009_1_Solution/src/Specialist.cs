using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E009_1_Exercise.src
{ 
    class Specialist : Employee
    {
        String skillset;

        public Specialist(string name,
            string employeeId, string skillset) : base(name, employeeId)
        {
            this.skillset = skillset;
        }

        public String DisplaySkill()
        {
            return "I specialise in " + skillset;
        }

        public override string ToString()
        {
            return base.ToString() + ". " + DisplaySkill();
        }

    }
}