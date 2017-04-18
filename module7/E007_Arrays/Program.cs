using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E007_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num; //num is declared, but not initialized
            num = new int[3]; // num is allocated size of 3 integers
            num[0] = 10; //Note: first position starts with 0
            num[2] = 5;
            num[1] = 20;
            double[] balance = { 10.0, 12.0, 16.0 }; // direct allocation


            //an array can have more than one dimensions 
            int[,] array = new int[4, 2]; //4 rows and 2 cols
            int[,,] array1 = new int[4, 2, 3]; // 3 dimensions 

            //They can be directly initialized
            int[,] array2D_a = { { 1, 2 }, { 3, 4 } };
            int[,] array2D_b = new int[,] { { 1, 2 }, { 3, 4 } };

            //They can be accessed 
            int[,] array3 = new int[,] { { 1, 2 }, { 3, 4 }, { 3, 4 } };
            array3[2,1] = 25; //3rd row, 2nd col (remember it starts from 0)
            int elementValue = array3[2,1];
             
        }
    }
}
