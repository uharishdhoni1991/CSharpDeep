using System;

namespace TechGig.Practice
{  
    internal class TwoSum : IExecute
    {
        public void Execute()
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[arrayLength];
            string[] elementArray = Console.ReadLine().Split(' ');

            for (int i= 0; i < arrayLength; i++)
            {
                inputArray[i] = Convert.ToInt32(elementArray[i]);
            }

            int[] requiredIndices = FindTwoSum(inputArray, 8);
        }

        [TimeNLogN]
        int[] FindTwoSum(int[] numbers, int target)
         {
            int[] outputArray = new int[2];
            int reversePointer = numbers.Length - 1;
            int forwardPointer = 0;

            Array.Sort(numbers);

            for(int i=0; i < numbers.Length; i++)
            {
                if(numbers[forwardPointer] + numbers[reversePointer] == target)
                {
                    outputArray[0] = numbers[forwardPointer];
                    outputArray[1] = numbers[reversePointer];
                    break;
                }
                else if(numbers[forwardPointer] + numbers[reversePointer] > target)
                {
                    reversePointer--;
                }
                else if(numbers[forwardPointer] + numbers[reversePointer] < target)
                {
                    forwardPointer++;
                }
            }

            return outputArray;
        }

        [TimeN2]
        int[] FindTowSum(int[] numbers, int target)
        {
            int[] outputArray = new int[2];

            for(int i =0; i< numbers.Length; i++)
            {
                for(int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        outputArray[0] = i;
                        outputArray[1] = j;
                        break;
                    }
                }
            }

            return outputArray;
        }
    }
}