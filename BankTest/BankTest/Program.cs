using System;

namespace BankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankArrayTests bankArrayTests = new BankArrayTests();
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
