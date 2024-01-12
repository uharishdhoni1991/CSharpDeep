using System;
using System.Collections.Generic;
using System.Linq;

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

		public void MoveZeroes(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return;

			int arrLength = nums.Length;

			int j = 0;

			for (int i = 0; i < arrLength; i++)
			{
				if (nums[i] == 0)
					continue;

				int temp = nums[j];
				nums[j] = nums[i];
				nums[i] = temp;
				j++;
			}
		}

		public int[] SortArrayByParity(int[] nums)
		{
			int[] newArray = new int[nums.Length];
			int oddCount = nums.Length-1;
			int evenCount = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] % 2 == 0)
				{
					newArray[evenCount] = nums[i];
					evenCount++;
				}
				else
				{
					newArray[oddCount] = nums[i];
					oddCount--;
				}
			}

			return newArray;
		}

		public int HeightChecker(int[] heights) /*To Do : Improve Performance*/
		{
			int arrLength = heights.Length;
			int[] newArray = new int[arrLength];

			int temp = Int32.MaxValue;
			int matchingIndices = 0;

			for (int j = 0; j < arrLength; j++)
			{
				newArray[j] = heights[j];
			}

			
			for (int j = 0; j < arrLength; j++)
			{	 
				for (int i = j + 1; i < arrLength; i++)
				{
					if(heights[j] > heights[i])
                    {
						temp = heights[i];
						heights[i] = heights[j];
						heights[j] = temp;
                    }
				}
			}
			

			for (int i = 0; i < arrLength; i++)
			{
				if (newArray[i] != heights[i])
					matchingIndices++;
			}

			return matchingIndices;
		}

		public int ThirdMax(int[] nums)/*To Do : Improve Performance*/
		{
			int arrLength = nums.Length;

			HashSet<int> hash = new HashSet<int>();
			int firstMax = int.MinValue;
			int secondMax = int.MinValue;
			int thirdMax = int.MinValue;	

			for(int i=0; i<arrLength; i++)
            {
				int current = nums[i];

				if (!hash.Contains(current))
				{
					if (nums[i] > firstMax)
					{
						thirdMax = secondMax;
						secondMax = firstMax;
						firstMax = current;
					}
					else if (nums[i] > secondMax)
					{
						thirdMax = secondMax;
						secondMax = current;
					}
					else if(nums[i] > thirdMax)
					{
						thirdMax = current;
					}

					hash.Add(current);
				}
            }

			return hash.Count >= 3 ? thirdMax : firstMax;
		}

		public IList<int> FindDisappearedNumbers(int[] nums)
		{
			Array.Sort(nums);
			
			for(int i=0; i < nums.Length; i++)
            {
				int temp = Math.Abs(nums[i]) - 1;

				if (nums[temp] > 0)
					nums[temp] = -nums[temp];				

            }

			int j = 0;
			for(int i =0; i< nums.Length; i++)
            {
				if(nums[i] > 0)
                {
					nums[j] = i + 1;
					j++;
                }
            }

			return nums.Take(j).ToList();
		}

		public bool ContainsDuplicateHashsetVersion(int[] nums)
		{
			bool containsDuplicate = false;
			int numsCount = nums.Count();

			if (numsCount < 0 || numsCount > Math.Pow(10, 5))
				return containsDuplicate;

			for (int i = 0; i < numsCount; i++)
            {		
				for (int j = i + 1; j < numsCount; j++)
				{
					containsDuplicate = containsDuplicate || nums[i] == nums[j];

					if (containsDuplicate)
						break;
				}

				if (containsDuplicate)
					break;
            }

			return containsDuplicate;
        }

		public bool ContainsDuplicateHashTableVersion(int[] nums)
        {
			HashSet<int> hashSet = new HashSet<int>();

			for(int i=0; i<nums.Length;i++)
            {
				if(!hashSet.Add(nums[i]))                
					return true;                
            }

			return false;
        }

		public bool ContainsDuplicateSortedArrayVersion(int[] nums)
		{
			int[] sortedArray = nums.OrderBy(num => num).ToArray();

			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (sortedArray[i] == sortedArray[i + 1])
					return true;
			}

			return false;
		}

		public int MissingNumber(int[] nums)
		{
			if (nums.Count() < 1 && nums.Count() > Math.Pow(10, 4))
				return 0;

			int[] sortedArray = nums.OrderBy(num => num).ToArray();

			if (sortedArray[nums.Count() -1] != nums.Count())
				return nums.Count();

			for (int i = nums.Count() - 1; i >= 0; i--)
			{
				if (i - 1 < 0)
					return 0;				
				else if (!(sortedArray[i] == sortedArray[i - 1] + 1))
					return sortedArray[i] - 1;
			}

			return 0;
		}

		public int ConvertRomanToNumber(string s)
		{
			int num = 0;
			char prev = 'O';
			char[] chars = s.ToCharArray();

			for (int i = chars.Length - 1; i >= 0; i--)
			{
				char c = chars[i];

				if (c == 'M')				
					num += 1000;					
				else if (c == 'D')				
					num += 500;
				else if (c == 'C')
				{
					if (prev == 'D')
						num -= 100;
					else if (prev == 'M')
						num -= 100;
					else
						num += 100;		
				}
				else if (c == 'L')				
					num += 50;
				else if (c == 'X')
				{
					if (prev == 'L')
						num -= 10;
					else if(prev == 'C')
						num -= 10;
					else
						num += 10;					
				}
				else if (c == 'V')				
					num += 5;				
				else if (c == 'I')
				{
					if (prev == 'V')
						num -= 1;
					else if (prev == 'X')
						num -= 1;
					else
						num += 1;
				}

				prev = c;
			}

			return num;
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

		public int StrStr(string haystack, string needle)
		{
			if (string.IsNullOrEmpty(needle) && string.IsNullOrEmpty(haystack))
				return -1;

			int count = 0;
			int n = 0;

			for (int h = 0; h < haystack.Length; h++)
			{
				if (haystack[h] == needle[n])
					count++;
				else
				{
					count = 0;
					h -= n;
					n = 0;
					continue;
				}

				if (count == needle.Length)
					return h - needle.Length + 1;


				n++;
			}

			return -1;
		}

	}
}