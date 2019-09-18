using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Array
    {
        public static int Counter = 0;
        public static int Length = 10;

        public static BankAccount[] Account = new BankAccount[Length];

        public static void Add()
        {
            if (Length == Counter)
            {
                Console.WriteLine("Creating new Account length.");
                Length *= 2;
                BankAccount[] AccountSave = new BankAccount[Length];
                Console.WriteLine("length{0}", Length);
                
                for (int i = 0; i < Counter; i++)
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