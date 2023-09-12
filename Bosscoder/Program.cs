using Bosscoder.Mentorship;
using Bosscoder.Week_2.Homework_Questions;
using System;

namespace Bosscoder
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortArrayWithTwoNumbers msr = new SortArrayWithTwoNumbers();
            msr.SortedArray(
                arr : new int[] { 0, 1, 1, 0, 1, 0, 1},
                numberToSort: 0,
                startIndex: 0);           

            msr.SortedArrayThreeNumbers(
                arr: new int[] { 0, 2, 1, 1, 0, 2 });


            msr.SortedArrayThreeNumbers(
                arr: new int[] { 0, 2, 2, 1, 0, 2 });

            Console.ReadLine();
        }
    }
}
