using OOP05.Operator_Overloading;
using System.Runtime.Intrinsics.Arm;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Operators Overloading - Binary Operators && Part 02 Operators Overloading - Unary Operators && Part 03 Operators Overloading - Relational Operators


            Complex C1 = new Complex() { Real = 3 , Imag = 5};


            Console.WriteLine($"C1 = {C1}"); // 3 + 5i

            Complex C2 = new Complex() { Real = 2, Imag = 4 };

            Console.WriteLine($"C2 = {C2}"); // 2 + 4i

            Complex C3 =  default ;

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
        }
    }
}
