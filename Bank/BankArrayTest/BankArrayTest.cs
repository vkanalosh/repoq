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
            int counter = 0;

            //Act.
            for (int i = 0; i < 11; i++)
            {
                handleToTest.HandleAdd($"Account{i}");
                counter++;

            }

            //Assert.
            if (counter != 11)
            {
                throw new Exception("Array should contain 11 elements after 11 additions.");
            }
        }

        public void List_BankAccountShouldNotFail()
        {
            // Arrange.
            Handle handleToTest = new Handle();
            BankArray bankArrayToTest = new BankArray();
            int counter = 0;

            for (int i = 0; i < 4; i++)
            {
                handleToTest.HandleAdd($"{i}");
                handleToTest.HandlePut($"{i}", Convert.ToDecimal(i * 100));
                counter++;
            }

            // Act.
            handleToTest.HandleList();

            //Assert.
            if (counter != 4)
            {
                throw new Exception("Array should contain 4 elements after 4 aditions.");
            }
        }
    }
}
