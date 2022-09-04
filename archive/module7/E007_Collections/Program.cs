using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myNameList = new List<string>();
            myNameList.Add("John");
            myNameList.Add("Peter");
            myNameList.Add("Kim");

            int posn = myNameList.IndexOf("Peter"); // returns 1
            myNameList.Reverse();
            myNameList.Count();
            myNameList.Insert(1, "Sam");

            string name = myNameList[0]; //returns John
            myNameList[0] = "Lim"; // John is replaced by Lim

            //DICTIONARY
            Dictionary<string, int> d =                    //declaration
               new Dictionary<string, int>()      //new instance
			      {  {"cat", 2},  {"apple", -1} }; //initialize values

            d.Add("alpaca", 7);                                   //add 
            bool hasAnimal = d.Remove("car");        //remove
            hasAnimal = d.ContainsKey("dog"); //check key
            bool hasId = d.ContainsValue(7);  //check value
            int number = d["alpaca"];

            //iterate through the pair
            foreach (var pair in d)
            { Console.Write("{0} : {1}", pair.Key, pair.Value); }

            // Store keys in a List.
            List<string> list = new List<string>(d.Keys);
            // Loop through list.
            foreach (string key in list)
            { Console.WriteLine("{0}, {1}", key, dict[key]); }
        }
    }
}
