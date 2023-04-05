using System.Collections.Generic;
using System.Linq;

namespace TechGig.Practice
{
    public class GenerateDocument : IExecute
    {
        public void Execute()
        {
            bool canGenerate = CanGenerateDocument("abcabc", "aabbccc");
        }

        public bool CanGenerateDocument(string characterList, string document)
        {
            bool canGenerate = false;

            var charUniqueList = GetUniqueOccurrences(characterList);
            var docUniqueList = GetUniqueOccurrences(document);

            foreach(var uniqueList in docUniqueList)
            {
                if (charUniqueList.Contains(uniqueList))
                    canGenerate = canGenerate && true;
                else
                    return false;
            }

            return canGenerate;
        }

        private Dictionary<char, int> GetUniqueOccurrences(string input)
        {
            Dictionary<char, int> uniqueOccurrences = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if(!uniqueOccurrences.ContainsKey(c))
                {
                    uniqueOccurrences[c] = 1;
                }
                else
                {
                    uniqueOccurrences[c] += 1;
                }
            }

            return uniqueOccurrences;
        }
    }
}
