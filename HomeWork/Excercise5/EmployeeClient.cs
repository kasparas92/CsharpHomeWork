using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public class EmployeeClient
    {
        private readonly IEmployee _employee;
        public EmployeeClient(EmployeeAbstractFactory factory)
        {
            _employee = factory.CreateNewEmployeeStatus();
        }

        public int GetSickLeave()
        {
            return _employee.SickLeave();
        }
        public int GetPaidLeave()
        {
            return _employee.PaidLeave();
        }
        public int GetPublicHolidays()
        {
            return _employee.PublicHolidays();
        }
    }
}
