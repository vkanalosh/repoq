using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace BankArrayTest
{
    class BankArrayTest
    {
        public void Add_BankAccountShouldNotFail()
        {
            //Arrange.
            Handle handleToTest = new Handle();
            BankArray arrayToTest = new BankArray();

            //Act.
            for (int i = 0; i < 11; i++)
            {
                handleToTest.HandleAdd($"Account{i}");

            }

            //Assert.
            if (arrayToTest.Counter() != 11)
            {
                throw new Exception("Array should contain 11 elements after 11 additions.");
            }
        }
    }
}
