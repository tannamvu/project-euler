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
    }
}
