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

        public static void HandlePut(string accountid, string money)
        {
            int account_number_put = GetById(accountid);
            decimal amount_put = Convert.ToDecimal(money);
            Array.Account[account_number_put].MoneyAmount += amount_put;
            Console.WriteLine("Account with ID {0} have {1} money.", Array.Account[account_number_put].Id, Array.Account[account_number_put].MoneyAmount);
        }

         public static void HandleWidthdraw(string accountid, string money)
        {
            int account_number_widthdraw = GetById(accountid);
            decimal amount_widthdraw = Convert.ToDecimal(money);

            if (Array.Account[account_number_widthdraw].MoneyAmount < amount_widthdraw)
            {
                Console.WriteLine("not enough money.");
            }

            else
            {
                Array.Account[account_number_widthdraw].MoneyAmount -= amount_widthdraw;
                Console.WriteLine("Account with ID {0} have {1} money", Array.Account[account_number_widthdraw].Id, Array.Account[account_number_widthdraw].MoneyAmount);
            }
        }

         public static void HandleSend(string senderAccountNumber, string recepientAccountNumber, string money)
        {
            int sender_AccountNumber = GetById(senderAccountNumber);
            int recepient_AccountNumber = GetById(recepientAccountNumber);
            decimal amount_send = Convert.ToDecimal(money);

            if (Array.Account[sender_AccountNumber].MoneyAmount > amount_send)
            {
                Array.Account[recepient_AccountNumber].MoneyAmount += amount_send;
                Array.Account[sender_AccountNumber].MoneyAmount -= amount_send;
                Console.WriteLine("recepient = {0}\nsender = {1}", Array.Account[recepient_AccountNumber].MoneyAmount, Array.Account[sender_AccountNumber].MoneyAmount);
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