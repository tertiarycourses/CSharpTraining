using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E010_2_Exercise.src
{
    public class CalculatorLogic
    { 
        List<double> numberList = new List<double>();
        List<char> operationList = new List<char>();
        // e.g. "4 + 4 ="
        // will populate {4,4} in numberList and
        // {"+", "="} in operationList

        StringBuilder currentText = new StringBuilder();
        // this field stores the input from users
        // before an operations button is pressed.

        public void AddDigit(char digit, out String formula, out String result)
        {
            switch (digit)
            {
                case '.':
                    //we need to check.
                    //if string is empty, then append "0."
                    //if string already have ".", then ignore.


                    break;
                case '0': break;

                case '1':  
                case '2': 
                case '3': 
                case '4': 
                case '5': 
                case '6': 
                case '7': 
                case '8': 
                case '9':
                    //just append the value in to current text

                    break;
                case '+': case '-': case 'x': case '/':
                case '=':
                    //do nothing if current text is empty.

                    break;
            }

            result = currentText.ToString();
            formula = GetFormula();

            //if the digit entered is =, we will perform the evaluation
            if (digit == '='  )
            {

                //we want to evaluate the whole string. 
                result = "Result: " + DoEvaluation();

                // This evaluation considers the operator's presidence
                //result = "Result: " + DoEvaluationWithPresidence();
                 
                //house keep 
                currentText.Clear();
                numberList.Clear();
                operationList.Clear();
            }
        }
         

        private double DoEvaluation()
        {
            //we need to iterate through the list and evaluate 2 numbers at a time.
            //e.g. if list is {2,3,4} and {+, -, =} 
            //     we will evaluate 2 times 
            //                   => 2 + 3 = 5
            //                   => 5 - 4 = 1


            //remember, we evaluate using the metod at CalculatorUtility

            return 0.0;
        } 

        private double DoEvaluationWithPresidence()
        {
            //advance. how to evaluate with BODMAS in mind?
            //REMEMBER BODMAS = Brackets, Order, Divide, Multiply, Add, Subtract.

            //we perform all Divides first, 
            //then all Multiplies, followed by Adds and Subtracts. 

            return 0.0;
             
        } 

        private string GetFormula()
        {
            StringBuilder result = new StringBuilder();
            //basically, we append the values from the two lists
            //both list sizes should be the same.
            for(int i = 0; i< numberList.Count(); i++)
            {
                result.Append(numberList[i]);
                if (operationList.Count > i) {
                    result.Append(" "+ operationList[i]+ " ");
                }
            }
            return result.ToString();
        }
    }
}
