
using System; 

namespace E004_2_Solution
{
    class Program
    {
        int val1;
        int val2;

        private int ReadInteger(string prompt)
        {
            //show the prompt
            Console.Write(prompt);
            // read in the console input using Console.ReadLine()
            String s = Console.ReadLine();

            //and then convert to a integer value
            //Convert.ToInt32(string)
            int returnValue;
            returnValue = Convert.ToInt32(s);
            return returnValue;
        }
        

        static void Main(string[] args)
        {
            Program p = new Program();

            //read and set the value for p.val1
            p.val1 = p.ReadInteger("Enter a number: ");

            //read and set the value for p.val2
            p.val2 = p.ReadInteger("Enter another number: ");
            
            //try changing to ReadIntegerWithErrorChecking to make the codes more robust
            //p.val1 = p.ReadIntegerWithErrorChecking("Enter a number: ");
            //p.val2 = p.ReadIntegerWithErrorChecking("Enter another number: ");

            //print out the sum of both the numbers
            int sum;
            sum = p.val1 + p.val2;
            Console.WriteLine("The sum of {0} and {1} is {2}",
                p.val1, p.val2, sum);
        }

        private int ReadIntegerWithErrorChecking(string prompt)
        {
            int returnValue;
            do
            {
                Console.Write(prompt); 

                //keep repeating if tryParse fails (return false)
            } while (!int.TryParse(Console.ReadLine(), out returnValue));
            return returnValue;
        }
    }
}
