using System;
using System.Globalization;
using System.Text;

namespace ProjectEuler
{
    public static class Problems
    {
        /// <summary>
        /// Fibonacci sequence whose values are even and do not exceed the limit. Returns sum of the even-valued terms
        /// </summary>
        /// <param name="limit">maximum fibonacci sequence</param>
        /// <returns>total of even numbers</returns>
        public static int FibonacciEvenSumLimit(int limit = 4000000)
        {
            var x = 1;
            var y = 2;
            var sum = 2;

            while ((x + y) < limit)
            {
                var total = x + y;
                x = y;
                y = total;

                if (total % 2 == 0)
                {
                    sum += total;
                }
            }

            return sum;
        }

        /// <summary>
        /// Given n, return an array size of sequence to n in a random order
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] GetRandomSequence(int n)
        {
            var random = new Random();
            var arrInt = new int[n];

            for (var i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = i;
            }

            for (var j = arrInt.Length - 1; j > 0; j--)
            {
                var toSwap = random.Next(0, arrInt.Length - 1);
                var temp = arrInt[j];
                arrInt[j] = arrInt[toSwap];
                arrInt[toSwap] = temp;
            }

            return arrInt;
        }

        /// <summary>
        /// Find duplicates in an array of ints. 
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="limit">maximum duplicate to find.</param>
        public static string FindDuplicatesInArray(int[] intArray, int limit = 30)
        {
            var dups = string.Empty;

            for (var x = 0; x <= limit; x++)
            {
                var counter = 0;

                for (var i = 0; i < intArray.Length; i++)
                {
                    if (x == intArray[i])
                    {
                        counter++;
                    }else
                    {
                        counter = 0;
                    }

                    if (counter <= 1)
                    {
                        continue;
                    }
                    Console.WriteLine(x);
                    dups = dups + x + ",";
                    break;
                }
            }

            return dups.TrimEnd(',').ToString();
        }

        /// <summary>
        /// All natural numbers below the limit (default is 10) that are multiples of 5 and 3 
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static int MultiplesOfFiveAndThree(int limit = 10)
        {
            var total = 0;

            for(var i = 1; i < limit; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                    continue;
                }

                if (i % 5 == 0)
                {
                    total += i;
                }
            }

            return total;
        }

        public static long LargestPrimeFactor(long number = 600851475143)
        {
            var x = 2;

            while (x * x < number)
            {
                if (number % x == 0)
                {
                    number /= x;
                }else
                {
                    x++;
                }
            }

            return number;
        }

        public static bool IsPrimeNumber(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (var i = 3; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the highest valid paladrome number based on the product of 3 digit numbers. 
        /// </summary>
        /// <returns></returns>
        public static int HighestPalindromeNumberFromThreeDigits()
        {
            var hightest = 0;

            for (var i = 100; i < 1000; i++)
            {
                for (var x = 100; x < 1000; x++)
                {
                    var temp = x * i;

                    if (IsPalindromeNumber(temp))
                    {
                        if (temp > hightest)
                        {
                            hightest = temp;
                        }
                    }
                }
            }

            return hightest;
        }

        /// <summary>
        /// Check if number is a valid palindrome number, ie 9009 (the same backwards). 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPalindromeNumber(int number)
        {
            var temp = number.ToString(CultureInfo.InvariantCulture);
            var arrayStr = temp.ToCharArray();
            Array.Reverse(arrayStr);
            var reversed = new string(arrayStr);
            var reversedNumber = int.Parse(reversed);
            return number == reversedNumber;
        }
    }
}
