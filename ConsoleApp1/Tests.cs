using NUnit.Framework;
using NUnit.Framework.Legacy;
using ConsoleApp1;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    public class AlgoTests
    {
        private Algor _algor;

        [SetUp]
        public void Setup()
        {
            _algor = new Algor();
        }

        [Test]
        public void Test1()
        {
            bool par2 = true;
            int par3 = 10;
            int par1 = 20;

            int result = _algor.calcresult(par2, par3, par1);

            ClassicAssert.AreEqual(238, result);
        }

        [Test]
        public void Test2()
        {
            bool par2 = false;
            int par3 = 0;
            int par1 = 760;
            int result = _algor.calcresult(par2, par3, par1);
            ClassicAssert.AreEqual(1698, result);
        }
        [Test]
        public void TestException()
        {
            bool par2 = false;
            int par3 = -2;
            int par1 = 20;
            Assert.Throws<System.ArgumentException>(() => _algor.calcresult(par2, par3, par1));
        }

        [Test]
        [Timeout(1000)]
        public void TestCalcResult_Timeout()
        {
            bool par2 = true;
            int par3 = 1340;
            int par1 = 2054;

            int result = _algor.calcresult(par2, par3, par1);

            ClassicAssert.AreEqual(10449, result);
        }

        [Test]
        [TestCase(true, 1024, 2320, ExpectedResult = 10299)]
        [TestCase(false, 0, 0, ExpectedResult = 178)]
        public int TestCalcResult(bool par2, int par3, int par1)
        {
            int result = _algor.calcresult(par2, par3, par1);
            return result;
        }

    }
}
