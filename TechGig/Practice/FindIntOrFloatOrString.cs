using System;

namespace TechGig.Practice
{
    internal class FindIntOrFloatOrString : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Input a value");
            string str = Console.ReadLine();


            if (str == null || str.Length < 1 || str.Length > 10000)
                return;

            bool s = float.TryParse(str, out float res1);

            if (isInt(str) && int.TryParse(str, out int res))
                Console.WriteLine("This input is of type Integer.");
            else if (isFloat(str) && float.TryParse(str, out float res2))
                Console.WriteLine("This input is of type Float.");
            else
                Console.WriteLine("This input is of type String.");

            Console.ReadLine();

            float f = 777.8f;
        }

        static bool isInt(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }

        static bool isFloat(string s)
        {
            int dotCount = 0;
            bool isFloat = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    dotCount++;
                    continue;
                }

                isFloat = isFloat && char.IsDigit(s[i]);
            }

            return isFloat && dotCount == 1;
        }
    }
}