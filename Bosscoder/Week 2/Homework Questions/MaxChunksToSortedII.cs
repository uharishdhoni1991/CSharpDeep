using System;

namespace Bosscoder.Week_2.Homework_Questions
{
    public class MaxChunksToSortedII
    {
        public int MaxChunksToSorted(int[] arr)
        {
            /*
             * Logic behind this
             * MaxLefts are always less than MinRights in a sorted array
             * Ex : [1,2,3,4,5] sorted so if thier chunks before concatentating them are [1,2]
             * [3,4] [5] and before sorting them individually are [2,1] [4,3] [5] which makes the original array
             * as [2,1,4,3,5]. 
             * In the sorted chunks [1,2] [3,4] 2 - MaxLeft of chunk 1 , 3 - MinRight of chunk 2
             */
            //Find MaxLefts
            //Find MinRights
            //Compare and calculate number of chunks

            //Find MaxLefts
            int[] _maxLefts = new int[arr.Length];
            _maxLefts[0] = arr[0];

            for (int i = 1; i < _maxLefts.Length - 1; i++)
            {
                _maxLefts[i] = Math.Max(arr[i], _maxLefts[i-1]);
            }

            //Find MinRights
            int[] _minRights = new int[arr.Length];
            _minRights[arr.Length - 1] = arr[arr.Length-1];

            for (int i = _minRights.Length - 2; i >= 0; i--)
            {
                _minRights[i] = Math.Min(arr[i], _minRights[i + 1]);
            }

            int chunkCount = 0;
            //Compare
            for(int i = 0; i < _minRights.Length - 1; i++)
            {
                chunkCount += _maxLefts[i] <= _minRights[i+1] ? 1 : 0;
            }

            return ++chunkCount;
        }
    }
}
