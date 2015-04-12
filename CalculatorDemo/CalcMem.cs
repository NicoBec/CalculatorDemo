using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    class CalcMem : CalcMemInterface
    {
        private double _MemoryValue = 0;

        /// <summary>
        /// This will return the memory value currently stored
        /// </summary>
        /// <returns></returns>
        public double MemoryGetValue()
        {
            return _MemoryValue;
        }

        /// <summary>
        /// This will clear the memory value
        /// </summary>
        public void MemoryClear()
        {
            _MemoryValue = 0;
        }

        /// <summary>
        /// This will add the value sent into the memory
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void MemoryAdd(double value)
        {
            _MemoryValue += value;
        }

        /// <summary>
        /// This will subtract the value from the current memory value
        /// </summary>
        /// <param name="value">Value to be subtracted</param>
        public void MemorySubtract(double value)
        {
            _MemoryValue -= value;
        }

      
    }
}
