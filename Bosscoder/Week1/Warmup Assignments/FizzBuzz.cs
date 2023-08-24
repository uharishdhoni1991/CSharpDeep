using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week1
{
    [TimeN]
    public class FizzBuzz
    {
        public IList<string> PrintFizzBuzz(int n)
        {
            List<string> array = new List<string>();

            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 15 == 0)
                {
                    array.Add("FizzBuzz");
                }
                else if ((i + 1) % 3 == 0)
                {
                    array.Add("Fizz");
                }
                else if ((i + 1) % 5 == 0)
                {
                    array.Add("Buzz");
                }
                else
                {
                    array.Add((i + 1).ToString());
                }
            }

            return array;
        }
    }
}
