namespace Bosscoder.List.HomeWork_Questions
{
    //Bit Manipulation
    //Need to elaborate logic
    public class SumOfTwoIntegers
    {
        public int Sum(int a, int b)
        {
            while (b != 0)
            {
                var carry = b & a;
                a ^= b;
                b = carry << 1;
            }

            return a;
        }
    }
}
