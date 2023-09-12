namespace Bosscoder.Week_3.Warmup_Questions
{
    public class CountOfMatchesInTournament
    {
        public int GetMatchCountInTournament(int n)
        {
            int totalMatchesPlayed = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    totalMatchesPlayed += (n / 2);
                    n = n / 2;
                }
                else
                {
                    totalMatchesPlayed += (n - 1) / 2;
                    n = ((n - 1) / 2) + 1;
                }
            }

            return totalMatchesPlayed;
        }
    }
}
