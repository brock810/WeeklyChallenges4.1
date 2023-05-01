using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                throw new ArgumentNullException(nameof(vals));
            }

            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count()== 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$");

            return regex.IsMatch(password);
        }
 

        public char GetFirstLetterOfString(string val)
        {
            string str = val;
            char firstLetter = str.Substring(0, 1)[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            string str = val;
            char lastLetter = str[str.Length- 1];
            return lastLetter;
        }
            public decimal Divide(decimal dividend, decimal divisor)
            {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
            }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty", nameof(nums));
            }

            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int index = 0;

            for (int i = 1; i < 100; i += 2)
            {
                odds[index] = i;
                index++;
            }

            return odds;
        }
        

        public void ChangeAllElementsToUppercase(string[] words)
        {
            {
                if (words == null)
                {
                    throw new ArgumentNullException(nameof(words), "The array cannot be null");
                }

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != null)
                    {
                        words[i] = words[i].ToUpper();
                    }
                }
            }

        }
    }
}
