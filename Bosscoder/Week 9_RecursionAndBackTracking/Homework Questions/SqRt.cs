namespace Bosscoder.Week_9_RecursionAndBackTracking.Homework_Questions
{
    public class SqRt
    {
        public int Solve(int num)
        {
            if (num == 1 || num == 0)
                return num;

            return SqRtRecursion(num, 2, num);
        }

        private int SqRtRecursion(int num, int left, int right)
        {
            if (left > right)
                return right;

            int middle = left + (right - left) / 2;
            long square = (long)middle * middle;

            if (square == num)
                return middle;

            if (square > num)
                return SqRtRecursion(num, left, middle - 1);

            return SqRtRecursion(num, middle + 1, right);
        }
    }
}
