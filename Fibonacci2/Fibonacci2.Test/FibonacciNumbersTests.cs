using NUnit.Framework;
using Fibonacci2;
using System.Collections.Generic;

namespace Fibonacci2.Test
{
    public class FibonacciNumbersTests
    {
        [SetUp]
        public void Setup()
        {
            //arrange
            //int start = 23;
            //int end = 40;
            //expected = 34;
            

            //act
            FibonacciNumbers testrange = new FibonacciNumbers();
           // int actual = testrange.GenerateInRange(23, 40);

            //assert
            //Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test1()
        {
            List<int> expected = new List<int>() { 34, 56, 77 };
            List<int> actual = testrange.GenerateInRange ();
            Assert.Pass();
        }
    }
}