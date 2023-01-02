using System;
using System.Net;
using NUnit.Framework;

namespace ZbW.Testing.MathExtended.Library.UnitTests
{
    [TestFixture]
    public class ExtendedOperationTests
    {
        [Test]
        public void Percent_Percent_Return10()
        {
            var sut = new ExtendedOperation();

            var result = sut.Percent(20, 100);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Exponent_Exponent_Return32()
        {
            var sut = new ExtendedOperation();

            var result = sut.Exponent(2, 5);

            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void Factorial_Factorial_Return120()
        {
            var sut = new ExtendedOperation();

            var result = sut.Factorial(5);

            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_Factorial_ThrowOverFlowException()
        {
            var sut = new ExtendedOperation();

            void Calculation() => sut.Factorial(15);

            Assert.Throws<OverflowException>(Calculation, "Does not Throw the correct exception.");
        }

        [Test]
        public void Modulo_Modulo_Return0()
        {
            var sut = new ExtendedOperation();

            var result = sut.Modulo(10, 2);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}