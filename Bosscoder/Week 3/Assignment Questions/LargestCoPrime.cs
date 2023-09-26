namespace Bosscoder.Week_3.Assignment_Questions
{
    public class LargestCoPrime
    {
        private int GetGCD(int num1 , int num2)
        {
            int remainder;

            while (num2 != 0)
            {
                remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            return num1;
        }

        public int GetLargestCoPrime(int a, int b)
        {
            int x = a;
            int g = GetGCD(x, b);

            while (g != 1)
            {
                x /= g;
                g = GetGCD(x, b);
            }

            return x;
        }
    }
}
