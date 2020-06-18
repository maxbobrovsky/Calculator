using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models.Calculation.Operations.Base;
using Calculator.Models.Calculation.Operations.ArithmeticOperations;
using System;

namespace CalculatorUnitTests.ArithmeticOperationsTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void MultiplicationOfTwoPositiveIntegerNumbers()
        {
            Number leftArg = new Number(15m);
            Number rightArg = new Number(20m);
            int expected = 300;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfTwoNegativeIntegerNumbers()
        {
            Number leftArg = new Number(-2m);
            Number rightArg = new Number(-105m);
            int expected = 210;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfANegativeIntegerNumberByAPositiveOne()
        {
            Number leftArg = new Number(-4m);
            Number rightArg = new Number(12m);
            int expected = -48;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfAZeroByARealNumber()
        {
            Number leftArg = new Number(0);
            Number rightArg = new Number(1.5m);
            int expected = 0;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfTwoPositiveRealNumbers()
        {
            Number leftArg = new Number(2.1m);
            Number rightArg = new Number(2.2m);
            decimal expected = 4.62m;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfTwoNegativeRealNumbers()
        {
            Number leftArg = new Number(-1.5m);
            Number rightArg = new Number(-2.4m);
            decimal expected = 3.6m;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, Math.Round(actual, 2));
        }

        [TestMethod]
        public void MultiplicationOfANegativeRealNumberByAPositiveOne()
        {
            Number leftArg = new Number(-4.1m);
            Number rightArg = new Number(12.1m);
            decimal expected = -49.61m;

            Multiplication mul = new Multiplication(leftArg, rightArg);
            decimal actual = mul.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOverflowTestWithPositiveNumber()
        {
            Number leftArg = new Number(79228162514264337593543950329m);
            Number rightArg = new Number(2);

            Multiplication mul = new Multiplication(leftArg, rightArg);
           
            Assert.ThrowsException<OverflowException>(() => mul.Operation());
        }

        [TestMethod]
        public void MultiplicationOverflowTestWithNegativeNumber()
        {
            Number leftArg = new Number(-79228162514264337593543950311m);
            Number rightArg = new Number(2);

            Multiplication mul = new Multiplication(leftArg, rightArg);

            Assert.ThrowsException<OverflowException>(() => mul.Operation());
        }


    }
}