using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public class ContractEmployeeFactory : EmployeeAbstractFactory
    {
        protected override IEmployee AddStatus()
        {
            return new ContractEmployee();
        }
    }
}
