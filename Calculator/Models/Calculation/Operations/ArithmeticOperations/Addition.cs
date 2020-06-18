using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    /// <summary>
    /// For adding numbers
    /// </summary>
    public class Addition : BinaryOperation
    {
        public Addition(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override decimal Operation()
        {
            return leftArg.Operation() + rightArg.Operation();
        }
    }
}