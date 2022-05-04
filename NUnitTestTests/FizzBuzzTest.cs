using NUnit.Framework;
using NUnitTest.Fundamentals;

namespace NUnitTestTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void GetOutput_InputIsDivisibileBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            NUnit.Framework.Assert.That(result, Is.EqualTo("Fizzbuzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputIsDivisibileBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);
            NUnit.Framework.Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibileBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            NUnit.Framework.Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibileBy3Or5_ReturnInputNumber()
        {
            var result = FizzBuzz.GetOutput(7);
            NUnit.Framework.Assert.That(result, Is.EqualTo(result));
        }

    }
}