using NUnit.Framework;
using Task7;

namespace Task7.Test
{
    public class StartNumbersTests
    {
        [SetUp]
        public void Input145_Expected13()
        {

            //arrange
            int m = 145;


            //act

            StartNumber testStartNumber = new StartNumber();
            int actual = testStartNumber.FirstNumberOfRange(m);

            //assert

            Assert.AreEqual(13, actual);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        public void Input225_Expected15()
        {

            //arrange
            int m = 225;


            //act

            StartNumber testStartNumber = new StartNumber();
            int actual = testStartNumber.FirstNumberOfRange(m);

            //assert

            Assert.AreEqual(15, actual);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}