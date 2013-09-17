using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibEvenSum = Problems.FibonacciEvenSumLimit(4000000);

            Console.WriteLine("Sum of even values is: " + fibEvenSum);
            Console.ReadLine();
        }
    }
}
