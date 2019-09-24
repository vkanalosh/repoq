using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
        private BankArray ArrayBank = new BankArray();

        public void HandleAdd(string accountId)
        {
            ArrayBank.Add(accountId);
        }

        public void HandleAddRange(string[] arguments)
        {
            ArrayBank.AddRange(arguments);
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