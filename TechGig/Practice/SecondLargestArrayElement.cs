using System;
using System.Collections.Generic;
using System.Linq;

namespace TechGig.Practice
{
    internal class SecondLargestArrayElement : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Second largest element in an array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            List<int> intArray = new List<int>();

            string arrayElements = Console.ReadLine();
            foreach (var num in (arrayElements.Split(new string[] { " " }, StringSplitOptions.None)))
            {
                intArray.Add(int.Parse(num));
            }

            int secondLargest = intArray.OrderByDescending(num => num).Skip(1).First();
            Console.WriteLine(secondLargest);            
        }
    }
}