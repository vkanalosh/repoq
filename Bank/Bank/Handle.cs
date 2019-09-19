using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
        public static BankArray ArrayBank = new BankArray();

        public static void HandleAdd(string accountId)
        {
            ArrayBank.Add(accountId);
        }

        public static void HandlePut(string accountId, decimal money)
        {
           
            int accountNumberPut = GetById(accountId);
            ArrayBank.ReturnBankAccount(accountNumberPut).MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", ArrayBank.ReturnBankAccount(accountNumberPut).Id, ArrayBank.ReturnBankAccount(accountNumberPut).MoneyAmount);
        }

        public static void HandleWidthdraw(string accountId, decimal money)
        {
            int accountNumberWidthdraw = GetById(accountId);
          

            if (ArrayBank.ReturnBankAccount(accountNumberWidthdraw).MoneyAmount < money)
            {
                Console.WriteLine("not enough money.");
            }
            else
            {
                ArrayBank.ReturnBankAccount(accountNumberWidthdraw).MoneyAmount -= money;
                Console.WriteLine("Account with ID {0} have {1} money", ArrayBank.ReturnBankAccount(accountNumberWidthdraw).Id, ArrayBank.ReturnBankAccount(accountNumberWidthdraw).MoneyAmount);
            }
        }

        public static void HandleSend(string senderAccount, string recepientAccount, decimal money)
        {
            int senderAccountNumber = GetById(senderAccount);
            int recepientAccountNumber = GetById(recepientAccount);
           

            if (ArrayBank.ReturnBankAccount(senderAccountNumber).MoneyAmount > money)
            {
                ArrayBank.ReturnBankAccount(recepientAccountNumber).MoneyAmount += money;
                ArrayBank.ReturnBankAccount(senderAccountNumber).MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", ArrayBank.ReturnBankAccount(recepientAccountNumber).MoneyAmount, ArrayBank.ReturnBankAccount(senderAccountNumber).MoneyAmount);
            }
            else
            {
                Console.WriteLine("not enough money.");
            }
        }

        public static int GetById(string accountId)
        {
            int i;
            

            for (i = 0; i < ArrayBank.Counter(); i++)
            {
                if (accountId == ArrayBank.ReturnBankAccount(i).Id)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}