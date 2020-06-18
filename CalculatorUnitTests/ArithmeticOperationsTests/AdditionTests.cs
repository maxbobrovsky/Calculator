using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models.Calculation.Operations.Base;
using Calculator.Models.Calculation.Operations.ArithmeticOperations;

namespace CalculatorUnitTests.ArithmeticOperationsTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void AdditionOfTwoPositiveIntegers()
        {
            Number leftArg = new Number(10m);
            Number rightArg = new Number(20m);
            int expected = 30;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfTwoNegativeIntegers()
        {
            Number leftArg = new Number(-10m);
            Number rightArg = new Number(-20m);
            int expected = -30;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfPositiveAndNegativeIntegers()
        {
            Number leftArg = new Number(10m);
            Number rightArg = new Number(-20m);
            int expected = -10;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void AdditionOfNegativeAndPositiveIntegers()
        {
            Number leftArg = new Number(-10m);
            Number rightArg = new Number(20m);
            int expected = 10;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfTwoPositiveRealNumbers()
        {
            Number leftArg = new Number(10.2m);
            Number rightArg = new Number(20.4m);
            decimal expected = 30.6m;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = (decimal)addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfTwoNegativeRealNumbers()
        {
            Number leftArg = new Number(-10.2m);
            Number rightArg = new Number(-20.4m);
            decimal expected = -30.6m;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = (decimal)addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfPositiveAndNegativeRealNumbers()
        {
            Number leftArg = new Number(10.2m);
            Number rightArg = new Number(-20.4m);
            decimal expected = -10.2m;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfNegativeAndPositiveRealNumbers()
        {
            Number leftArg = new Number(-10.5m);
            Number rightArg = new Number(20.5m);
            int expected = 10;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfAnIntegerAndARealNumber()
        {
            Number leftArg = new Number(10);
            Number rightArg = new Number(20.4m);
            decimal expected = 30.4m;

            Addition addition = new Addition(leftArg, rightArg);
            decimal actual = addition.Operation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOverflowTestWithPositiveNumber()
        {
            Number leftArg = new Number(79228162514264337593543950310m);
            Number rightArg = new Number(62531);

            Addition addition = new Addition(leftArg, rightArg);

            Assert.ThrowsException<System.OverflowException>(() => addition.Operation());
        }

        [TestMethod]
        public void AdditionOverflowTestWithNegativeNumber()
        {
            Number leftArg = new Number(-79228162514264337593543950319m);
            Number rightArg = new Number(-7211);

            Addition addition = new Addition(leftArg, rightArg);

            Assert.ThrowsException<System.OverflowException>(() => addition.Operation());
        }
    }
}