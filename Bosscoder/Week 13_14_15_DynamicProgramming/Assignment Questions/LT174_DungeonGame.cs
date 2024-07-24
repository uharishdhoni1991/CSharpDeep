using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT174_DungeonGame
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int[] cache = new int[dungeon[0].Length+1];

            for (int i = 0; i <= dungeon[0].Length; i++)
                cache[i] = int.MaxValue;

            cache[dungeon[0].Length - 1] = 1;

            for(int i = dungeon.Length - 1 ; i >= 0; i--)
            {
                for(int j = dungeon[0].Length - 1; j >= 0; j--)
                {
                    var bottomCost = cache[j];
                    var rightCost = cache[j + 1];

                    var minPowerReq = Math.Min(bottomCost, rightCost) - dungeon[i][j];

                    cache[j] = Math.Max(1, minPowerReq);
                }
            }

            return cache[0];
        }
    }
}