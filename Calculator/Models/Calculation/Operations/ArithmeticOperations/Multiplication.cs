using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    /// <summary>
    /// For multiplicating numbers
    /// </summary>
    public class Multiplication : BinaryOperation
    {
        public Multiplication(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override decimal Operation()
        {
            return leftArg.Operation() * rightArg.Operation();
        }
    }
}