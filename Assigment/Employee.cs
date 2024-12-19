using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment
{
    enum SecurityPrivileges
    {
        guest,
        Developer,
        secretary,
        DBA
    }
    public enum Gender
    {
        m,
        f
    }
    //public class DateTime
    // {
    //     DateTime HireDate = new DateTime();
    // }
    public class Employee
    {
       
        private protected int Id;
        private protected string? Name;
        private protected string? Security_level;
        private protected decimal Salary;
        //  private protected DateTime HireDate;
        private protected Gender Gender;

        //public Employee(int Id, string? Name, string? Security_level, decimal Salary, Gender Gender)
        //{
        //    this.Name = Name;
        //    this.Id = Id;
        //    this.Security_level = Security_level;
        //    this.Salary = Salary;
        //    // this.HireDate = HireDate;
        //    this.Gender = Gender;

        //}

        //Q5)part 3
        public override string ToString()
        {
            return $"Name : {Name}\nID: {Id}\nSecurity_level: {Security_level}\nSalary: {Salary:c}\nGender: {Gender.m} ";
        }

    }
}
