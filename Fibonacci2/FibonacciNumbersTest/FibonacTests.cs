using NUnit.Framework;

namespace Fibonacci2
{
    public class FibonacciNumbersTests
    {
        [SetUp]
        public void Setup()
        {

            //arrange
            int start = 23;
            int end = 40;
            int expected = 34;

            //act
            FibonacciNumbers testrange = new FibonacciNumbers;
            int actual = testrange.GenerateInRange(start, end);
            
            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}