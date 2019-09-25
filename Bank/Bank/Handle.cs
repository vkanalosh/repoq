﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
        private BankArray ArrayBank = new BankArray();

        public void HandleAdd(string accountId)
        {
            BankAccount account = new BankAccount();
            account.Id = accountId;
            account.MoneyAmount = 0;

            ArrayBank.Add(account);
        }

        public void HandleAddRange(string[] arguments)
        {
            int length = 10;
            int counter = 0;
            BankAccount[] account = new BankAccount[length];

            for (int i = 1; i < arguments.Length; i++)
            {
                account[counter] = new BankAccount();
                account[counter].Id = arguments[i];
                account[counter].MoneyAmount = 0;
                counter++;

                if (length == counter)
                {
                    length *= 2;
                    BankAccount[] accountSave = new BankAccount[length];

                    for (int b = 0; b < counter; b++)
                    {
                        accountSave[b] = account[b];
                    }
                    account = accountSave;
                }
            }
                ArrayBank.AddRange(account);
        }

        public void HandlePut(string accountId, decimal money)
        {

            int accountNumberPut = GetById(accountId);
            ArrayBank[accountNumberPut].MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", ArrayBank[accountNumberPut].Id, ArrayBank[accountNumberPut].MoneyAmount);
        }

        public void HandleWidthdraw(string accountId, decimal money)
        {
            int accountNumberWidthdraw = GetById(accountId);


            if (ArrayBank[accountNumberWidthdraw].MoneyAmount < money)
            {
                Console.WriteLine("not enough money.");
            }
            else
            {
                ArrayBank[accountNumberWidthdraw].MoneyAmount -= money;
                Console.WriteLine("Account with ID {0} have {1} money", ArrayBank[accountNumberWidthdraw].Id, ArrayBank[accountNumberWidthdraw].MoneyAmount);
            }
        }

        public void HandleSend(string senderAccount, string recepientAccount, decimal money)
        {
            int senderAccountNumber = GetById(senderAccount);
            int recepientAccountNumber = GetById(recepientAccount);


            if (ArrayBank[senderAccountNumber].MoneyAmount > money)
            {
                ArrayBank[recepientAccountNumber].MoneyAmount += money;
                ArrayBank[senderAccountNumber].MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", ArrayBank[recepientAccountNumber].MoneyAmount, ArrayBank[senderAccountNumber].MoneyAmount);
            }
            else
            {
                Console.WriteLine("not enough money.");
            }
        }

        private int GetById(string accountId)
        {
            int i;

            for (i = 0; i < ArrayBank.Counter(); i++)
            {
                if (accountId == ArrayBank[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}