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

        public double MemoryGetValue()
        {
            return _MemoryValue;
        }

        public void MemoryClear()
        {
            _MemoryValue = 0;
        }

        public void MemoryAdd(double value)
        {
            _MemoryValue += value;
        }

        public void MemorySubtract(double value)
        {
            _MemoryValue -= value;
        }

      
    }
}
