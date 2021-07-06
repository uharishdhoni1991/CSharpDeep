using System;
using System.Linq;

namespace TechGig.Practice
{
    internal class FindIntOrFloatOrString : IExecute
    {
        public string IsInteger { get; } = "This input is of type Integer.";
        public string IsFloat { get; } = "This input is of type Float.";
        public string IsString { get; } = "This input is of type String.";
        public string IsSomethingElse { get; } = "This is something else.";

        public string Outputstring { get; set; }

        public void Execute()
        {
            Console.WriteLine("Input a value");
            string str = Console.ReadLine();


            if (str == null || str.Length < 1 || str.Length > 10000)
                return;
          

            if (IsStringInput(str))
            {
                Console.WriteLine(IsString);
                Outputstring = IsString;
            }
            else if (isInt(str))
            {
                Console.WriteLine(IsInteger);
                Outputstring = IsInteger;
            }
            else if (isFloat(str))
            {
                Console.WriteLine(IsFloat);
                Outputstring = IsFloat;
            }
            else
            {
                Console.WriteLine(IsSomethingElse);
                Outputstring = IsSomethingElse;
            }


            Console.ReadLine();
        }

        private static bool IsStringInput(string str)
        {
            bool isString = false;
            int dotCount = 0;
            int minusCount = 0;
            int fCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                    dotCount++;
                if (str[i] == '-')
                    minusCount++;
                if (str[i] == 'f')
                    fCount++;
            }

            isString = (dotCount == 1 && (minusCount > 1 || fCount > 1))                  
                   || (minusCount == 1 && (dotCount > 1 || fCount > 1))               
                   || (fCount == 1 && (dotCount > 1 || minusCount > 1));
            return isString;
        }

        static bool isInt(string s)
        {
            try
            {
                Int64.Parse(s);
            }
            catch
            {
                return false;
            }

            return true;
        }

        static bool isFloat(string s)
        {
            try
            {
                float.Parse(s);
            }
            catch
            {
                return false;
            }

            return true;           
        }
    }
}