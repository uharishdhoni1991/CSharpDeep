using System.Collections.Generic;

namespace TechGig.Practice
{
    public class TandemBicycle : IExecute
    {
        public void Execute()
        {
            int totalSpeed = GetOverallSpeed(isFast: true,
                redRiders: new List<int> { 5, 5, 3, 9, 2 },
                blueRiders: new List<int> { 3, 6, 7, 2, 1 });
        }

        public int GetOverallSpeed(bool isFast, List<int> redRiders, List<int> blueRiders)
        {
            int totalSpeed = 0;

            redRiders.Sort();
            blueRiders.Sort();

            if (isFast)
                blueRiders.Reverse();

            for(int i = 0; i < redRiders.Count; i++)
            {
                if (redRiders[i] > blueRiders[i])
                    totalSpeed += redRiders[i];
                else
                    totalSpeed += blueRiders[i];
            }

            return totalSpeed;
        }
    }
}
