29. Divide Two Integers

Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
Return the quotient after dividing dividend by divisor.

Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231, 231 − 1].
For this problem, if the quotient is strictly greater than 2 pow 31 - 1,
then return 2 pow 31 - 1, and if the quotient is strictly less than -2 pow 31, then return -2 pow 31

Constraints:

-231 <= dividend, divisor <= 231 - 1
divisor != 0


1310. XOR Queries of a Subarray

You are given an array arr of positive integers. You are also given the array queries where queries[i] = [lefti, righti].
For each query i compute the XOR of elements from lefti to righti (that is, arr[lefti] XOR arr[lefti + 1] XOR ... XOR arr[righti] ).
Return an array answer where answer[i] is the answer to the ith query.

477. Total Hamming Distance

The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
Given an integer array nums, return the sum of Hamming distances between all the pairs of the integers in nums

Example 1:

Input: nums = [4,14,2]
Output: 6
Explanation: In binary representation, the 4 is 0100, 14 is 1110, and 2 is 0010 (just
showing the four bits relevant in this case).

The answer will be:
HammingDistance(4, 14) + HammingDistance(4, 2) + HammingDistance(14, 2) = 2 + 2 + 2 = 6.
Example 2:

Input: nums = [4,14,4]
Output: 4

Constraints:

1 <= nums.length <= 104
0 <= nums[i] <= 109
The answer for the given input will fit in a 32-bit integer.


793. Preimage Size of Factorial Zeroes Function

Let f(x) be the number of zeroes at the end of x!. Recall that x! = 1 * 2 * 3 * ... * x and by convention, 0! = 1.

For example, f(3) = 0 because 3! = 6 has no zeroes at the end, while f(11) = 2 because 11! = 39916800 has two zeroes at the end.
Given an integer k, return the number of non-negative integers x have the property that f(x) = k.

Constraints:

0 <= k <= 109