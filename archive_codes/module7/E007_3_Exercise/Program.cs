using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_3_Exercise
{
    class Program
    {
        static Dictionary<String, String> myPhoneNumbers =
            new Dictionary<String, String>();
        //We just looked at the List Collection.
        //now we explore a collection type for Key-Value pairs.
        //The Dictionary.
        static void Main(string[] args)
        {
            String prompt = "\n\nEnter Choice\n" +
                "(A)dd Contact\n" +
                "(L)ookup Contact\n" +
                "(S)how All Contacts\n" +
                "(E)xit";
            bool exitApp = false;
            do
            {
                char c = GetCharInput(prompt);
                switch (c)
                {
                    //now let's create a method for AddContact
                    case 'a': case 'A': AddContact(); break;
                    //a method for Show All Contacts
                    case 's': case 'S': ShowAllContact(); break;
                    //a method for LookupContact (by Name) 
                    case 'l': case 'L': LookupContact(); break;
                    //Exit app
                    case 'e': case 'E': exitApp = true; break;
                }

            } while (!exitApp);
        }

        private static void LookupContact()
        {
            Console.WriteLine("Lookup Contact");
            Console.WriteLine("Enter contact name: ");
            String name = Console.ReadLine();

            String phone = /* how do we lookup the map?*/
            if (phone == null)
            {
                Console.WriteLine("{0} not found in addressbook.", name);
            }
            else
            {
                Console.WriteLine("{0}: number is {1}", name, phone);
            }

        }

        private static void ShowAllContact()
        {
            Console.WriteLine("Showing all Contacts");
            Console.WriteLine("There are {0} contacts", myPhoneNumbers.Count());

            //we loop through the map using the foreach statement
            foreach (var p in myPhoneNumbers)
            {
                String name = /*how do i get the key of p?*/
                String phone = /*how do i get the value of p?*/
                Console.WriteLine("{0}: number is {1}", name, phone);
            }
        }

        private static void AddContact()
        {
            Console.WriteLine("Add a Contact");
            Console.WriteLine("Enter contact name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            String phone = Console.ReadLine();

            /* How do we add the name:PhoneNumber pair into the dictionary? */
        }

        private static char GetCharInput(string prompt)
        {
            char c;
            bool isValidInput = false;
            do
            {
                Console.WriteLine(prompt);
                if (char.TryParse(Console.ReadLine(), out c))
                {
                    if (c == 'a' || c == 's' || c == 'l' || c == 'e' ||
                        c == 'A' || c == 'S' || c == 'L' || c == 'E')
                    {
                        isValidInput = true;
                    }
                }
            } while (!isValidInput);
            return c;
        }
    }
}

