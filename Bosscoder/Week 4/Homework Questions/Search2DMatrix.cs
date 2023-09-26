namespace Bosscoder.Week_4.Homework_Questions
{
    public class Search2DMatrix
    {
        /*Approach
            Step 1: Understand the Problem:
            The problem provides a 2D matrix with two key properties: each row is sorted in non-decreasing order, and the first integer of each row is greater than the last integer of the previous row.You are required to find whether a given target integer exists in this matrix.

            Step 2: Binary Search Approach:
            Your solution employs a binary search algorithm to efficiently locate the target in the matrix.

            Step 3: Binary Search Implementation:

            Initialization:

            You start by obtaining the dimensions of the matrix: m represents the number of rows, and n represents the number of columns.
            You set up two pointers, left and right, to define the search range within the flattened matrix.The search space is from index 0 to m * n - 1.
            Binary Search Loop:

            You enter a loop that continues as long as the left pointer is less than or equal to the right pointer. This ensures that the search space is not exhausted.
            Midpoint Calculation:

            Inside the loop, you calculate the midpoint index, mid, using the formula: mid = left + (right - left) / 2. This approach prevents potential integer overflow and gives you the middle index.
            Mapping to 2D Indices:

            You determine the row and col indices in the original 2D matrix that correspond to the mid index in the flattened matrix.This is achieved using integer division(mid / n) for the row and the remainder(mid % n) for the column.
            Middle Value Comparison:


            You retrieve the value at the calculated row and col indices from the original matrix.This value is termed midValue.
            You compare midValue with the target:
            If they are equal, you have found the target in the matrix, and you return true.
            If midValue is less than the target, you adjust the left pointer to focus on the right half of the search space.
            If midValue is greater than the target, you adjust the right pointer to focus on the left half of the search space.
            Repeat Loop:


            The loop continues, recalculating the midpoint and comparing values until the search space is either exhausted (no more elements to search) or the target is found.
            Return Result:

            If the loop exits without finding the target, you return false to indicate that the target is not present in the matrix.*/
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int left = 0;
            int right = m * n - 1; // Total number of elements in the flattened matrix

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Calculate the mid index

                int row = mid / n; // Calculate the row index
                int col = mid % n; // Calculate the column index

                int midValue = matrix[row][col]; // Value at the middle index

                if (midValue == target)
                {
                    return true;
                }
                else if (midValue < target)
                {
                    left = mid + 1; // Search the right half
                }
                else
                {
                    right = mid - 1; // Search the left half
                }
            }

            return false; // Target not found
        }
    }
}
