using Bosscoder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Bosscoder.Week_6.Assignment_Questions
{
    public class PalindromePairs
    {
        /*  Declare a dicitionary , a hashset and a result List
         *  Add index and word combination to dictionary
         *  Add no of characters of each word to hashset
         *  Iterate through the words 
         *      - Take reverse of each word
         *      - check if dictionary contains reverse and get corresponding value
         *          + Add it to result
         *      - Iterate through the length hash , Check for length match length since it would be already added and return
         *      - else 
         *          check for palindrome of reverse from 0 to len -1-k or from k to len-1
         */
        /*ToDo : Runtime error , check and complete , revise and revisit*/
        public List<List<int>> Solve(List<string> input)
        {
            Dictionary<string, int> wordIndexPairs = new Dictionary<string, int>();
            List<int> wordLengths = new List<int>();
            List<List<int>> result = new List<List<int>>();

            if (input == null || input.Count < 2)
                return result;

            foreach(var item in input.Select((x,i) => new { Item = x, Index = i }))
            {
                wordIndexPairs[item.Item] = item.Index;
                wordLengths.Add(item.Item.Length);
            }

            for(int i = 0; i < input.Count; i++)
            {
                var chArray = input[i].ToCharArray();
                Array.Reverse(chArray);
                string reverse = new string(chArray);

                if (wordIndexPairs.ContainsKey(reverse) && wordIndexPairs.TryGetValue(reverse, out int u))
                    result.Add(new List<int>() { i, u });
                
                foreach(var k in wordLengths)
                {
                    if (k == reverse.Length)
                        continue;

                    if(IsPalindrome(reverse, 0, reverse.Length-1-k))
                    {
                        string subString = reverse.Substring(reverse.Length - k);

                        if (wordIndexPairs.ContainsKey(subString))
                            result.Add(new List<int>() {i, wordIndexPairs[subString]});
                    }

                    if(IsPalindrome(reverse, k, reverse.Length-1))
                    {
                        string subString = reverse.Substring(0, k);

                        if (wordIndexPairs.ContainsKey(subString))
                            result.Add(new List<int>() { wordIndexPairs[subString], i});
                    }
                }
            }

            return result;
        }

        private bool IsPalindrome(string reverse, int k, int v)
        {
            while(k < v)
            {
                if (reverse[k++] != reverse[v--])
                    return false;                         
            }

            return true;
        }
    }
}
