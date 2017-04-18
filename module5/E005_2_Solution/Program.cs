using System; 

namespace E005_2_Solution
{
    class Program
    {
        //using switch-case
        static void Main(string[] args)
        {
            
            String prompt = "Enter a number between 1 to 7: ";
            int myValue = ReadIntegerWithErrorChecking(prompt);

            //note that [] structures start counting from 0
            //daysOfWeek[0] will return "Monday"
            String[] daysOfWeek = { "Monday", "Tuesday","Wednesday",
                        "Thursday","Friday","Saturday", "Sunday"};
            String day1 = daysOfWeek[0];
            String day2 = daysOfWeek[1];
            String day3 = daysOfWeek[2];
            String day4 = daysOfWeek[3];
            String day5 = daysOfWeek[4];
            String day6 = daysOfWeek[5];
            String day7 = daysOfWeek[6];

            if (myValue > 0 && myValue <= 7)
            {
                //try implementing a switch case here
                //Console.WriteLine(day1); //this prints Monday on the console.

                //how do we use switch case to print out each day?
                switch (myValue)
                {
                    case 1: Console.WriteLine(day1); break;
                    case 2: Console.WriteLine(day2); break;
                    case 3: Console.WriteLine(day3); break;
                    case 4: Console.WriteLine(day4); break;
                    case 5: Console.WriteLine(day5); break;
                    case 6: Console.WriteLine(day6); break;
                    case 7: Console.WriteLine(day7); break;
                } 

                //is there a better way besides using Switch in this case?
                //in this case yes.
                Console.WriteLine("This works too");
                Console.WriteLine(daysOfWeek[myValue - 1]); //remember to subtract 1
            }
            else
            {
                Console.WriteLine(myValue + " is not 1-7!");
            }
        }

        private static int ReadInteger(string prompt)
        {
            //show the prompt
            Console.Write(prompt);
            // read in the console input using Console.ReadLine()
            String s;
            s = Console.ReadLine();

            //and then convert to a integer value
            //Convert.ToInt32(string)
            int returnValue;
            returnValue = Convert.ToInt32(s);
            return returnValue;
        }
        private static int ReadIntegerWithErrorChecking(string prompt)
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
