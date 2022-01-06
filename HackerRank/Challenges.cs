﻿using System;
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
    }
}
