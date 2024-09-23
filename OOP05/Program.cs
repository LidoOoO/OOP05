﻿using OOP05.Operator_Overloading;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Operators Overloading - Binary Operators


            Complex C1 = new Complex() { Real = 3 , Imag = 5};


            Console.WriteLine(C1); // 3 + 5i

            Complex C2 = new Complex() { Real = 2 , Imag = 4 };

            Console.WriteLine(C2); // 2 + 4i

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
            #endregion
        }
    }
}
