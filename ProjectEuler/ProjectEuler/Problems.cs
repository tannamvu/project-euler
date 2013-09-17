using System;

namespace ProjectEuler
{
    public static class Problems
    {
        /// <summary>
        /// Fibonacci sequence whose values do not exceed the limit, returns sum of the even-valued terms
        /// </summary>
        /// <param name="limit">maximum fibonacci sequence</param>
        /// <returns>total of even numbers</returns>
        public static int FibonacciEvenSumLimit(int limit)
        {
            var x = 1;
            var y = 2;
            var sum = 2;

            while ((x + y) < 4000000)
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
        public static void FindDuplicatesInArray(int[] intArray, int limit = 30)
        {
            for (var x = 0; x <= limit; x++)
            {
                var counter = 0;

                for (var i = 0; i < intArray.Length; i++)
                {
                    if (x == intArray[i])
                    {
                        counter++;
                    }

                    if (counter <= 1)
                    {
                        continue;
                    }
                    Console.WriteLine(x);
                    break;
                }
            }
        }
    }
}
