using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class Fractions
    {
        public Fractions(long a, long b)
        {
            Numerator = a;
            Denominator = b;
        }

        public long Numerator { get; set; }
        public long Denominator { get; set; }

        public Fractions Add(Fractions other)
        {
            if (Denominator == other.Denominator)
            {
                long a = Numerator + other.Numerator;
                long b = Denominator;
                return new Fractions(a, b);
            }
            else
            {
                long a1 = Numerator * other.Denominator;
                long b1 = Denominator * other.Denominator;
                long a2 = other.Numerator * Denominator;
                long b2 = other.Denominator * Denominator;
                long a = a1 + a2;
                return new Fractions(a, b2);
            }
        }

        public Fractions Sub(Fractions other)
        {
            if (Denominator == other.Denominator)
            {
                long a = Numerator - other.Numerator;
                long b = Denominator;
                return new Fractions(a, b);
            }
            else
            {
                long a1 = Numerator * other.Denominator;
                long b1 = Denominator * other.Denominator;
                long a2 = other.Numerator * Denominator;
                long b2 = other.Denominator * Denominator;
                long a = a1 - a2;
                return new Fractions(a, b2);
            }
        }

        public Fractions Multi(Fractions other)
           { 
                long a = Numerator * other.Numerator;
                long b = Denominator * other.Denominator;
                return new Fractions(a, b);
           }

        public Fractions Div(Fractions other)
        {
                long a = Numerator * other.Denominator;
                long b = Denominator * other.Numerator;
                return new Fractions(a, b);
        }

        public void Result()
        {
            Console.WriteLine($"fractions 3 = {Numerator}/{Denominator}");
        }

        public Fractions Reducing()
        {
            long a = Numerator;
            long b = Denominator;

            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            Numerator = Numerator / a;
            Denominator = Denominator / a;
            return new Fractions(Numerator, Denominator);
        }
        public void ReducingResult()
        {
            Console.WriteLine($"Reducing of fractions 3 = {Numerator}/{Denominator}");
        }
    }
}
