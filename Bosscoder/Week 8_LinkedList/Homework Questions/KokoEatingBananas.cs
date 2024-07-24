using System.Linq;

namespace Bosscoder.List.HomeWork_Questions
{
    public class KokoEatingBananas
    {
        private bool IsEnough(int[] piles, int k, int h)
        {
            int hours = 0;

            foreach (var pile in piles)
            {
                hours += (pile + k - 1) / k;
            }

            return hours <= h;
        }

        public int Solve(int[] piles, int h)
        {
            int l = 1;
            int r = piles.Max();

            while (l < r)
            {
                int m = l + (r - l) / 2;

                if (IsEnough(piles, m, h))
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
        }
    }
}