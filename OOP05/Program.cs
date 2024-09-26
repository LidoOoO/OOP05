using OOP05.Casting_Operator_Overloading;
using OOP05.Operator_Overloading;
using System.Runtime.Intrinsics.Arm;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Operators Overloading - Binary Operators && Part 02 Operators Overloading - Unary Operators && Part 03 Operators Overloading - Relational Operators


            //Complex C1 = new Complex() { Real = 3 , Imag = 5};


            //Console.WriteLine($"C1 = {C1}"); // 3 + 5i

            //Complex C2 = new Complex() { Real = 2, Imag = 4 };

            //Console.WriteLine($"C2 = {C2}"); // 2 + 4i

            //Complex C3 =  default ;

            #region Binary Operators Overloading 

            //Complex C3 = C1 + C2; // Invalid
            //Console.WriteLine("==================");
            //Console.WriteLine(C3); // 5 + 9i

            //Complex C3 = C1 - C2;
            //Console.WriteLine("====================");
            //Console.WriteLine(C3);

            //Complex C3 = default;
            //C3 += C1; // C3 = Null + C1  

            //Console.WriteLine(C3);


            //C3 -= C1; // C3 = C3 - C1


            #endregion

            #region Unary Operators Overloading

            ////C3 = ++C1; // Prefix
            ////C3 = C1++; // Postfix

            //C3 = --C1;

            //Console.WriteLine("==========");
            //Console.WriteLine($"C3 = {C3}");

            #endregion

            #region Relational Operators Overloading

            //if(C1 > C2)
            //    Console.WriteLine("C1 Is Greater Than C2");
            //else if (C2 > C1)
            //    Console.WriteLine("C2 is Greater Than C1");


            #endregion



            #endregion

            #region Part 04 Casting Operator Overloading

            //object obj = 2; // Boxing

            //int X = (int) obj; // Explicit Casting
            //                   // (int) Casting Operator

            //Complex C1 = new Complex()
            //{
            //    Real = 2,
            //    Imag = 4
            //};

            //string S1 = C1; // Invalid
            //S1 = (string)C1;
            //Console.WriteLine(S1);

            ////int Y = (int)C1; // Invalid

            ////// Explicit Casting
            ////// (int) -> 

            ////Console.WriteLine(Y);

            #endregion

            #region Part 05 Casting Operator Overloading - Mapping

            // View -> EmployeeViewModel -> Employee [Model] -> Database
            // Database -> Employee -> EmployeeViewModel -> View

            Employee employee = new Employee()
            {
                Id = 10,
                FullName = "Waleed Mahmoud",
                Password = "Password",
                Email = "Email",
                SecurityStamp = Guid.NewGuid()
            };

            //EmployeeViewModel employeeView = new EmployeeViewModel();

            //employeeView = (EmployeeViewModel)employee;

            //Console.WriteLine(employeeView.FirstName);
            //Console.WriteLine(employeeView.LastName);

            //object obj = new EmployeeViewModel() { FirstName = "Waleed" , LastName = "Mahmoud" , Email = "Email" };

            //EmployeeViewModel E = (EmployeeViewModel) obj;


            //Console.WriteLine(E.FirstName);


            #endregion
        }
    }
}
