using System; 

namespace E001_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter your name: ");
            Console.WriteLine("\n\nHello " + Console.ReadLine());
            Console.WriteLine("Welcome to C# Training Essential Tutorial");
            Console.WriteLine("Press any key to exit.");

            //hint: System.Console.ReadLine() allows you to read from the console

            Console.ReadLine();
        }
    }
}
