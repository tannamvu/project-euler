using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 2;
            var sum = 2;

            while ((x + y) < 4000000)
            {
                var total = x + y;
                Console.WriteLine(total);
                x = y;
                y = total;

                if (total % 2 == 0)
                {
                    sum += total;
                }
            }

            Console.WriteLine("Sum of even values is: " + sum);
            Console.ReadLine();
        }
    }
}
