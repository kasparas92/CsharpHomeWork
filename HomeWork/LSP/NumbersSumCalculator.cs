using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    public class NumbersSumCalculator : Calculator
    {
        public NumbersSumCalculator(int[] numbers) : base(numbers)
        {

        }
        public override int CalculateSum()
        {
            return _numbers.Sum();
        }
    }
}
