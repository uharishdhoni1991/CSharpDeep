using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    internal class Challenges
    {
        internal List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int aLength = a.Count;
            int bLength = b.Count;            
            List<int> processedList = new List<int>()
            {
                0,
                0
            };

            for (int i = 0, j = 0; i <= aLength; i++, j++)
            {
                if (j > bLength - 1)
                    break;

                if (a[i] == b[j])
                    continue;

                int intendedIndex = a[i] > b[j] ? 0 : 1;
                processedList[intendedIndex] = processedList[intendedIndex] + 1;
            }

            return processedList;
        }

        internal void MiniMaxSum(List<int> arr)
        {
            List<long> outArr = new List<long>();            

            for (int counter = 0; counter < arr.Count; counter++ )
            {
                List<int> temp = arr.Where((v, i) => i != counter).ToList();
                outArr.Add(temp.Sum(item => (long)item));                
            }

            Console.WriteLine($"{outArr.Min()} {outArr.Max()}");
        }

        internal int BirthdayCakeCandles(List<int> candles)
        {
            int highest = int.MinValue;
            int candleCount = 0;

            foreach(var candle in candles)
            {
                if (candle > highest)
                {
                    highest = candle;
                    candleCount = 1;
                    continue;
                }

                if (candle == highest)
                    candleCount++;
            }

            return candleCount;
        }

        internal List<int> GradingStudents(List<int> grades)
        {
            List<int> updatedGrades = new List<int>();

            foreach (var grade in grades.Select((x, y) => new { Val = x, Index = y }))
            {
                int updatedGrade = grade.Val;
                updatedGrades.Add(updatedGrade);

                int quot = updatedGrade / 5;
                int rem = updatedGrade % 5;

                if (rem == 0)
                    continue;

                int valToUpdate = (quot + 1) * 5;

                if (valToUpdate < 40)
                    continue;

                if (5 - rem < 3)
                    updatedGrades[grade.Index] = valToUpdate;
            }

            return updatedGrades;
        }

        internal void CountApplesAndOranges(
            int houseStartingPoint,
            int houseEndingPoint,
            int appleTreeLocation,
            int orangeTreeLocation,
            List<int> apples,
            List<int> oranges)
        {
            int appleCount = 0;

            foreach (int apple in apples)
            {
                if (apple + appleTreeLocation >= houseStartingPoint && apple + appleTreeLocation <= houseEndingPoint)
                    appleCount++;
            }

            int orangeCount = 0;

            foreach (int orange in oranges)
            {
                if (orange + orangeTreeLocation >= houseStartingPoint && orange + orangeTreeLocation <= houseEndingPoint)
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        internal string KangarooJump(
            int kangarooAStartPos,
            int kangarooAVel,
            int kangarooBStartPos,
            int kangarooBVel)
        {
            var kangarooACantCatchUp = kangarooAStartPos < kangarooBStartPos && kangarooAVel < kangarooBVel;
            var kangarooBCantCatchUp = kangarooBStartPos < kangarooAStartPos && kangarooBVel < kangarooAVel;

            if (kangarooACantCatchUp || kangarooBCantCatchUp)            
               return "NO";
               

            bool canCatchUp = false;

            for(int i =0; i<=10000;i++)
            {
                kangarooAStartPos = kangarooAStartPos + kangarooAVel;
                kangarooBStartPos = kangarooBStartPos + kangarooBVel;

                if (kangarooAStartPos == kangarooBStartPos)
                {
                    canCatchUp = true;
                    break;
                }
            }

            return $"{(canCatchUp ? "YES" : "NO")}";
        }

        internal int GetTotalX(List<int> a, List<int> b)
        {
            int counter = 0;

            for (int currentNum = 1; currentNum <= 100; currentNum++)
            {
                bool checkFlag = true;
                for (int j = 0; j < a.Count; j++)
                {
                    if (currentNum % a[j] != 0)
                    {
                        checkFlag = false;
                    }
                }
                if (checkFlag)
                {
                    bool checkx = CheckFactor(currentNum, b);
                    if (checkx)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private bool CheckFactor(int ax,List<int> b)
        {
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i] % ax != 0)                
                    return false;                
            }
            return true;
        }

        internal double ReverseInt(int a)
        {
            List<int> array = new List<int>();
            int i = 0;

            while(a > 0)
            {                
                array.Add(a % 10);
                a = a / 10;
                i++;
            }

            double reversedNum = 0;

            for(int j = 0;j < array.Count; j++)
            {
                reversedNum += array[j] * Math.Pow(10, array.Count - j - 1);
            }

            return reversedNum;
        }
    }
}
