using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
       public static void HandleAdd(string accountId)
       {
            Array.Add();
            Array.CreateAccount();
            Array.ReturnBankAccount(Array.Counter()).Id = accountId;
            Array.CounterPlus();
       }
        
       public static void HandlePut(string accountId, decimal money)
       {
           int AccountNumberPut = GetById(accountId);
           Array.ReturnBankAccount(AccountNumberPut).MoneyAmount += money;
           Console.WriteLine("Account with ID {0} have {1} money.", Array.ReturnBankAccount(AccountNumberPut).Id, Array.ReturnBankAccount(AccountNumberPut).MoneyAmount);
       }
      
       public static void HandleWidthdraw(string accountId, decimal money)
       {
           int AccountNumberWidthdraw = GetById(accountId);

           if (Array.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount < money)
           {
               Console.WriteLine("not enough money.");
           }
           else
           {
               Array.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount -= money;
               Console.WriteLine("Account with ID {0} have {1} money", Array.ReturnBankAccount(AccountNumberWidthdraw).Id, Array.ReturnBankAccount(AccountNumberWidthdraw).MoneyAmount);
           }
       }

       public static void HandleSend(string senderAccount, string recepientAccount, decimal money)
       {
           int senderAccountNumber = GetById(senderAccount);
           int recepientAccountNumber = GetById(recepientAccount);

           if (Array.ReturnBankAccount(senderAccountNumber).MoneyAmount > money)
           {
               Array.ReturnBankAccount(recepientAccountNumber).MoneyAmount += money;
               Array.ReturnBankAccount(senderAccountNumber).MoneyAmount -= money;
               Console.WriteLine("recepient = {0}\nsender = {1}", Array.ReturnBankAccount(recepientAccountNumber).MoneyAmount, Array.ReturnBankAccount(senderAccountNumber).MoneyAmount);
           }
           else
           {
               Console.WriteLine("not enough money.");
           }
       }
     
       public static int GetById(string accountId)
       {
            int i;
            for (i = 0; i < Array.Counter(); i++)
            {
                if (accountId == Array.ReturnBankAccount(i).Id)
                {
                    return i;
                }
            }
            return -1;
       }
    }
}