#Arrays and Maths ![image](./Images/array/array-icon-512x512-slztyf8v.png)
[https://platform.bosscoderacademy.com/dashboard/course/5ZySkZ8nRde22ZflWVge?attended=true]

##Warmup Questions

###Fizz Buzz

- Given an integer n, return a string array answer (1-indexed) where:

	answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
	answer[i] == "Fizz" if i is divisible by 3.
	answer[i] == "Buzz" if i is divisible by 5.
	answer[i] == i (as a string) if none of the above conditions are true.
 

	- Example 1:

		Input: n = 3
		Output: ["1","2","Fizz"]

	- Example 2:

		Input: n = 5
		Output: ["1","2","Fizz","4","Buzz"]

	- Example 3:

		Input: n = 15
		Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 

	- Constraints:

		1 <= n <= 104

###MatrixDiagonalsSum

- Given a square matrix mat, return the sum of the matrix diagonals.

	Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal. 

	- Example 1:


		Input: mat = [[1,2,3],
              [4,5,6],
              [7,8,9]]
		Output: 25
		Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
		Notice that element mat[1][1] = 5 is counted only once.

	- Example 2:

		Input: mat = [[1,1,1,1],
              [1,1,1,1],
              [1,1,1,1],
              [1,1,1,1]]
		Output: 8

	- Example 3:

		Input: mat = [[5]]
		Output: 5
 

###ArrayConcatenation

- Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

	Specifically, ans is the concatenation of two nums arrays.

	Return the array ans.

 

	- Example 1:

		Input: nums = [1,2,1]
		Output: [1,2,1,1,2,1]
		Explanation: The array ans is formed as follows:
		- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
		- ans = [1,2,1,1,2,1]

	- Example 2:

		Input: nums = [1,3,2,1]
		Output: [1,3,2,1,1,3,2,1]
		Explanation: The array ans is formed as follows:
		- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
		- ans = [1,3,2,1,1,3,2,1] 

	- Constraints:

		n == nums.length
		1 <= n <= 1000
		1 <= nums[i] <= 1000

###MostWordsFound

- A sentence is a list of words that are separated by a single space with no leading or trailing spaces.

	You are given an array of strings sentences, where each sentences[i] represents a single sentence.

	Return the maximum number of words that appear in a single sentence.

 

	- Example 1:

		Input: sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"]
		Output: 6
		Explanation: 
		- The first sentence, "alice and bob love leetcode", has 5 words in total.
		- The second sentence, "i think so too", has 4 words in total.
		- The third sentence, "this is great thanks very much", has 6 words in total.
		Thus, the maximum number of words in a single sentence comes from the third sentence, which has 6 words.

	- Example 2:

		Input: sentences = ["please wait", "continue to fight", "continue to win"]
		Output: 3
		Explanation: It is possible that multiple sentences contain the same number of words. 
		In this example, the second and third sentences (underlined) have the same number of words. 

	Constraints:

		1 <= sentences.length <= 100
		1 <= sentences[i].length <= 100
		sentences[i] consists only of lowercase English letters and ' ' only.
		sentences[i] does not have leading or trailing spaces.
		All the words in sentences[i] are separated by a single space.

##Assignment Questions

###Trapping Rain Water

- Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

	- Example 1:


		Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
		Output: 6
		Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.

	- Example 2:

		Input: height = [4,2,0,3,2,5]
		Output: 9
 

	- Constraints:

		n == height.length
		1 <= n <= 2 * 104
		0 <= height[i] <= 105

###Maximum of Absolute Value Expression

- Given two arrays of integers with equal lengths, return the maximum value of:

	|arr1[i] - arr1[j]| + |arr2[i] - arr2[j]| + |i - j|

	where the maximum is taken over all 0 <= i, j < arr1.length.

 

	- Example 1:

		Input: arr1 = [1,2,3,4], arr2 = [-1,4,5,6]
		Output: 13

	- Example 2:

		Input: arr1 = [1,-2,-5,0,10], arr2 = [0,-2,-1,-7,-4]
		Output: 20
 

	Constraints:

		2 <= arr1.length == arr2.length <= 40000
		-10^6 <= arr1[i], arr2[i] <= 10^6

###Spiral Matrix II
- Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.
 
	- Example 1:

		Input: n = 3
		Output: [[1,2,3],[8,9,4],[7,6,5]]

	- Example 2:

		Input: n = 1
		Output: [[1]]
 
	Constraints:

		1 <= n <= 20

###Maximum Gap
- Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.

	You must write an algorithm that runs in linear time and uses linear extra space.

 
	- Example 1:

		Input: nums = [3,6,9,1]
		Output: 3
		Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.

	- Example 2:

		Input: nums = [10]
		Output: 0
		Explanation: The array contains less than 2 elements, therefore return 0.
 
	Constraints:

		1 <= nums.length <= 105
		0 <= nums[i] <= 109