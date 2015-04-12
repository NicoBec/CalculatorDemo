using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    //This is where I declare the interfaces used in the project.

    interface CalcInterface
    {

        double DoCalculation(double value);
        void ResetAll();
        void AddCalcOperator(CalculationOperator Operation);
        double ReturnStoredValue();
    }

    interface CalcMemInterface
    {
        double MemoryGetValue();
        void MemoryClear();
        void MemoryAdd(double value);
        void MemorySubtract(double value);
    }

    enum CalculationOperator
    {
        none,add,subtract,divide,multiply
    }


}
