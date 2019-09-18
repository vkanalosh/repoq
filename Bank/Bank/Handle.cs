using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
       public static void HandleAdd(string accountId)
       {
            BankArray.Add();
            BankArray.CreateAccount();
            BankArray.ReturnBankAccount(BankArray.Counter()).Id = accountId;
            BankArray.CounterPlus();
       }
        
       public static void HandlePut(string accountId, decimal money)
       {
           int AccountNumberPut = GetById(accountId);
           BankArray.ReturnBankAccount(AccountNumberPut).MoneyAmount += money;
           Console.WriteLine("Account with ID {0} have {1} money.", BankArray.ReturnBankAccount(AccountNumberPut).Id, BankArray.ReturnBankAccount(AccountNumberPut).MoneyAmount);
       }
      
       public static void HandleWidthdraw(string accountId, decimal money)
       {
           int AccountNumberWidthdraw = GetById(accountId);

           if (BankArray.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount < money)
           {
               Console.WriteLine("not enough money.");
           }
           else
           {
               BankArray.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount -= money;
               Console.WriteLine("Account with ID {0} have {1} money", BankArray.ReturnBankAccount(AccountNumberWidthdraw).Id, BankArray.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount);
           }
       }

       public static void HandleSend(string senderAccount, string recepientAccount, decimal money)
       {
           int senderAccountNumber = GetById(senderAccount);
           int recepientAccountNumber = GetById(recepientAccount);

           if (BankArray.ReturnBankAccount(senderAccountNumber).MoneyAmount > money)
           {
               BankArray.ReturnBankAccount(recepientAccountNumber).MoneyAmount += money;
               BankArray.ReturnBankAccount(senderAccountNumber).MoneyAmount -= money;
               Console.WriteLine("recepient = {0}\nsender = {1}", BankArray.ReturnBankAccount(recepientAccountNumber).MoneyAmount, BankArray.ReturnBankAccount(senderAccountNumber).MoneyAmount);
           }
           else
           {
               Console.WriteLine("not enough money.");
           }
       }
     
       public static int GetById(string accountId)
       {
            int i;
            for (i = 0; i < BankArray.Counter(); i++)
            {
                if (accountId == BankArray.ReturnBankAccount(i).Id)
                {
                    return i;
                }
            }
            return -1;
       }
    }
}