using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class Fractions
    {
        public Fractions(long a, long b)
        {
            numerator = a;
            denominator = b;
        }

        public long numerator {get; set;}
        public long denominator {get; set;}

       public Fractions Add(Fractions other)
        {
            long a = numerator + other.numerator;
            long b = denominator;
            return new Fractions(a, b);

        }

        public Fractions Sub(Fractions other)
        {
            long a = numerator - other.numerator;
            long b = denominator;
            return new Fractions(a, b);
        }

        public Fractions Multi(Fractions other)
        {
            long a = numerator * other.numerator;
            long b = denominator * other.denominator;
            return new Fractions(a, b);
        }

        public Fractions Div(Fractions other)
        {
            long a = numerator * other.denominator;
            long b = denominator * other.numerator;
            return new Fractions(a, b);
        }

        public void Result(Fractions other)
        {
            Console.WriteLine($"fractions 3 = {other.numerator}/{other.denominator}");
        }
    }
}
