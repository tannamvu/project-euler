using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            var intArray = new int[]
                               {
                                   0,
                                   2,
                                   3,
                                   3,
                                   4,
                                   4,
                                   5,
                                   5,
                                   5,
                                   6,
                                   6, 30, 30
                               };

            Problems.FindDuplicatesInArray(intArray);

            var a = Problems.GetRandomSequence(10);
            Console.ReadLine();
        }
    }
}
