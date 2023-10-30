using System;

namespace Bosscoder.Mentorship
{
    [Amit]
    public class Recursion
    {
        public void Print1to5(int n)
        {
            if (n <= 0)
                return;

            Print1to5(n - 1);
            Console.WriteLine(n);
            Console.Read();
        }

        public int SumOfNNaturalNumbers(int n)
        {
            if (n == 1)
                return 1;

            return n + SumOfNNaturalNumbers(n - 1);
        }

        public int Pow(int a , int b)
        {
            if (b == 0)
                return 1;

            return a * Pow(a, b - 1);
        }

        public int Fib(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }

        public int Fact(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Fact(n - 1);
        }

        public int SumOfArrayElements(int[] arr, int n)
        {
            if (n == 0)
                return 0;

            return arr[n - 1] + SumOfArrayElements(arr, n - 1);
        }
    }
}
