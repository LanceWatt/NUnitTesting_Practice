using NUnit.Framework;
using NUnitTest.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestTests
{
    [TestFixture]
    public class MathTests
    {

        private Maths _math;

        //  Set Up
        [SetUp]
        public void Setup()
        {
            _math = new Maths();
        }

        //  Tear Down-- used for integration tests
        [Test]
        [Ignore("No need to test this because my maths is very good")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result == 3);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArguement(int a, int b, int expectedResulted)
        {
            var result = _math.Max(a, b);
            Assert.That(result == expectedResulted);
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

        }
    }
}
