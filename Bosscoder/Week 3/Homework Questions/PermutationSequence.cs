using System.Linq;

namespace Bosscoder.Week_3.Homework_Questions
{
    public class PermutationSequence
    {
        /*Revisit and understand the logic*/
        public string GetSequence(int n, int k)
        {
            // Create a list of numbers from 1 to n.
            var nums = Enumerable.Range(1, n).ToList();

            // Create an array to store factorials from 0 to n-1.
            int[] factorials = new int[n];
            factorials[0] = 1;
            for (int i = 1; i < n; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }

            // Decrement k to convert to zero-based index.
            k--;

            // Build the result string by adding digits from nums.
            string result = "";
            for (int i = n - 1; i >= 0; i--)
            {
                int index = k / factorials[i];
                result += nums[index];
                nums.RemoveAt(index);
                k -= index * factorials[i];
            }

            return result;
        }    
    }
}
