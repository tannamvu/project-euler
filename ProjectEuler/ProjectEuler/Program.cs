using System;
using System.Globalization;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            var hightest = Problems.HighestPalindromeNumberFromThreeDigits();

            Console.WriteLine("highest palindrome: " + hightest);
            Console.ReadLine();
        }
    }
}
