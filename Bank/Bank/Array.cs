using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Array
    {
        public static int counter = 0;
        public static int length = 10;

        public static BankAccount[] Account = new BankAccount[length];

        public static void Add()
        {
            BankAccount[] AccountSave = new BankAccount[counter];
            
            if (length == counter)
            {

                Console.WriteLine("Creating new Account length.");
                length *= 2;
                Console.WriteLine("length{0}", length);

                for (int i = 0; i == counter; i++)
                {
                    AccountSave[i].Id = Account[i].Id;
                    AccountSave[i].MoneyAmount = Account[i].MoneyAmount;
                }

                Account = new BankAccount[length];

                for (int i = 0; i == counter; i++)
                {
                    Account[i].Id = AccountSave[i].Id;
                    Account[i].MoneyAmount = AccountSave[i].MoneyAmount;
                }
            }
        } 
    }
}