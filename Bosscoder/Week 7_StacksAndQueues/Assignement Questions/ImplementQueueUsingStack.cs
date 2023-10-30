using System.Collections.Generic;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class ImplementQueueUsingStack
    {
        Stack<int> mainStack = new Stack<int>();       

        public ImplementQueueUsingStack()
        {

        }

        public void Push(int x)
        {
            Stack<int> sideStack = new Stack<int>();

            while(mainStack.Count > 0)
            {
                sideStack.Push(mainStack.Pop());
            }

            mainStack.Push(x);

            while (sideStack.Count >0)
            {
                mainStack.Push(sideStack.Pop());
            }           
        }

        public int Pop()
        {
            return mainStack.Pop();
        }

        public int Top()
        {
            return mainStack.Peek();
        }

        public bool Empty()
        {
            return mainStack.Count == 0;
        }
    }
}
