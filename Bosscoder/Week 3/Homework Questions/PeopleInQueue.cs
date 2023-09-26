namespace Bosscoder.Week_3.Homework_Questions
{
    public class PeopleInQueue
    {
        /*Revisit*/
        public long GetNPosition(long n)
        {
            if (n == 1)
                return 1;

            return 2 * GetNPosition(n / 2);
        }
    }
}
