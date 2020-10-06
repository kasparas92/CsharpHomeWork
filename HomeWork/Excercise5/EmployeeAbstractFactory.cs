using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise5
{
    public abstract class EmployeeAbstractFactory
    {
        protected abstract IEmployee AddStatus();
        public IEmployee CreateNewEmployeeStatus()
        {
            return AddStatus();
        }
    }
}
