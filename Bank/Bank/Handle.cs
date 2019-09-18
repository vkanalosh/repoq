using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Handle
    {
        public static void HandleAdd(string accountid)
        {
            Array.Add();
            Array.Account[Array.Counter] = new BankAccount();
            Array.Account[Array.Counter].Id = accountid;
            Array.Counter++;
        }

        public static void HandlePut(string accountId, decimal money)
        {
            int AccountNumberPut = GetById(accountId);
            Array.Account[AccountNumberPut].MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", Array.Account[AccountNumberPut].Id, Array.Account[AccountNumberPut].MoneyAmount);
        }

         public static void HandleWidthdraw(string accountId, decimal money)
         {
            int AccountNumberWidthdraw = GetById(accountId);

            if (Array.Account[AccountNumberWidthdraw].MoneyAmount < money)
            {
                Console.WriteLine("not enough money.");
            }
            else
            {
                Array.Account[AccountNumberWidthdraw].MoneyAmount -= money;
                Console.WriteLine("Account with ID {0} have {1} money", Array.Account[AccountNumberWidthdraw].Id, Array.Account[AccountNumberWidthdraw].MoneyAmount);
            }
         }

         public static void HandleSend(string senderAccount, string recepientAccount, decimal money)
         {
            int senderAccountNumber = GetById(senderAccount);
            int recepientAccountNumber = GetById(recepientAccount);

            if (Array.Account[senderAccountNumber].MoneyAmount > money)
            {
                Array.Account[recepientAccountNumber].MoneyAmount += money;
                Array.Account[senderAccountNumber].MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", Array.Account[recepientAccountNumber].MoneyAmount, Array.Account[senderAccountNumber].MoneyAmount);
            }

            else
            {
                Console.WriteLine("not enough money.");
            }
         }

          public static int GetById(string accountId)
          {
            int i;
            for (i = 0; i < Array.Counter; i++)
            {
                if (accountId == Array.Account[i].Id)
                {
                    return i;
                }
            }
            return -1;
          }
    }
}