using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E004_1_Exercise.src
{
    class Vowel
    {
        public static bool IsVowel(char myChar)
        {
            //a vowel is A,E,I,O,U (and also a,e,i,o,u)
            //check to see if the character is a vowel

            //edit the code below to return true if myChar is a vowel
            return myChar == 'A' || myChar == 'E' || myChar == 'I' || myChar == 'O' || myChar == 'U' ||
                myChar == 'a' || myChar == 'e' || myChar == 'i' || myChar == 'o' || myChar == 'u';
        }
    }
}
