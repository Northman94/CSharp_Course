using System;

namespace S8E99_HW_Complex_Numbers
{
    public class Complex
    {
        //Properties
        public double Imaginary { get; private set; }  
        public double Real { get; private set; }

        //Constructor
        public Complex(double _imaginary, double _real) 
        {
            Imaginary = _imaginary;
            Real = _real;
        }


        //Private Constructor - to not let outer code create a complex numb
        private Complex()
        {
        }

        public Complex Plus(Complex other)
        {
            var complex = new Complex();

            complex.Imaginary = other.Imaginary + Imaginary;

            complex.Real = other.Real + Real;

            return complex;
        }


        public Complex Minus(Complex other)
        {
            var complex = new Complex();

            complex.Imaginary = other.Imaginary - Imaginary;

            complex.Real = other.Real - Real;

            return complex;
        }
    }
}

