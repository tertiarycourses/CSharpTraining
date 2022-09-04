using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E009_1_Exercise.src
{
    class Employee : Person
    {
        String employeeId;

        public Employee(string name, string employeeId) : base(name) 
        {
            this.employeeId = employeeId;
        }


        public override string ToString()
        {
            return base.ToString() + ". My EmployeeId =" + employeeId;
        }
    }
}
