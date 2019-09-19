using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankArray
    {
        private int counter = 0;
        private int length = 10;

        private BankAccount[] Account = new BankAccount[10];

        public BankAccount this[int index]
        {
            get
            {
                return Account[index];
            }
        }
        
        public void Add(string accountId)
        {
            Account[counter] = new BankAccount();
            Account[counter].Id = accountId;
            counter++;

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

       public int Counter()
       {
            return counter;
       }

       public BankAccount ReturnBankAccount(int number)
       {
            return Account[number];
       }
    }
}