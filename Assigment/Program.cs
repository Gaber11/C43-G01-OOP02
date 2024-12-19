using System.Reflection.Emit;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Part 01.Try all what we have learned in the lecture.
            //Console.WriteLine("Hello, World!");
            ////demo
            ////demo
            #endregion

            #region Part2) 1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[4];
            //person[0] = new Person("Gaber", 24);
            //person[1] = new Person("Ahmed", 22);
            //person[2] = new Person("Hassan", 23);
            //person[3] = new Person("Abdo", 19);
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name: {person[i].Name}, Age: {person[i].Age}");
            //}




            #endregion

            #region 2-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] pers = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    pers[i].Name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    pers[i].Age = int.Parse(Console.ReadLine());
            //}
            //Person oldestPerson = (pers[0].Age > pers[1].Age)
            //     ? (pers[0].Age > pers[2].Age ? pers[0] : pers[2])
            //     : (pers[1].Age > pers[2].Age ? pers[1] : pers[2]);
            //Console.WriteLine($"The oldest person is {oldestPerson.Name} who is {oldestPerson.Age} years old.");

            #endregion

            #region Part3) 1.	Design and implement a Class for the employees in a company:Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            //Employee employee = new Employee(0,"Gaber","High",5000,5,"male");
            //Console.WriteLine(employee);

            #endregion

            #region Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.  

            #endregion

            #region 4.We need to restrict the Gender field to be only M or F [Male or Female] 
            //Employee emp = new Employee(0, "Gaber", "High", 5000, Gender.m);

            //Console.WriteLine(emp);

            #endregion

            #region Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum

            //Employee employee = new Employee();
            //Console.WriteLine(SecurityPrivileges.DBA); 

            #endregion

            #region 5.	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]

            //Employee employee = new Employee();         
            //Console.WriteLine(employee);


            #endregion

        }
    }
}
