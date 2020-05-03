using Kvadratnoe_Uravnenie;
using NUnit.Framework;
using KvUrLibrary;

namespace NUnitTest
{

    public class Tests
    {
        private KvUrService _kvUrService;

        [SetUp]
        public void Setup()
        {
            _kvUrService = new KvUrService();
        }

        [Test]
        [TestCase(1, 1, -6, 25)]
        [TestCase(2, 5, -7, 81)]
        [TestCase(16, -8, 1, 0)]
        [TestCase(9, -6, 2, -36)]
        [TestCase(2, 3, 4, -23)]
        [TestCase(int.MinValue, int.MinValue, int.MinValue, 0)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, 0)]
        [TestCase(int.MinValue, int.MaxValue, 0, 0)]
        public void Test1(int a, int b, int c, int expected)
        {
            //Prepare

            //Execute
            var result = _kvUrService.Discriminant(a, b, c);

            //Assert

            Assert.AreEqual(expected, result);
        }
    }
}