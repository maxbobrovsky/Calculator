using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models.Calculation.Operations.Base;
using Calculator.Models.Calculation.Operations.ArithmeticOperations;
using System;

namespace CalculatorUnitTests.ArithmeticOperationsTests
{
    [TestClass]
    public class ModuloDivisionTests
    {
        [TestMethod]
        public void ModuloDivisionPositiveIntegerNumberOnPositiveIntegerOne()
        {
            Number leftArg = new Number(17m);
            Number rightArg = new Number(4m);
            int expected = 1;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionNegativeIntegerNumberOnPositiveIntegerOne()
        {
            Number leftArg = new Number(-78m);
            Number rightArg = new Number(33m);
            int expected = -12;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionPositiveRealNumberOnPositiveRealOne()
        {
            Number leftArg = new Number(1.8m);
            Number rightArg = new Number(0.5m);
            decimal expected = 0.3m;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionNegativeRealNumberOnPositiveRealOne()
        {
            Number leftArg = new Number(-4.5m);
            Number rightArg = new Number(1.2m);
            decimal expected = -0.9m;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionPositiveRealNumberOnZeroOne()
        {
            Number leftArg = new Number(100.1m);
            Number rightArg = new Number(0m);

            ModuleDivision mod = new  ModuleDivision(leftArg, rightArg);
            
            Assert.ThrowsException<DivideByZeroException>(() => mod.Operation());
        }

        [TestMethod]
        public void ModuloDivisionNegativeIntegerNumberOnZeroOne()
        {
            Number leftArg = new Number(-50m);
            Number rightArg = new Number(0m);

            ModuleDivision mod = new ModuleDivision(leftArg, rightArg);

            Assert.ThrowsException<DivideByZeroException>(() => mod.Operation());
        }

        [TestMethod]
        public void ModuloDivisionPositiveIntegerNumberOnNegativeRealOne()
        {
            Number leftArg = new Number(17m);
            Number rightArg = new Number(-7.2m);
            decimal expected = 2.6m;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionZeroNumberOnPositiveRealOne()
        {
            Number leftArg = new Number(0m);
            Number rightArg = new Number(7.4m);
            decimal expected = 0m;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModuloDivisionZeroNumberOnNegativeIntegerOne()
        {
            Number leftArg = new Number(0m);
            Number rightArg = new Number(-5m);
            decimal expected = 0m;

            ModuleDivision div = new ModuleDivision(leftArg, rightArg);
            decimal actual = div.Operation();

            Assert.AreEqual(expected, actual);
        }



    }
}