using ClassLib_for_less2;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        private SkierLib _skierService;

        [SetUp]
        public void Setup()
        {
            _skierService = new SkierLib();

        }

        [Test]
        [TestCase(0, 10, 20, 25, 1, 5)]
        [TestCase(0, 0, 1, 25, 1, 0)]
        [TestCase(0, 1, 0, 25, 1, 1)]
        [TestCase(0, 100, 20, 25, 2, 2)]
        [TestCase(0, int.MinValue, 1000, 100, 1, 0)]
        [TestCase(0, int.MaxValue, 100, 25, 1, 1)]
        [TestCase(0, 5, int.MinValue, 25, 1, 1)]
        [TestCase(0, 5, int.MaxValue, 25, 1, 1)]
        [TestCase(0, 5, 20, int.MaxValue, 1, 2)]
        [TestCase(0, 5, 20, int.MinValue, 1, 0)]
        [TestCase(0, 5, 20, 0, 1, 0)]
        [TestCase(0, 5, 20, 25, int.MaxValue, 0)]
        [TestCase(0, 5, 20, 25, int.MinValue, 0)]
        public void Test1(double kmperday, double km, double allkm, int percent, int days, int expected)
        {
            var result = _skierService.Skier(kmperday, km, allkm, percent, days);

            Assert.AreEqual(expected, result);
        }
    }
}