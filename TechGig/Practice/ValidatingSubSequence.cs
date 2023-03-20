using System;

namespace TechGig.Practice
{
    public class ValidatingSubSequence : IExecute
    {
        public void Execute()
        {
            int[] inputArray = GetArrayFromInput();

            int[] sequence = GetArrayFromInput();

            bool isValid = CheckValidSubSequence(inputArray, sequence);
        }

        private static int[] GetArrayFromInput()
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[arrayLength];
            string[] elementArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < arrayLength; i++)
            {
                inputArray[i] = Convert.ToInt32(elementArray[i]);
            }

            return inputArray;
        }

        bool CheckValidSubSequence(int[] array, int[] sequence)
        {
            bool isValid = false;
            int sequencePointer = 0;
            int previousArrayPointer = -1;

            for(int i =0; i < array.Length; i++)
            {
                if (array[i] == sequence[sequencePointer] && previousArrayPointer < i)
                {
                    isValid = true;
                    previousArrayPointer = i;
                }
                else
                {
                    isValid = false;
                }                

                if(isValid)
                    sequencePointer++;

                if (sequencePointer == sequence.Length)
                    break;
            }

            isValid = sequencePointer == sequence.Length;

            return isValid;
        }
    }
}
