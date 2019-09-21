using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
        public BankArray ArrayBank = new BankArray();

        private BankAccount[] Account = new BankAccount[10];

        public void HandleAdd(string accountId)
        {
            Add(accountId);
        }

        public void HandleAddRange(string[] arguments)
        {
            AddRange(arguments);
        }

        public void HandlePut(string accountId, decimal money)
        {

            int accountNumberPut = GetById(accountId);
            Account[accountNumberPut].MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", Account[accountNumberPut].Id, Account[accountNumberPut].MoneyAmount);
        }

        public void HandleWidthdraw(string accountId, decimal money)
        {
            int accountNumberWidthdraw = GetById(accountId);


            if (Account[accountNumberWidthdraw].MoneyAmount < money)
            {
                Console.WriteLine("not enough money.");
            }
            else
            {
                Account[accountNumberWidthdraw].MoneyAmount -= money;
                Console.WriteLine("Account with ID {0} have {1} money", Account[accountNumberWidthdraw].Id, Account[accountNumberWidthdraw].MoneyAmount);
            }
        }

        public void HandleSend(string senderAccount, string recepientAccount, decimal money)
        {
            int senderAccountNumber = GetById(senderAccount);
            int recepientAccountNumber = GetById(recepientAccount);


            if (Account[senderAccountNumber].MoneyAmount > money)
            {
                Account[recepientAccountNumber].MoneyAmount += money;
                Account[senderAccountNumber].MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", Account[recepientAccountNumber].MoneyAmount, Account[senderAccountNumber].MoneyAmount);
            }
            else
            {
                Console.WriteLine("not enough money.");
            }
        }

        public void Add(string accountId)
        {
            for (int i = 0; i < ArrayBank.Counter(); i++)
            {
                if (accountId == Account[i].Id)
                {
                    throw new Exception("There should not be more than 1 account with same name.");
                }
            }

            Account[ArrayBank.Counter()] = new BankAccount();
            Account[ArrayBank.Counter()].Id = accountId;
            ArrayBank.CounterPlus();

            if (ArrayBank.Length() == ArrayBank.Counter())
            {
                Console.WriteLine("Creating new Account length.");
                ArrayBank.DoubleLength();
                BankAccount[] AccountSave = new BankAccount[ArrayBank.Length()];
                Console.WriteLine("length{0}", ArrayBank.Length());

                for (int i = 0; i < ArrayBank.Counter(); i++)
                {
                    AccountSave[i] = new BankAccount();
                    AccountSave[i] = Account[i];
                }
                Account = AccountSave;
            }
        }

        public void AddRange(string[] arguments)
        {
            for (int i = 1; i < ArrayBank.Counter(); i++)
            {
                if (arguments[i] == Account[i].Id)
                {
                    throw new Exception("There should not be more than 1 account with same name.");
                }
            }

            for (int i = 1; i < arguments.Length; i++)
            {
                Account[ArrayBank.Counter()] = new BankAccount();
                Account[ArrayBank.Counter()].Id = arguments[i];
                ArrayBank.CounterPlus();

                if (ArrayBank.Length() == ArrayBank.Counter())
                {
                    Console.WriteLine("Creating new Account length.");
                    ArrayBank.DoubleLength();
                    BankAccount[] AccountSave = new BankAccount[ArrayBank.Length()];
                    Console.WriteLine("length{0}", ArrayBank.Length());

                    for (int b = 0; b < ArrayBank.Counter(); b++)
                    {
                        AccountSave[b] = new BankAccount();
                        AccountSave[b] = Account[b];
                    }
                    Account = AccountSave;
                }
            }
        }

        public int GetById(string accountId)
        {
            int i;

            for (i = 0; i < ArrayBank.Counter(); i++)
            {
                if (accountId == Account[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}