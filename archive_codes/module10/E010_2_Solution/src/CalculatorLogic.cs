using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E010_2_Solution.src
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
                    if (currentText.Length == 0)
                    {
                        currentText.Append("0.");
                    }else if (!currentText.ToString().Contains("."))
                    {
                        currentText.Append(digit);
                    }
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
                    currentText.Append(digit);
                    break;
                case '+': case '-': case 'x': case '/':
                case '=':
                    //do nothing if current text is empty.
                    if (currentText.Length > 0)
                    {
                        numberList.Add(double.Parse(currentText.ToString()));
                        operationList.Add(digit);
                        currentText.Clear();
                    }
                    break;
            }

            result = currentText.ToString();
            formula = GetFormula();

            if (digit == '='  )
            {
                //we want to evaluate the whole string. 
                // result = "Result: " + DoEvaluation();

                // This evaluation considers the operator's presidence
                result = "Result: " + DoEvaluationWithPresidence();


                //house keep 
                currentText.Clear();
                numberList.Clear();
                operationList.Clear();
            }
        }
         

        private double DoEvaluation()
        {
            if (numberList.Count >= 2)
            {
                //the idea is to evaluate 2 numbers at a time
                double num1 = numberList[0];
                double num2 = numberList[1];
                char ops = operationList[0];
                double results = CalculatorUtility.Evaluate(ops, num1, num2);

                //1st 2 numbers are evaluate. 
                //now we remove the first item
                operationList.RemoveAt(0);
                numberList.RemoveAt(0);

                //now we put result into the first location
                numberList[0] = results;

                //And then we repeat again

            }
            
            if(numberList.Count == 0)
            {
                return 0;
            }
            if(numberList.Count == 1)
            {
                return numberList[0];
            }
            else
            {
                // we do a nested loop, to evaluate the next pair of numbers
                //return DoEvaluation();

                return DoEvaluation ();
            }
            
        } 

        private double DoEvaluationWithPresidence()
        {
            //advance. how to evaluate with BODMAS in mind?
            //REMEMBER BODMAS = Brackets, Order, Divide, Multiply, Add, Subtract.

            //we perform all Divides first, 
            //then all Multiplies, followed by Adds and Subtracts.

            //look for divides first
            if (operationList.Contains('/'))
            {
                char ops = '/';
                DoSingleEvaluationWithPresidence(ops);

                return DoEvaluationWithPresidence();

            }
            //then we look for multiplies
            else if (operationList.Contains('*') || 
                 operationList.Contains('x'))
            {
                char ops = 'x';
                DoSingleEvaluationWithPresidence(ops);

                return DoEvaluationWithPresidence();
            }
            else
            {
                // just + and - solve normally.
                return DoEvaluation();
            }
             
        }

        private void DoSingleEvaluationWithPresidence(char ops)
        {
            int position = operationList.IndexOf(ops);
            double num1 = numberList[position];
            double num2 = numberList[position + 1];
            double result = CalculatorUtility.Evaluate('/', num1, num2);

            //remove numbers in position
            numberList.RemoveAt(position);
            operationList.RemoveAt(position);
            //put results back in

            numberList[position] = result;
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
