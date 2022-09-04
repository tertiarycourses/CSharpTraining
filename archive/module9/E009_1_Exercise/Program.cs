using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E009_1_Exercise.src;

namespace E009_1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person("Mary");
            Console.WriteLine(personA.ToString());

            Person personB = new Specialist(/*create a new specialist and assign it to a Person class*/);
            Console.WriteLine(personB.ToString());

            //what happens when we try to use personB.DisplaySkill() ?
            //Console.WriteLine(personB.DisplaySkill());

            Specialist specialistA = new Specialist(/*create a new specialist, we assign it to a specialist Class*/);
            Console.WriteLine(specialistA.ToString());
            //notice that DisplaySkill method is now available
            //Console.WriteLine(specialistA.DisplaySkill());

            //back to personB, we now tell the app that personB is a specialist
            //Specialist specialistB = (Specialist)personB;
            //now we can display B's skills
            //Console.WriteLine(specialistB.DisplaySkill());

            //what happens when we try to cast a non-specialist as a specialist?
            // Specialist fakeSpecialistA = (Specialist)personA;
            // we get an InvalidCastException!

            //IS-A vs HAS-A concept. 
            //Consider a case for a vehicle.
            // vehicles we can have classes for 
            //  engine, brand, model, car, boat, Toyota, 
            //  planes, boeing, lorries, etc
            // 
            //  so which class should inherit Vehicle ?
            //  which class should be a member of the class instead?
            //  which one should be an instance of the class?
            // 



        }
    }
}
