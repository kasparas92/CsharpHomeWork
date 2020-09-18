using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndCommandAndObserverPatterns
{
    public sealed class Calculate
    {
        private Calculate()
        {

        }
        private static Calculate _instance = null;
        public static Calculate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Calculate();
                }
                return _instance;
            }
        }

        public double ValueNr1 { get; set; }
        public double ValueNr2 { get; set; }

        public double Addition()
        {
            return ValueNr1 + ValueNr2;
        }
        public double Subtraction()
        {
            return ValueNr1 - ValueNr2;
        }
        public double Multiplication()
        {
            return ValueNr1 * ValueNr2;
        }
        public double Division()
        {
            return ValueNr1 / ValueNr2;
        }
    }
}
