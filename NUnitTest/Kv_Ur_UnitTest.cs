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
        [TestCase(9, 6, 3, -72)]
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

        [Test]
        [TestCase(9, 6, -72, new double[] { 0d, 0d })]
        [TestCase(16, -8, 0, new double[] { 0.25d, 0d })]
        [TestCase(2, 5, 81, new double[] { 1.0d, -3.5d })]
        [TestCase(int.MinValue, 5, 81, new double[] { 0d })]
        [TestCase(2, int.MinValue, 81, new double[] { 0d })]
        [TestCase(2, int.MaxValue, 81, new double[] { 0d })]
        [TestCase(int.MaxValue, 5, 81, new double[] { 0d })]
        [TestCase(2, 5, double.MaxValue, new double[] { 0d })]
        [TestCase(2, 5, double.MinValue, new double[] { 0d })]
        public void Test2(int a, int b, double discriminant, double[] expected)
        {
            //Prepare

            //Execute
            var result = _kvUrService.Roots(a, b, discriminant);

            //Assert

            Assert.AreEqual(expected, result);
        }
    }
}