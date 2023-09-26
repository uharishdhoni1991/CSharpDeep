using System;

namespace Bosscoder.Week_3.Assignment_Questions
{
    public class Rand10FromRand7
    {
        /*REvist and REvise*/
        public int Rand10()
        {
            int x = Rand7();
            int y = Rand7();

            int ans = ((x - 1) * 7 + y);

            return (ans > 40 ? Rand10() : (ans - 1) % 10 + 1);
        }

        private int Rand7()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        /*
         * Rand7() - 1,2,3,4,5,6,7
         * Probability of getting 7 is 1/7
         * When called twice probability pf getting 7 is 1/49
         * 
         * TO get numbers from 1-10
         * [1,2,3] [4,5,6],7 - ignore 7
         * 1-3 and 4-6 is enough to generate till 10
         * 
         * Probability of 6 and 7 occuring for one call 2/7 , two consecutive calls 4/49 = 8% 
         * 
         * V1If the Rand7() gives a number less than or equal to 5 then use it else do rand again
         * V2If the Rand7() gives 7 then do rand again.
         * 
         * V1 = 1,2,3,4,5
         * v2 = 1,2,3,4,5,6
         */
        public int Rand10ProbabilityApproach()
        {
            int v1 = Rand7();
            int v2 = Rand7();

            while (v1 > 5)
               v1 =Rand7();

            while (v2 == 7)
                v2 = Rand7();

            return (v2 <= 3) ? v1 : v1 + 5;
        }
    }
}
