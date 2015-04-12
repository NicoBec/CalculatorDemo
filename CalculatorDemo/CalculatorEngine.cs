using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    class CalculatorEngine : CalcMem, CalcInterface
    {
        // This is the current sum of the calculations
        private double _StoredValue = 0;
        // This is the next calculation the needs to be performed
        private CalculationOperator _Operation;

        /// <summary>
        /// This is the method that will do the calculation of the current calculation values
        /// </summary>
        /// <param name="value">This is the value that will be used to perform the calculation</param>
        /// <returns>This returns the calculated value</returns>
        public double DoCalculation(double value)
        {
            switch (_Operation)
            {
                case CalculationOperator.none:
                    {
                        _StoredValue = value;
                        break;
                    }
                case CalculationOperator.add:
                    {
                        _StoredValue += value;
                        break;
                    }
                case CalculationOperator.divide:
                    {
                        _StoredValue = _StoredValue / value;
                        break;
                    }
                case CalculationOperator.multiply:
                    {
                        _StoredValue = _StoredValue * value;
                        break;
                    }
                case CalculationOperator.subtract:
                    {
                        _StoredValue = _StoredValue - value;
                        break;
                    }
                default:
                    break;
            }
            //Reset the calculation operator
            _Operation = CalculationOperator.none;
            return _StoredValue;
        }

        /// <summary>
        /// This will reset the calculator class. 
        /// </summary>
        public void ResetAll()
        {
            _Operation = CalculationOperator.none;
            _StoredValue = 0;
        }

        /// <summary>
        /// This is used to set the next operation to be performed
        /// </summary>
        /// <param name="Operation"></param>
        public void AddCalcOperator(CalculationOperator Operation)
        {
            _Operation = Operation;
        }

        /// <summary>
        /// This will return the stored value
        /// </summary>
        /// <returns></returns>
        public double ReturnStoredValue()
        {
            return _StoredValue;
        }
    }
}
