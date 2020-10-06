using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public class PermanentEmployee : IEmployee
    {
        public int SickLeave()
        {
            return 12;
        }
        public int PaidLeave()
        {
            return 18;
        }
        public int PublicHolidays()
        {
            return 15;
        }
    }
}
