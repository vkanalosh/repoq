using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace BankTest
{
    class BankArrayTests
    {
        public void Add_BankAccountShouldNotFail()
        {
            BankArray arrayToTest = new BankArray();

            for (int i = 0; i < 11; i++)
            {
                arrayToTest.Add($"Account{i}");
            }

            if (arrayToTest.Counter() != 11)
            {
                throw new Exception("Array should contain 11 elements after 11 additions.");
            }
        }
    }
}
