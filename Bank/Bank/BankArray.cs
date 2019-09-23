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
            CheckAdd(accountId);

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
                    AccountSave[i] = Account[i];
                }
                Account = AccountSave;
            }
        }

        public void AddRange(string[] arguments)
        {
            CheckAddRange(arguments);

            for (int i = 1; i < arguments.Length; i++)
            {
                Account[counter] = new BankAccount();
                Account[counter].Id = arguments[i];
                counter++;

                if (length == counter)
                {
                    Console.WriteLine("Creating new Account length.");
                    length *= 2;
                    BankAccount[] AccountSave = new BankAccount[length];
                    Console.WriteLine("length{0}", length);

                    for (int b = 0; b < counter; b++)
                    {
                        AccountSave[b] = Account[b];
                    }
                    Account = AccountSave;
                }
            }
        }

        private void CheckAdd(string accountId)
        {
            for (int i = 0; i < counter; i++)
            {
                if (accountId == Account[i].Id)
                {
                    throw new Exception("There should not be more than 1 account with same name.");
                }
            }
        }

        private void CheckAddRange(string[] arguments)
        {
            for (int i = 1; i < Account.Length; i++)
            {
                for (int b = 0; b < Account.Length; b++)
                {
                    if (arguments[i] == Account[b].Id)
                    {
                        throw new Exception("There should not be more than 1 account with same name.");
                    }
                }
            }
        }

        public int Counter()
        {
            return counter;
        }

        public int Length()
        {
            return length;
        }
    }
}