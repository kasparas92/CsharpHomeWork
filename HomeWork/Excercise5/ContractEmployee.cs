using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public class ContractEmployee : IEmployee
    {
        public int SickLeave()
        {
            return 5;
        }
        public int PaidLeave()
        {
            return 0;
        }
        public int PublicHolidays()
        {
            return 15;
        }
    }
}
