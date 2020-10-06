using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public class ProbationEmployee : IEmployee
    {
        public int SickLeave()
        {
            return 12;
        }
        public int PaidLeave()
        {
            return 9;
        }
        public int PublicHolidays()
        {
            return 15;
        }
    }
}
