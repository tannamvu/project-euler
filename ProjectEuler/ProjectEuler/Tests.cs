using System;
using NUnit.Framework;

namespace ProjectEuler
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FibonacciEvenValuesSum()
        {
            const int resultShouldBe = 4613732;
            var result = Problems.FibonacciEvenSumLimit();
            Assert.AreEqual(result, resultShouldBe);
        }

        [Test]
        public void GetRandomArraySequence()
        {
            var resultShouldBe = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var result = Problems.GetRandomSequence(12);
            Assert.AreEqual(12, result.Length);
            Array.Sort(result);
            Assert.AreEqual(result, resultShouldBe);
        }

        [Test]
        public void FindDuplicatesInArrayInt()
        {
            var dupsArr = new[] { 0, 1, 1, 2, 6, 6, 7, 8, 8, 9, 10, 11 };
            const string resultShouldBe = "1,6,8";
            var result = Problems.FindDuplicatesInArray(dupsArr, 12);
            Assert.AreEqual(result, resultShouldBe);
        }
        
        [Test]
        public void FindMultiplesOfThreeAndFiveInNumberTotal()
        {
            const int resultShouldBe = 78;
            var result = Problems.MultiplesOfFiveAndThree(20);
            Assert.AreEqual(result, resultShouldBe);
        }

        [Test]
        public void HighestPalindromeInThreeDigits()
        {
            const int resultShouldBe = 906609;
            var result = Problems.HighestPalindromeNumberFromThreeDigits();
            Assert.AreEqual(result, resultShouldBe);
        }

        [Test]
        public void IsPalindromeNumber()
        {
            const bool resultShouldBe = true;
            var result = Problems.IsPalindromeNumber(9009);
            Assert.AreEqual(result, resultShouldBe);
        }
    }
}
