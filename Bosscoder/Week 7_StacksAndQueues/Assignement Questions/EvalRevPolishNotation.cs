using System.Collections;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class EvalRevPolishNotation
    {
        Stack stack = new Stack();

        /*Push numbers into stack from input , if arithmetic operation is found pop previous  stack values and perform the operation*/
        public int Solve(string[] input)
        {
            foreach (var str in input)
            {
                int leftDigit;
                int rightDigit;

                switch (str)
                {
                    case "+":
                        rightDigit = (int)stack.Pop();
                        leftDigit = (int)stack.Pop();
                        stack.Push(leftDigit+rightDigit);
                        break;
                    case "*":
                        rightDigit = (int)stack.Pop();
                        leftDigit = (int)stack.Pop();
                        stack.Push(leftDigit * rightDigit);
                        break;
                    case "-":
                        rightDigit = (int)stack.Pop();
                        leftDigit = (int)stack.Pop();
                        stack.Push(leftDigit - rightDigit);
                        break;
                    case "/":
                        rightDigit = (int)stack.Pop();
                        leftDigit = (int)stack.Pop();
                        stack.Push(leftDigit / rightDigit);
                        break;
                    default:
                        stack.Push(int.Parse(str));
                        break;
                }               
            }
            return (int)stack.Pop();
        }
    }
}
