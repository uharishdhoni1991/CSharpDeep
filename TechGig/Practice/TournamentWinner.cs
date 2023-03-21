using System;
using System.Collections.Generic;
using System.Linq;

namespace TechGig.Practice
{
    public class TournamentWinner : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Enter number of matches played");
            int matchesPlayed = Convert.ToInt32(Console.ReadLine());
            string[][] competitions = new string[matchesPlayed][];

            Console.WriteLine("Enter teams played in the format - HomeTeam,AwayTeam followed by a linebreak");
            string[] teams = new string[matchesPlayed];

            for (int i = 0; i < matchesPlayed; i++)
            {
                teams[i] = Console.ReadLine();
            }


            for (int i = 0; i < matchesPlayed; i++)
            {
                competitions[i] = new string[2];
                string[] teamNames = teams[i].Split(',');

                for (int j = 0; j < 2; j++)
                {
                    competitions[i][j] = teamNames[j];
                }
            }

            Console.WriteLine("Enter results in the format - 1,0,0 where 1 denotes Victory of HomeTeam , 0 for AwayTeam");
            string[] stringResults = Console.ReadLine().Split(',');
            int[] results = new int[matchesPlayed];

            for (int i = 0; i < matchesPlayed; i++)
            {
                results[i] = Int16.Parse(stringResults[i]);
            }

            string winner = GetTournamentWinner(competitions, results);
        }

        [TimeN]
        public string GetTournamentWinner(string[][] competitions, int[] results)
        {
            Dictionary<string, int> teamAndPoints = new Dictionary<string, int>(competitions.Length);
           

            for (int i = 0; i < competitions.Length; i++)
            {
                if (!teamAndPoints.ContainsKey(competitions[i][0]))
                    teamAndPoints[competitions[i][0]] = 0;

                if (!teamAndPoints.ContainsKey(competitions[i][1]))
                    teamAndPoints[competitions[i][1]] = 0;

                if (results[i] == 0)
                    teamAndPoints[competitions[i][1]] = teamAndPoints[competitions[i][1]] + 3;
                else
                    teamAndPoints[competitions[i][0]] = teamAndPoints[competitions[i][0]] + 3;
            }

            int maxValue = teamAndPoints.Values.Max();
            return teamAndPoints.Single(x => x.Value == maxValue).Key;
        }
    }
}
