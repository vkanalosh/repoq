using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Handle
    {
         static int counter = 0;
         static BankAccount[] Account = new BankAccount[10];
         public static void HandleAdd(string accountid)
        {
            Account[counter] = new BankAccount();
            Account[counter].id = accountid;
            counter++;
        }

         public static void HandlePut(string accountid, string money)
        {
            int account_number_put = GetById(accountid);
            decimal amount_put = Convert.ToDecimal(money);
            Account[account_number_put].MoneyAmount += amount_put;
            Console.WriteLine("Account with ID {0} have {1} money.", Account[account_number_put].id, Account[account_number_put].MoneyAmount);
        }

         public static void HandleWidthdraw(string accountid, string money)
        {
            int account_number_widthdraw = GetById(accountid);
            decimal amount_widthdraw = Convert.ToDecimal(money);

            if (Account[account_number_widthdraw].MoneyAmount < amount_widthdraw)
            {
                Console.WriteLine("not enough money.");
            }

            else
            {
                Account[account_number_widthdraw].MoneyAmount -= amount_widthdraw;
                Console.WriteLine("Account with ID {0} have {1} money", Account[account_number_widthdraw].id, Account[account_number_widthdraw].MoneyAmount);
            }
        }

         public static void HandleSend(string senderAccountNumber, string recepientAccountNumber, string money)
        {
            int sender_AccountNumber = GetById(senderAccountNumber);
            int recepient_AccountNumber = GetById(recepientAccountNumber);
            decimal amount_send = Convert.ToDecimal(money);

            if (Account[sender_AccountNumber].MoneyAmount > amount_send)
            {
                Account[recepient_AccountNumber].MoneyAmount += amount_send;
                Account[sender_AccountNumber].MoneyAmount -= amount_send;
                Console.WriteLine("recepient = {0}\nsender = {1}", Account[recepient_AccountNumber].MoneyAmount, Account[sender_AccountNumber].MoneyAmount);
            }

            else
            {
                Console.WriteLine("not enough money.");
            }
        }

          static int GetById(string accountid)
        {
            int i;
            for (i = 0; i < counter; i++)
            {
                if (accountid == Account[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
