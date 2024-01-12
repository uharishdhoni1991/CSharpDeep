using Bosscoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class GFG_MinNoOfPlatformsRequired
    {
        [TimeN2]
        public int Solve(int[] arr, int[] dep)
        {
            int n = arr.Length;

            // plat_needed indicates number of platforms
            // needed at a time
            int plat_needed = 1, result = 1;

            // Run a nested for-loop to find the overlap
            for (int i = 0; i < n; i++)
            {

                // Initially one platform is needed
                plat_needed = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        // Increment plat_needed when there is an
                        // overlap
                        if (arr[i] >= arr[j] && dep[j] >= arr[i])
                            plat_needed++;
                }

                // Update the result
                result = Math.Max(plat_needed, result);
            }
            return result;
        }

        [TimeN]
        public int SolveEfficiently(int[] arr, int[] dep)
        {
            /*Combine arr and dept into a complex object,
             * Sort the object arr based on arrival time,
             * Add a queue to check previous enqueued train's departure time 
             * - If current train's arrival time intersects , then add a platform and add current train's dept time
             * - else Dequeue the prev train's dept time and add current train's dept time 
            */

            if (arr.Length != dep.Length)
                return 0;

            TrainSchedule[] trainSchedules = new TrainSchedule[arr.Length];

            for(int i =0; i < arr.Length; i++)
            {
                trainSchedules[i] = new TrainSchedule(arr[i], dep[i]);
            }

            Array.Sort(trainSchedules, (a, b) => { return a.Arrival - b.Arrival; });

            Queue<int> deptQueue = new Queue<int>();
            deptQueue.Enqueue(trainSchedules[0].Departure);

            int noOfPlatformsRequired = 1;

            for(int i = 1; i < trainSchedules.Length; i++)
            {
                if (trainSchedules[i].Arrival <= deptQueue.Peek())
                    noOfPlatformsRequired++;
                else
                    deptQueue.Dequeue();

                deptQueue.Enqueue(trainSchedules[i].Departure);
            }

            return noOfPlatformsRequired;
        }

        public class TrainSchedule
        {
            public int Arrival { get;  set; }
            public int Departure { get; set; }

            public TrainSchedule(int arrival, int departure)
            {
                Arrival = arrival;
                Departure = departure;
            }
        }
    }
}