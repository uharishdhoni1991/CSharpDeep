using System.Collections.Generic;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class ImplementStackUsingQueue
    {
        Queue<int> mainQueue;

        public ImplementStackUsingQueue()
        {
            mainQueue = new Queue<int>();
        }

        public void Push(int x)
        {
            Queue<int> sideQueue = new Queue<int>();

            while(mainQueue.Count > 0)
            {
                sideQueue.Enqueue(mainQueue.Dequeue());
            }

            mainQueue.Enqueue(x);

            while (sideQueue.Count > 0)
            {
                mainQueue.Enqueue(sideQueue.Dequeue());
            }                      
        }

        public int Pop()
        {
            return mainQueue.Dequeue();
        }

        public int Top()
        {
            return mainQueue.Peek();
        }

        public bool Empty()
        {
            return mainQueue.Count == 0;
        }
    }
}
