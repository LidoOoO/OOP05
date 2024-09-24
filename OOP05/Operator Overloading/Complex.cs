using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Imag { get; set; }



        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }


        #region Operators Overloading
        // +
        // Non - Private , Class member Method

        public static Complex operator + (Complex Left, Complex Right)
        {
            // 2 + 5i
            // 5 + 4i
            // 7 + 9i
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
                // Left?.Real => Left == Null => Null ?? 0 
                // Left?.Real => Left != Null => Left.Real 
            };
        }

        public static Complex operator - (Complex Left, Complex Right)
        {

            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };

        }

        public static Complex operator ++ (Complex C)
        {
            // 2 + 5i => 3+ 5i
            return new Complex()
            {
             Real = (C?.Real ?? 0) + 1,
             Imag = (C?.Imag ?? 0) + 1
            };
        }

        public static Complex operator -- (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0) - 1
            };
        }
        #endregion




    }
}
