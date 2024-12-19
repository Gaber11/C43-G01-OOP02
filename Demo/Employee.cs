using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        #region Encapsulation

        #region Attribute
        public int Id;
        private string? Name;
        private decimal salary;
        // private decimal deduction; [Drivide Attribute]
        #endregion

        #region Constructor
        public Employee(int _Id, string _name, decimal _Salary)
        {
            Id = _Id;
            Name = _name;
            Salary = _Salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}\tSalary:{Salary:c} ,  Age: {Age}";
        }

        //1.1 Applying Encapsulation : Using old Approach [Getter-Setter Methods]
        //Getter
        public string? GetName()
        {
            return Name;
        }
        //Setter
        public void SetName(string? value)
        {
            Name = value;
        }

        #endregion

        //1.Encapsulation: Seprates Data Definition [Attribute] from its Use [Getter-Setter Methods, Property]

        #region Properties
        //1.2 Applying Encapsulation using new Approach [Property] --> Recommended : Easy to use like As dealing with the attribute
        //   1.2.1 Full Property
        public decimal Salary
        {
            get
            {
                return salary;

            }
            set
            {
                salary = value;

            }
        }


        //1.2.2 Automatic Property
        //Compiler will generate Backing field "Hidden Private Attribute"
        public int Age { get; set; }

        public decimal Deduction
        {
            get { return salary * 2m; }


        }
        #endregion

        // propfull: is a code snippet for the [full property]

        #region full property
        //private string? address;
        //public string? Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}

        #endregion


        //prop : is a code snippet for [Automatic prpoperty]

        //public string? Address { get; set; } 
        #endregion
    }
}
