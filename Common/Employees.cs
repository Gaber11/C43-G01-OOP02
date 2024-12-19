using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    abstract class EmployeeBase
    {
        protected int Id;
        protected string? Name;
        protected int Age;

    }
    class FullTimeEmployee : EmployeeBase
    {

        private decimal Salary;
    }
    class PartTimeEmployee : EmployeeBase
    {

        private decimal HourRate;
    }
}
