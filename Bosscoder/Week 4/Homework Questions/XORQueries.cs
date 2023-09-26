namespace Bosscoder.Week_4.Homework_Questions
{
    public class XORQueries
    {
        public int[] GetQueryXORResult(int[] arr, int[][] queries)
        {
            //Prefix Sum
            int sum = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                sum = sum ^ arr[i];
                arr[i] = sum;
            }

            int[] res = new int[queries.Length];

            for(int i = 0; i < res.Length; i++)
            {
                if (queries[i][0] == 0)
                    res[i] = arr[queries[i][1]];
                else
                    res[i] = arr[queries[i][1]] ^ arr[queries[i][0] -1];
            }

            return res;
        }
    }
}
