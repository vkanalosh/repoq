using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankArray
    {
        private int counter = 0;
        private int length = 10;

        public int Counter()
        {
            return counter;
        }

        public void CounterPlus()
        {
            counter++;
        }

        public int Length()
        {
            return length;
        }

        public void DoubleLength()
        {
            length *= 2;
        }
    }
}