using System; 

namespace E005_1_Exercise
{
    class Program
    {
        private static int ReadInteger(string prompt)
        {
            //show the prompt
            Console.Write(prompt);
            // read in the console input using Console.ReadLine()
            String s;
            //s = /* how to read from console ?*/

            //and then convert to a integer value
            //Convert.ToInt32(string)
            int returnValue;
            // returnValue = /*try converting the String s*/
            return returnValue;
        }

        //checks if the input is Even or Odd
        static void Main(string[] args)
        {
            int myValue = ReadInteger("Enter a number: ");

            //check if this number is Odd or Even?
            // use the remainder operator ( a % b = ?)
            bool isEven;
            isEven = /* how do we check for even or odd? */ ;

            if (isEven)
            {
                Console.WriteLine(myValue + " is EVEN");
            }
            else
            {
                Console.WriteLine(myValue + " is ODD");
            }

        }

        /*    
        private static int ReadIntegerWithErrorChecking(string prompt)
        {
            int returnValue;
            do
            {
                Console.Write(prompt);

                //keep repeating if tryParse fails (return false)
            } while (!int.TryParse(Console.ReadLine(), out returnValue));
            return returnValue;
        }*/
    }
}
