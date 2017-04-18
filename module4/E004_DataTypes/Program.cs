
/*
 This is a commented 
 block of text
 */

//used to access Console() class
//serves as a short cut instead of writing System.Console EVERY TIME
using System; //semi colon ';' denotes end of instruction
using static System.Console; // defining this removes the need to type Console.WriteLine EVERYTIME

  
//This is a commented line
//The compiler usually ignores comments 

//a space to prevent class name collisions (especially for big projects)
namespace E004_DataTypes
{ //codes are boxed inside curly brackets

    //A class is a compound data type ('struct' is another compound value type)
    /**
     * This class demonstrates the C# syntax
     * 
     * We put a header comment here to let others know what the class is about
     * as well as other info like the creator, creation date, etc
     * 
     * Created by : Angel Koh
     * Date created : 12 April 2017 
     */
    class Program
    {
        //the following are the different value types
        //defined as a field inside the class "Program" 
        //'=' is to assign a value to the field (variable).
        //https://msdn.microsoft.com/en-us/library/ya5y69ds.aspx


        bool bl = true; //1 bit (true or false)
        char c = 'a'; //1 byte (-128 t 127) 'a' is an ASCII representation of the number 97
        byte b = 255; //1 byte (0 to 255) also 1 byte = 8bits
        short s = -1; //2 bytes (positive and negative)
        ushort us = 1; //2 bytes (only positive) 
        int i = 1_000_000; //4 bytes (you can also use '_' to make your values more readable
        long l = 1; //4 or 8 byte (depending if 32bit compiler or 64bit compiler)
        float f = 1.0f; //2 bytes with decimal places
        double d = 1.0; //4 bytes with decimal places
        string str = "this is a string";

        int undefined; //uninitialised int defaults to 0 (https://msdn.microsoft.com/en-us/library/83fhsxwc.aspx)

        //this is a declaration of an enumeration
        enum dayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday };
        dayOfWeek dow = dayOfWeek.Friday; //and here's how we use it.

        /// <summary>
        /// this is a method call that does nothing
        /// typing 3/// generates a comment block automatically 
        /// </summary>
        void MyMethodThatDoesNothing()
        {

            //remember "Console.WriteLine("Hello World");"? 
            // that method takes in "Hello World" text and display it on console.
            // it does something useful, unlike this method
        }

        /// <summary>
        /// This method takes in 2 parameters, and return 1 parameters
        /// 
        /// </summary>
        /// <param name="input1">say something about input1</param>
        /// <param name="input2">and something about input2</param>
        /// <returns> the calculated results</returns>
        int MethodThatDemoArithmatics(double input1, double input2)
        {
            //results is a variable that is only accessable in this method, 
            //unlike the other variables defined above.
            double results;
            results = input1 + (input2 * input1 / input2) - input2;

            //casting from double to integer  
            //removes the decimal place, making it less accurate
            //hence compiler need to know that this is delibrate  
            return (int)results;
            //the other way is implicit, we do not need to do casting
            //short -> int is also implicit (int can hold more than short)
        }

        /// <summary>
        /// this method talks about what is an array, 
        /// and how to use them
        /// </summary>
        void TalkAboutArrays()
        {
            //arrays are denoted by square brackets
            int[] x;
            x = new int[3]; //allocate space for 3 integers

            WriteLine("the size of x is " + x.Length);

            //populate x (don't have to be in order)
            x[0] = 99; //note [0] populates the first integer
            x[2] = 88;
            x[1] = 77;

            int secondValue = x[1]; //1 because we always start counting from ZERO 
            WriteLine("the first value is: " + x[0]);
            WriteLine("the second value is: " + secondValue);

            //can also prepopulate an an array this way
            int[] y = { 77, 88_000, 99 };
        }

        //static is a reserved keyword
        // the Main() method already exists when the program starts
        static void Main()
        {
            Console.WriteLine("Hello World!");

            //this is how to instantiate a class.
            Program aClassInstance;
            aClassInstance = new Program();

            //this is how to call the method of a class
            aClassInstance.MyMethodThatDoesNothing();

            Console.WriteLine("Maths = " + aClassInstance.MethodThatDemoArithmatics(1, 2));

            aClassInstance.TalkAboutArrays();

            Console.Read();
        }

        //This is a property
        //it allows other classes to view/get the property (public)
        //but private in set, prevents other classes from changing it.
        public int MyIntProperty
        {
            get;
            private set;
        }
    }
}
