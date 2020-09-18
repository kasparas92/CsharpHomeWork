using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    public class OddNumberSumCalculator : Calculator
    {
        public OddNumberSumCalculator(int[] numbers) : base(numbers)
        {

        }
        public override int CalculateSum()
        {
            return _numbers.Where(x => x % 2 != 0).Sum();
        }
    }
}
