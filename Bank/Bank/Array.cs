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
            if (length == counter)
            {
                Console.WriteLine("Creating new Account length.");
                length *= 2;
                BankAccount[] AccountSave = new BankAccount[length];
                Console.WriteLine("length{0}", length);
                
                for (int i = 0; i < counter; i++)
                {
                    AccountSave[i] = new BankAccount();
                    AccountSave[i].Id = Account[i].Id;
                    AccountSave[i].MoneyAmount = Account[i].MoneyAmount;
                }
                Account = AccountSave;
            }
        } 
    }
}