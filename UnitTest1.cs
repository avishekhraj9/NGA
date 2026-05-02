using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    public class CalculatorTest
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.AreEqual(6, calc.Multiply(2, 3));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.AreEqual(2, calc.Divide(6, 3));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
        }

        [Test]
        public void Add_WithZero()
        {
            Assert.AreEqual(5, calc.Add(5, 0));
        }
    }
}