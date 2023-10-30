using System.Collections;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class MinStack
    {
        Stack stack = new Stack();
        Stack minStack = new Stack();
        int minValue = int.MaxValue;

        /*returns min element from stack*/
        public int GetMin()
        {
            return minValue;
            //Write your code here
        }

        /*returns popped element from stack*/
        public void Pop()
        {
            stack.Pop();
            minStack.Pop();

            if (minStack.Count > 0)
                minValue = (int)minStack.Peek();
            //Write your code here
        }

        /*push element x into the stack*/
        public void Push(int x)
        {
            if (x < minValue)
                minValue = x;

            stack.Push(x);
            minStack.Push(minValue);
        }

        public int Top()
        {
            return (int)stack.Peek();
        }
    }
}
