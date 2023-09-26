using System;

namespace Bosscoder.Week_3.Assignment_Questions
{
    public class NoOfOpenDoors
    {
        /*
         * Take example of 2,4,9 doors and arrive at answers of 1,2,3 respectively.
            We can see a pattern that the perfect square doors are open, so brute force
            would give the door count 
            
            But we need in O(1) time which means we need to look at a mathematical trick 
            That the no of perfect squares in a range of 1..n is the SqRt(n).
         */
        public int GetNoOfOpenDoors(int n)
        {
            return (int)Math.Sqrt(n);
        }
    }
}
