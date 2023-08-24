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