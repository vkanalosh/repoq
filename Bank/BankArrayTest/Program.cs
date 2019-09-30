using System;
using Bank;


namespace BankArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankArrayTest bankArrayTests = new BankArrayTest();
                bankArrayTests.Add_BankAccountShouldNotFail();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
