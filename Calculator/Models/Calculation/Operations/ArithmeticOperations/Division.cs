﻿using Calculator.Models.Calculation.Operations.Base;

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
             return System.Math.Truncate(leftArg.Operation() / rightArg.Operation()); 
           
        }

       
    }
}