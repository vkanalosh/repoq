using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankArray
    {
        private static int counter = 0;
        private static int length = 10;

        private static BankAccount[] Account = new BankAccount[length];

        public static void Add()
        {
            if (length == counter)
            {
                Console.WriteLine("Creating new Account length.");
                length *= 2;
                BankAccount[] AccountSave = new BankAccount[length];
                Console.WriteLine("length{0}", length);

                for (int i = 0; i < counter; i++)
                {
                    AccountSave[i] = new BankAccount();
                    AccountSave[i].Id = Account[i].Id;
                    AccountSave[i].MoneyAmount = Account[i].MoneyAmount;
                }
                Account = AccountSave;
            }
        }

       public static int Counter()
       {
            return counter;
       }

       public static void CounterPlus()
       {
            counter++;
       }

       public static void CreateAccount()
       {
            Account[counter] = new BankAccount();
       }

       public static BankAccount ReturnBankAccount(int number)
       {
            return Account[number];
       }
    }
}