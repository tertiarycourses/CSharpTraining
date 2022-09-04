using System;
using System.Collections.Generic;
using System.Linq; 

namespace E007_3_Solution
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
             
            if (myPhoneNumbers.TryGetValue(name, out string phone))
            {
                phone = myPhoneNumbers[name];
                Console.WriteLine("{0}: number is {1}", name, phone);
            }
            else
            {
                Console.WriteLine("{0} not found in addressbook.", name);
            } 
        }

        private static void ShowAllContact()
        {
            Console.WriteLine("Showing all Contacts");
            Console.WriteLine("There are {0} contacts", myPhoneNumbers.Count());
            foreach (var p in myPhoneNumbers)
            {
                String name = p.Key;
                String phone = p.Value;
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

            myPhoneNumbers.Add(name, phone);
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
