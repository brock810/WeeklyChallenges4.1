using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenSum = 0;
            int oddSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = int.MaxValue;

            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }

            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }

            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }

            if (str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }

            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = number1;

            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }

            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }

            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }

            return smallestNumber;
        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }


        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength3 + sideLength1 > sideLength2);
        }


        public bool IsStringANumber(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }

            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var n = numbers.Where(num => num % 2 == 0);
            if (n.Count() == 0)
                return 0;
            return n.Average();

        }
        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(number), "Number cannot be negative.");
            }

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}