using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechGig.Practice
{
    internal class PasswordEnhancer : IExecute
    {
        int digitCount = 0;
        int lowerCaseLetterCount = 0;
        int upperCaseLetterCount = 0;
        Dictionary<string, int> replacedDict = new Dictionary<string, int>();

        /*Strong password has 6-20 characters with atleast one small ch, one capital letter and one digit */
        public void Execute()
        {
            try
            {
                string password = Console.ReadLine();
                string enhancedPassword = EnhancePassword(password);
                Console.WriteLine(enhancedPassword);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

            }
        }

        private string EnhancePassword(string password)
        {
            CalculateIndividualCounts(password);

            password = ValidateMinLength(password);

            password = ValidateMaxLength(password);

            password = ValidateDigitCount(password);

            password = ValidateLowerCaseCount(password);

            password = ValidateUpperCaseCount(password);

            return password;
        }

        private string ValidateUpperCaseCount(string password)
        {
            if (upperCaseLetterCount > 0)
                return password;

            int addedIndex = 0;

            if (digitCount > 1)
            {
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsDigit(ch) && !replacedDict.Values.Contains(index); });
                password = new StringBuilder(password) { [requiredPair.Item1] = 'A' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else if (lowerCaseLetterCount > 1)
            {
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsLower(ch) && !replacedDict.Values.Contains(index); });
                password = new StringBuilder(password) { [requiredPair.Item1] = 'A' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else
            {
                var requiredPair = Evaluate(password, (ch, index) => { return !char.IsDigit(ch) && !char.IsLower(ch) && !replacedDict.Values.Contains(index); });               
                password = new StringBuilder(password) { [requiredPair.Item1] = 'A' }.ToString();
                addedIndex = requiredPair.Item1;
            }

            replacedDict.Add("UpperCase", addedIndex);
            upperCaseLetterCount++;            

            return password;
        }

        private string ValidateLowerCaseCount(string password)
        {
            if (lowerCaseLetterCount > 0)
                return password;
            
                int addedIndex = 0;

            if (digitCount > 1)
            {               
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsDigit(ch) && !replacedDict.Values.Contains(index); });             
                password = new StringBuilder(password) { [requiredPair.Item1] = 'a' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else if (upperCaseLetterCount > 1)
            {
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsUpper(ch) && !replacedDict.Values.Contains(index); });        
                password = new StringBuilder(password) { [requiredPair.Item1] = 'a' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else
            {
                var requiredPair = Evaluate(password, (ch, index) => { return !char.IsDigit(ch) && !char.IsUpper(ch) && !replacedDict.Values.Contains(index); });
                password = new StringBuilder(password) { [requiredPair.Item1] = 'a' }.ToString();
                addedIndex = requiredPair.Item1;
            }

            replacedDict.Add("LowerCase", addedIndex);
            lowerCaseLetterCount++;            

            return password;
        }

        private string ValidateDigitCount(string password)
        {
            if (digitCount != 0)
                return password;

            int addedIndex = 0;

            if (lowerCaseLetterCount > 1)
            {
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsLower(ch) && !replacedDict.Values.Contains(index); });
                password = new StringBuilder(password) { [requiredPair.Item1] = '0' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else if (upperCaseLetterCount > 1)
            {
                var requiredPair = Evaluate(password, (ch, index) => { return char.IsUpper(ch) && !replacedDict.Values.Contains(index); });                   
                password = new StringBuilder(password) { [requiredPair.Item1] = '0' }.ToString();
                addedIndex = requiredPair.Item1;
            }
            else
            {
                var requiredPair = Evaluate(password, (ch, index) => { return !char.IsUpper(ch) && !char.IsLower(ch) && !replacedDict.Values.Contains(index); });                  
                password = new StringBuilder(password) { [requiredPair.Item1] = '0' }.ToString();
                addedIndex = requiredPair.Item1;
            }

            replacedDict.Add("Digit", addedIndex);
            digitCount++;            

            return password;
        }

        private string ValidateMaxLength(string password)
        {
            while (password.Length > 20)
            {
                if (digitCount > 1)
                {
                    var chInd = password.Where(ch => char.IsDigit(ch)).Select((ch, index) => new { Index = index, Character = ch }).First();
                    password = password.Remove(chInd.Index, 1);
                    digitCount--;
                }
                else if (lowerCaseLetterCount > 1)
                {
                    var chInd = password.Where(ch => char.IsLower(ch)).Select((ch, index) => new { Index = index, Character = ch }).First();
                    password = password.Remove(chInd.Index, 1);
                    lowerCaseLetterCount--;
                }
                else if (upperCaseLetterCount > 1)
                {
                    var chInd = password.Where(ch => char.IsUpper(ch)).Select((ch, index) => new { Index = index, Character = ch }).First();
                    password = password.Remove(chInd.Index, 1);
                    upperCaseLetterCount--;
                }
            }

            return password;
        }

        private string ValidateMinLength(string password)
        {
            while (password.Length < 6)
            {
                if (digitCount == 0)
                {
                    password = string.Concat(password, "0");
                    replacedDict.Add("Digit", password.Length + 1);
                    digitCount++;
                }

                if (lowerCaseLetterCount == 0)
                {
                    password = string.Concat(password, 'a');
                    replacedDict.Add("LowerCase", password.Length + 1);
                    lowerCaseLetterCount++;
                }

                if (upperCaseLetterCount == 0)
                {
                    password = string.Concat(password, 'A');
                    replacedDict.Add("UpperCase", password.Length + 1);
                    upperCaseLetterCount++;
                }

                password = string.Concat(password, "a");
            }

            return password;
        }

        private void CalculateIndividualCounts(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                    digitCount++;

                if (!char.IsLetter(password[i]))
                    continue;

                if (char.IsLower(password[i]))
                    lowerCaseLetterCount++;
                else if (char.IsUpper(password[i]))
                    upperCaseLetterCount++;
            }
        }

        private (int,char) Evaluate(string password, Func<char, int, bool> pred)
        {            
          var chi = 
            password.Select((ch, index) =>
            {
                if (pred(ch, index))
                    return new { Index = index, Character = ch };

                return new { Index = -1, Character = '-' };
            })
            .Where(ch => ch.Index != -1)
            .Select((ch, index) => new { Index = ch.Index, Character = ch.Character }).First();

            return (chi.Index, chi.Character);
        }
    }
}