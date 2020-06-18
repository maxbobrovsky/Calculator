using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    /// <summary>
    /// For numbers module dividing
    /// </summary>
    public class ModuleDivision : BinaryOperation
    {
        public ModuleDivision(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override decimal Operation()
        {
            return leftArg.Operation() % rightArg.Operation();
        }
    }
}
