using Demo.Encapsulation;
using Demo.Inhertance;
using System.Security.Claims;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 OOP Pillars - Encapsulation

            //    Employee employee=new Employee(10,"Gaber Ezzat" , 3000 );
            // employee.Id = 30; //Set id directly through the attribute

            ////  Console.WriteLine(employee.Id);
            // // Console.WriteLine(employee);

            //  employee.SetName("Mohamed Ali"); //Set Name with setter function

            // // Console.WriteLine(employee.GetName());
            //    employee.Salary = 90000;

            //  Console.WriteLine(employee);

            #endregion

            #region Part 02 Encapsulation (Continued) - Indexer

            //string Name = "Gaber";

            //Console.WriteLine(Name[0]);

            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Gaber", 123);
            //Note.AddPerson(1, "Hossam", 242232);
            //Note.AddPerson(2, "Hammad", 334333);

            //// Note.SetNumber("Hossam", 9999);
            ////   Note["Hossam"] = 5764;


            //// Console.WriteLine(Note["Hossam"]);
            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}

            #endregion

            #region Part 03 Class

            // Car c1 = new Car(1,"Reuml trgen", 220);

            //Car c1 = new Car(2002,"Niseya");

            //Console.WriteLine(c1);

            #endregion

            #region Part 05 OOP Pillars - Inheritance

            // Parent parent = new Parent(5, 7);
            // parent.X = 11;
            // parent.Y = 22;
            // Console.WriteLine(parent);
            // Console.WriteLine($"Product : {parent.Product()}");
            //Child child=new Child(1,2,3);
            //child.X = 20;
            //child.Y = 30;   
            //child.Z = 50;
            //Console.WriteLine(child);
            //Console.WriteLine($"Product : {child.Product()}");

            #endregion

            #region Part 07 Association [Composition - Aggregation]

            #endregion

            #region Part 10 Access Modifiers (private, internal, public)
            //TypeA typeA = new TypeA();
            // typeA.X = 10; // invalid --> private
            // typeA.Y = 10; // invalid -->internal

            #endregion
            #region Part 11 Access Modifiers (private protected, protected, internal protected) EX01

            #endregion
        }
    }
}
