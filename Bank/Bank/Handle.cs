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
            Array.Account[Array.counter] = new BankAccount();
            Array.Account[Array.counter].Id = accountid;
            Array.counter++;
        }

        public static void HandlePut(string accountid, decimal money)
        {
            int AccountNumberPut = GetById(accountid);
            Array.Account[AccountNumberPut].MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", Array.Account[AccountNumberPut].Id, Array.Account[AccountNumberPut].MoneyAmount);
        }

         public static void HandleWidthdraw(string accountid, decimal money)
        {
            int AccountNumberWidthdraw = GetById(accountid);

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

         public static void HandleSend(string senderAccountNumber, string recepientAccountNumber, decimal money)
        {
            int SenderAccountNumber = GetById(senderAccountNumber);
            int RecepientAccountNumber = GetById(recepientAccountNumber);

            if (Array.Account[SenderAccountNumber].MoneyAmount > money)
            {
                Array.Account[RecepientAccountNumber].MoneyAmount += money;
                Array.Account[SenderAccountNumber].MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", Array.Account[RecepientAccountNumber].MoneyAmount, Array.Account[SenderAccountNumber].MoneyAmount);
            }

            else
            {
                Console.WriteLine("not enough money.");
            }
        }

          static int GetById(string accountid)
        {
            int i;
            for (i = 0; i < Array.counter; i++)
            {
                if (accountid == Array.Account[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}