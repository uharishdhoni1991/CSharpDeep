using System;
using System.Collections.Generic;
using System.Text;

namespace Tutor_Challenges
{
    public class Challenges
    {
        public int FindMaxOfThreeElements(int[] array)
        {
            if (array.Length == 0)
                return -1;

            int max = array[0];

            if (array.Length == 1)
                return max;

            for(int i=1; i<array.Length;i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }

        public int FindMinOfThreeElements(int[] array)
        {
            if (array.Length == 0)
                return -1;

            int min = array[0];

            if (array.Length == 1)
                return min;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            return min;
        }

        public int FindMidElementOfThreeElements(int[] array)
        {
            if (array.Length == 0)
                return -1;

            if (array.Length == 1 || array.Length == 2)
                return array[0];

            int max = array[0];
            int min = array[1];
            int mid = -1;

            for(int i =0; i <array.Length;i++)
            {
                if (array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];

                if (array[i] > min && array[i] < max)
                    mid = array[i];
            }

            return mid;
        }

        public string PrintSeries(int n)
        {
            string st = "";
            string temp = "";

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    temp += $"{i + 1} ";
                else
                    temp += $"{i + 1}";
                
                st +=$"{temp.Trim()}{"\n"}";
            }

            return st.ToString().TrimEnd();
        }

        public string PrintReverseSeries(int n)
        {
            string st = "";
            string temp = "";

            for (int i = 0; i < n; i++)
            {
                temp += $"{i + 1} ";                
            }

            temp = temp.Trim();

            st += $"{temp.Trim()}{"\n"}";

            for(int i = n-1;i > 0; i--)
            {
                temp = temp.Remove((i + 1) * 2 - 3, 2);
                st += $"{temp.Trim()}{"\n"}";
            }

            return st.ToString().TrimEnd();
        }

        public int[] FindAllOddElements(int[] array)
        {
            List<int> oddElements = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    oddElements.Add(array[i]);
            }

            return oddElements.ToArray();
        }

        public double FindSumOfArrayElements(int[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public int FindFirstEvenNumber(int[] array)
        {
            int slowPivot = 0;
            int fastPivot = 0;    
            
           while(slowPivot+1 < array.Length && fastPivot+1 < array.Length)
            {
                if (array[slowPivot] % 2 == 0)
                    return array[slowPivot];

                if (array[fastPivot] % 2 == 0)
                    return array[fastPivot];

                slowPivot++;
                fastPivot = fastPivot + 2;
            }

            return -1;
        }
    }
}