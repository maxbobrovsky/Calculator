using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    

    /// <summary>
    /// For dividing numbers
    /// </summary>
    public class Division : BinaryOperation
    {
        public Division(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override decimal Operation()
        {
<<<<<<< HEAD
             return System.Math.Truncate(leftArg.Operation() / rightArg.Operation()); 
           
=======
            return System.Math.Truncate(leftArg.Operation() / rightArg.Operation());
>>>>>>> b67fc9f11778ad7a9f07e9d79452c2487dd1abc5
        }

       
    }
}