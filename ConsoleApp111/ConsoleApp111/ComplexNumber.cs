using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    public static class CN
    {
        public static ComplexNumber Add(ComplexNumber first, ComplexNumber other)
        {
            double a = first.A + other.A;
            double b = first.B + other.B;
            return new ComplexNumber(a, b);
        }
    }

    public class ComplexNumber
    {

        public ComplexNumber(double a, double b)
        {
            A = a;
            B = b;
        }
        public double A { get; set; }
        public double B { get; set; }

        public bool check {
            get
            {
                return (this.B == 0);
            }
            set
            { 
                Console.WriteLine($"Value is {value}");
            }
        }
        
        public ComplexNumber Add(ComplexNumber other)
        {
            double a = this.A + other.A;
            double b = this.B + other.B;
            return new ComplexNumber(a, b);
        }

        public ComplexNumber Sub(ComplexNumber other)
        {
            double a = A - other.A;
            double b = B - other.B;
            return new ComplexNumber(a, b);
        }

        public ComplexNumber Multi(ComplexNumber other)
        {
            double a = (A * other.A - B * other.B);
            double b = (A * other.B + B * other.A);
            return new ComplexNumber(a, b);
        }

        public ComplexNumber Div(ComplexNumber other)
        {

            double a = ((A * other.A + B * other.B) / (other.A * other.A + other.B * other.B));
            double b = (A * other.B - B * other.A) / (other.A * other.A + other.B * other.B);
            return new ComplexNumber(a, b);
        }

        public void Result(ComplexNumber other)
        {
            Console.WriteLine($"number3 = {other.A} + {other.B}i");
        }

        public ComplexNumber AddDouble(double other)
        {
            double a = A + other;
            double b = B;
            return new ComplexNumber(a, b);
        }

        public ComplexNumber SubDouble(double other)
        {
            double a = A - other;
            double b = B;
            return new ComplexNumber(a, b);
        }

        public ComplexNumber MultiDouble(double other)
        {
            double a = (A * other - B * 0);
            double b = (A * 0 + B * other);
            return new ComplexNumber(a, b);
        }

        public ComplexNumber DivDouble(double other)
        {
            double a = ((A * other + B * 0) / (other * other + 0 * 0));
            double b = (A * 0 - B * other) / (other * other + 0 * 0);
            return new ComplexNumber(a, b);
        }

        public bool IsReallyComplex()
        {
            return  (this.B == 0);
        }

        public void SetIsReallyComplex(bool value)
        {
            Console.WriteLine($"Value is {value}");
        }
    }
}
