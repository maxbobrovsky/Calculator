using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models.Calculation.Operations.Base;
using Calculator.Models.Calculation.Operations.ArithmeticOperations;
using System;
using Moq;

namespace CalculatorUnitTests.ArithmeticOperationsTests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivisionPositiveIntegerNumberOnZeroOne()
        {
            Number leftArg = new Number(100.0m);
            Number rightArg = new Number(0.0m);

            Division div = new Division(leftArg, rightArg);
            //  Number rightArg = new Number(0);
            //  Number leftArg = new Number(100);
            //  Division div = new Division(leftArg, rightArg);
            // decimal a = 100m;
            // decimal b = 0m;
            Assert.ThrowsException<DivideByZeroException>(() => div.Operation());
        }

        [TestMethod]
        public void DivisionNegativeRealNumberOnZeroOne()
        {
            Number leftArg = new Number(-341.2m);
            Number rightArg = new Number(0m);

            Division div = new Division(leftArg, rightArg);
            
            Assert.ThrowsException<DivideByZeroException>(() => div.Operation());
        }

        [TestMethod]
        public void DivisionIntegerPositiveNumberOnPositiveOne()
        {
            Number leftArg = new Number(7m);
            Number rightArg = new Number(4m);
            decimal expected = 1m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionOnIntegerPositiveNumberOnNegativeOne()
        {
            Number leftArg = new Number(7m);
            Number rightArg = new Number(-2m);
            decimal expected = -3m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionIntegerNegativeNumberOnNegativeOne()
        {
            Number leftArg = new Number(-8m);
            Number rightArg = new Number(-2m);
            decimal expected = 4m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionZeroNumberOnRealOne()
        {
            Number leftArg = new Number(0m);
            Number rightArg = new Number(4.5m);
            decimal expected = 0m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionRealNumberOnIntegerOne()
        {
            Number leftArg = new Number(17.3m);
            Number rightArg = new Number(4.0m);
            decimal expected = 4m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionNegativeIntegerNumberOnPositiveRealOne()
        {
            Number leftArg = new Number(-9m);
            Number rightArg = new Number(2.3m);
            decimal expected = -3m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionPositiveRealNumberOnPositiveRealOne()
        {
            Number leftArg = new Number(54.2m);
            Number rightArg = new Number(22.1m);
            decimal expected = 2m;

            Division div = new Division(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }
    }
}
