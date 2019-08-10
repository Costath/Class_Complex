using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexOperations
{
    class Complex
    {
        public int Real { private set; get; }
        public int Imaginary { private set; get; }
        public double Argument
        {
            get
            {
                return Math.Atan(Real/Imaginary);
            }
        }
        public double Modulus
        {
            get
            {
                return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            }
        }
        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"({Real},{Imaginary})";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;

            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;

            return new Complex(real, imaginary);
        }
        public static Boolean operator ==(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator !=(Complex lhs, Complex rhs)
        {
            if (lhs.Real != rhs.Real)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary;
            int imaginary = lhs.Real * rhs.Imaginary + rhs.Imaginary * lhs.Real;

            return new Complex(real, imaginary);
        }
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            double real = lhs.Real / rhs.Real;
            double imaginary = lhs.Imaginary / rhs.Imaginary;

            return new Complex(Convert.ToInt32(real), Convert.ToInt32(imaginary));
        }
        public static Complex operator -(Complex element)
        {
            int real = -element.Real;
            int imaginary = -element.Imaginary;

            return new Complex(real, imaginary);
        }
    }
}
