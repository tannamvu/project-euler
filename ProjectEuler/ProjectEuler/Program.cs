using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            var total = Problems.LargestPrimeFactor();
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
