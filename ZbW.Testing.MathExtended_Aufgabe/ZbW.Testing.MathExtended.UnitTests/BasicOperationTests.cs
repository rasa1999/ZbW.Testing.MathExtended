using System.Runtime.InteropServices;
using NUnit.Framework;

namespace ZbW.Testing.MathExtended.Library.UnitTests
{

    [TestFixture]
    public class BasicOperationTests
    {
        readonly int z1 = 10;
        readonly int z2 = 5;

        [Test]
        public void Addition_Addition_Return15()
        {
            var sut = new BasicOperation();

            var result = sut.Addition(z1, z2);

            Assert.AreEqual(15, result, $"result should be 15, but is {result}.");
        }

        [Test]
        public void Subtraction_Subtraction_Return5()
        {
            var sut = new BasicOperation();

            var result = sut.Subtraction(z1, z2);

            Assert.AreEqual(5, result, $"result should be 5, but is {result}.");
        }

        [Test]
        public void Division_Division_ThrowException()
        {
            var sut = new BasicOperation();

            void Calculation() => sut.Division(z1, 0);

            Assert.Throws<ZeroDivisorNotAllowedException>(Calculation, "Does not throw the correct exception!");
        }

        [Test]
        public void Division_Division_Return2()
        {
            var sut = new BasicOperation();

            var result = sut.Division(z1, z2);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiplication_Multiplication_Return50()
        {
            var sut = new BasicOperation();

            var result = sut.Multiplication(z1, z2);

            Assert.That(result, Is.EqualTo(50));
        }
    }
}