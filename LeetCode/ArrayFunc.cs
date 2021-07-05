using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	public class ArrayFunc
	{
		internal int FindMaxConsecutiveOnes(int[] nums)
		{
			int maxConsecutiveOnes = 1;
			int arrayLength = nums.Count();
			int[] maxConOnes = new int[arrayLength];

			for (int i = 0; i <= arrayLength - 1; i++)
			{
				if (nums[i] == 1)
				{
					if (i + 1 < arrayLength && nums[i + 1] == 1)
					{
						maxConsecutiveOnes += 1;
					}
					maxConOnes[i] = maxConsecutiveOnes;
				}
				else
				{
					maxConsecutiveOnes = 1;
				}
			}

			return maxConOnes.Max();
		}

		internal int FindNoOfNumbersWithEvenNoOfDigits(int[] nums)
		{
			if (nums.Length <= 0)
				return 0;

			int noOfDigits = 0;
			int[] noOfDigitsArray = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
			{
				noOfDigitsArray[i] = FindNoOfDigits(nums[i], noOfDigits);
			}

			return noOfDigitsArray.Where(x => x % 2 == 0).Count();
		}

		internal int[] SortedSquares(int[] nums)
		{
			int numsLength = nums.Length;

			if (numsLength < 1 && numsLength > 10000)
				return new int[1];

			int[] sortedSquareArray = new int[numsLength];

			for (int i = 0; i < numsLength; i++)
			{
				int number = nums[i];

				if (number < -10000 && number > 10000)
				{
					sortedSquareArray[i] = 0;
					continue;
				}

				sortedSquareArray[i] = number * number;
			}

			return sortedSquareArray.OrderBy(num => num).ToArray();
		}

		internal void DuplicateZeros(int[] arr)
		{
			int arrayLength = arr.Length;

			if (arrayLength < 1 && arrayLength > 10000)
				return;

			for (int index = 0; index < arrayLength; index++)
			{
				if (arr[index] != 0)
					continue;

				int indexIdentified = index;
				int temp = 0;
				int temp1 = 0;

				while (indexIdentified < arr.Length - 1)
				{
					temp1 = temp;
					temp = arr[indexIdentified + 1];
					arr[indexIdentified + 1] = temp1;
					indexIdentified++;
				}

				index++;
			}
		}

		internal void DuplicateZerosV2(int[] arr)
		{
			int arrLength = arr.Length;

			for (int i = arrLength - 1; i >= 0; i--)
			{
				if (arr[i] == 0)
				{
					for (int j = arrLength - 1; j > i; j--)
					{
						arr[j] = arr[j - 1];
					}
				}
			}

		}

		internal void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int totalLength = m + n;
			int[] resultantArray = new int[totalLength];

			int arrCounter1 = 0;
			int arrCounter2 = 0;
			int arrCounter3 = 0;

			while (arrCounter1 < m && arrCounter2 < n)
			{
				if (nums1[arrCounter1] < nums2[arrCounter2])
				{
					resultantArray[arrCounter3] = nums1[arrCounter1];
					arrCounter1++;
				}
				else
				{
					resultantArray[arrCounter3] = nums2[arrCounter2];
					arrCounter2++;
				}
				arrCounter3++;
			}

			while (arrCounter1 < m)
			{
				resultantArray[arrCounter3] = nums1[arrCounter1];
				arrCounter1++;
				arrCounter3++;
			}


			while (arrCounter2 < n)
			{
				resultantArray[arrCounter3] = nums2[arrCounter2];
				arrCounter2++;
				arrCounter3++;
			}

			for (int i = 0; i < m + n; i++)
			{
				nums1[i] = resultantArray[i];
			}
		}

		internal int RemoveElement(int[] nums, int val)
		{
			int i = 0;
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[j] != val)
				{
					nums[i] = nums[j];
					i++;
				}
			}
			return i;
		}

		internal int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
				return 0;

			int i = 0;
			for (int j = 1; j < nums.Length; j++)
			{
				if (nums[j] != nums[i])
				{
					i++;
					nums[i] = nums[j];
				}
			}
			return i + 1;
		}

		internal bool CheckDouble(int[] arr)
		{
			bool doubleExist = false;

			if (arr == null || arr.Length == 0)
				return doubleExist;

			for (int j = 0; j < arr.Length; j++)
			{
				for (int i = 1; i < arr.Length; i++)
				{
					if (i == j)
						continue;

					if (arr[i] == 0 && arr[j] == 0)
					{
						doubleExist = true;
						break;
					}
					else if ((arr[i] != 0 && arr[j] != 0) && (arr[i] == 2 * arr[j] || arr[j] == 2 * arr[i]))
					{
						doubleExist = true;
						break;
					}
				}
			}

			return doubleExist;
		}

		public bool ValidMountainArray(int[] arr)
		{
			int arrLength = arr.Length;
			bool orderSwitched = false;
			int incCounter = 0;
			int decCounter = 0;

			for (int j = 0; j < arrLength - 1; j++)
			{
				if (!orderSwitched && arr[j] < arr[j + 1])
				{
					incCounter++;
					continue;
				}

				orderSwitched = true;


				if (orderSwitched && arr[j] > arr[j + 1])
				{
					decCounter++;
					continue;
				}
			}

			return incCounter > 0 && decCounter > 0 && incCounter + decCounter + 1 == arrLength;
		}

		private int FindNoOfDigits(int number, int noOfDigits)
		{
			if (number < 1 && number > Math.Pow(10, 5))
				return 0;

			while (number != 0)
			{
				number = number / 10;
				++noOfDigits;
			}

			if (noOfDigits < 1 && noOfDigits > 500)
				noOfDigits = 0;

			return noOfDigits;
		}
	}
}
