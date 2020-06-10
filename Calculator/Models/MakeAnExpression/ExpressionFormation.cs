﻿using System.Text;
using Calculator.Common;
using Calculator.Models.Calculation;

namespace Calculator.Models.MakeAnExpression
{
    /// <summary>
    /// Contains methods for forming the current expression
    /// </summary>
    class ExpressionFormation
    {
        #region Private members

        private CurrentData currentData;
        private ButtonsState buttonsState;
        private ClearData clearData;
        private Calculate calculate;

        #endregion

        #region Public methods

        /// <summary>
        /// To add the current number and the selected operation to the current expression
        /// </summary>
        public void SetBasicMathOperation(BasicMathOperations pressedOperation)
        {
            //If the expression was calculated and any basic math operation was pressed, except for "="
            if (buttonsState.EqualBtnPressed && (pressedOperation != BasicMathOperations.Equal))
            {
                currentData.CurrentExpression = clearData.ClearExpression(currentData.CurrentExpression);
                buttonsState.NumberPadBtnPressed_Change(true);
                buttonsState.AdditionalOperationBtnPressed_Change(false);
                buttonsState.EqualBtnPressed_Change(false);
            }

            currentData.CurrentExpression = NewCurrentExpression(pressedOperation);
            currentData.CurrentNumber = pressedOperation == BasicMathOperations.Equal ? calculate.Calc(currentData.CurrentExpression).ToString() : clearData.ClearNumber(currentData.CurrentNumber);

            if (double.IsNaN(double.Parse(currentData.CurrentNumber)) || double.IsPositiveInfinity(double.Parse(currentData.CurrentNumber)) || 
                double.IsNegativeInfinity(double.Parse(currentData.CurrentNumber)))
            {
                currentData.CurrentNumber = "Calculation error";
            }

            if (pressedOperation == BasicMathOperations.Equal)
            {
                buttonsState.EqualBtnPressed_Change(true);
            }

            buttonsState.NumberPadBtnPressed_Change(false);
            buttonsState.AdditionalOperationBtnPressed_Change(false);
        }
        #endregion

        #region Private methods

        #region Basic math operations private methods

        /// <summary>
        /// To change the current expression depending on the pressed operation and the state of the buttons
        /// </summary>
        private string NewCurrentExpression(BasicMathOperations pressedOperation)
        {
            //If the expression was calculated and "=" was pressed again
            if (buttonsState.EqualBtnPressed && (pressedOperation == BasicMathOperations.Equal) && Common.MathSignCheck(currentData.CurrentExpression))
            {
                return NumberStandardization.Standardization(currentData.CurrentNumber) + CopyLastOperation(currentData.CurrentExpression.Remove(currentData.CurrentExpression.Length - 3, 3)) + SetSelectedBasicMathOperation(pressedOperation);
            }
            else if (buttonsState.NumberPadBtnPressed)
            {
                return currentData.CurrentExpression + NumberStandardization.Standardization(currentData.CurrentNumber) + SetSelectedBasicMathOperation(pressedOperation);
            }
            //Сhanging the basic math operation sign
            else
            {
                return ChangeOperation(currentData.CurrentExpression, SetSelectedBasicMathOperation(pressedOperation));
            }
        }

        /// <summary>
        /// To change the sign of the last operation
        /// </summary>
        private string ChangeOperation(string currentExpression, string pressedOperation)
        {
            if (!currentExpression.EndsWith(pressedOperation))
            {
                return currentExpression.Remove(currentExpression.Length - 3, 3) + pressedOperation;
            }
            else
            {
                return currentExpression;
            }
        }

        /// <summary>
        /// To copy the last operation for recount
        /// </summary>
        /// <returns>
        /// Returns the copied fragment
        /// </returns>
        private string CopyLastOperation(string currentExpression)
        {
            int pos = 0;
            char[] destination;
            int fragmentSize = currentExpression.Length;
            int spaceCounter = 0;

            //Search for the fragment size to copy
            //If the expression has at least one basic math operation
            if (Common.MathSignCheck(currentExpression))
            {
                for (int i = currentExpression.Length - 1; ; i--)
                {
                    if (currentExpression[i] == ' ')
                    {
                        spaceCounter++;

                        if (spaceCounter == 2)
                        {
                            pos = i;
                            fragmentSize = currentExpression.Length - pos;
                            break;
                        }
                    }
                }
            }

            //Copy the required fragment
            destination = new char[fragmentSize];
            currentExpression.CopyTo(pos, destination, 0, fragmentSize);

            return new string(destination);
        }

        /// <summary>
        /// To set the symbolic representation of a basic math operation
        /// </summary>
        /// <returns>
        /// A string representing the selected operation
        /// </returns>
        private string SetSelectedBasicMathOperation(BasicMathOperations pressedOperation)
        {
            switch (pressedOperation)
            {
                case BasicMathOperations.Addition: return " + ";
                case BasicMathOperations.Subtraction: return " - ";
                case BasicMathOperations.Equal: return " = ";
                case BasicMathOperations.Multiplication: return " * ";
                case BasicMathOperations.Division: return " / ";
                case BasicMathOperations.ModuleDivision: return " % ";


            }

            return "Operation not found";
        }

        #endregion


        #region Additional methods

        /// <summary>
        /// To remove the last number or sequence of additional operations for subsequent replacement
        /// </summary>
        /// <returns>
        /// Returns the modified current expression, as well as the copied fragment and position for reuse
        /// </returns>
        private StringBuilder CurrentExpressionChange(string currentExpression, out int pos, out string copiedFragment)
        {
            StringBuilder stringBuilderCurExpr = new StringBuilder(currentExpression);
            char[] destination;
            int fragmentSize;

            //Search for the fragment size to replace
            //If the expression has at least one basic math operation
            if (Common.MathSignCheck(currentExpression))
            {
                for (int i = stringBuilderCurExpr.Length - 1; ; i--)
                {
                    if (stringBuilderCurExpr[i] == ' ')
                    {
                        pos = i + 1;
                        fragmentSize = stringBuilderCurExpr.Length - pos;
                        break;
                    }
                }
            }
            else
            {
                pos = 0;
                fragmentSize = stringBuilderCurExpr.Length;
            }

            //Remove an old fragment
            destination = new char[fragmentSize];
            stringBuilderCurExpr.CopyTo(pos, destination, 0, fragmentSize);
            copiedFragment = new string(destination);
            stringBuilderCurExpr.Remove(pos, fragmentSize);

            return stringBuilderCurExpr;
        }

        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpressionFormation(CurrentData currentData, ButtonsState buttonsState, ClearData clearData)
        {
            this.currentData = currentData;
            this.buttonsState = buttonsState;
            this.clearData = clearData;
            calculate = new Calculate();
        }

        #endregion
    }
}