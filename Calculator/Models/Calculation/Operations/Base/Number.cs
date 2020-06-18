namespace Calculator.Models.Calculation.Operations.Base
{
    /// <summary>
    /// To store the number obtained from the current expression
    /// </summary>
    public class Number : UniversalOperation
    {
        private decimal value;

        public Number(decimal value)
        {
            this.value = value;
        }

        public override decimal Operation()
        {
            return value;
        }
    }
}