using System;
using System.Collections;
using System.Linq;

namespace TechGig.Practice
{
    public class ProductSum : IExecute
    {
        public void Execute()
        {
            object[] input = new object[5];
            input[0] = 5;
            input[1] = 2;
            input[2] = new object[] { 7, -1 };
            input[3] = 3;
            object[] sub = new object[] { -13, 8 };
            object[] sub2 = new object[] { 6, sub, 4 };
            input[4] = sub2;

            int total = GetProductSum(input, 1);
        }

        public int GetProductSum(object[] arrayInput, int depthInput)
        {
            int total = 0;
            int depth = depthInput;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (!(arrayInput[i] is object[]))
                {
                    total = total + depth*int.Parse(arrayInput[i].ToString());
                }
                else
                {                   
                    object[] arrayToPass = ((IEnumerable)(arrayInput[i])).Cast<object>().ToArray();
                    total = total + GetProductSum(arrayToPass, depth+1) * depth;                    
                }
            }

            return total;
        }
    }
}
