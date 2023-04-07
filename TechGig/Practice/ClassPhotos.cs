using System;

namespace TechGig.Practice
{
    public class ClassPhotos : IExecute
    {
        public void Execute()
        {
            bool isFeasible = CheckForPhotoArrangementFeasibility(
                redShirts: new int[] { 5, 8, 1, 3, 4 },
                blueShirts: new int[] { 6, 9, 2, 3, 5 });
        }

        public bool CheckForPhotoArrangementFeasibility(int[] redShirts, int[] blueShirts)
        {
            bool isFeasible = true;

            Array.Sort(redShirts);
            Array.Sort(blueShirts);

            bool isRedTaller = redShirts[0] > blueShirts[0];

            for(int i = 0; i < redShirts.Length; i++)
            {
                if(isRedTaller && isFeasible)
                {
                   isFeasible = isFeasible && redShirts[i] > blueShirts[i];
                }
                else if(isFeasible)
                {
                    isFeasible = isFeasible && blueShirts[i] > redShirts[i];
                }
                else
                {
                    isFeasible = false;
                    return isFeasible;
                }
            }

            return isFeasible;
        }
    }
}
