﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankArray
    {
        private int counter = 0;
        private int length = 10;

        private BankAccount[] Account = new BankAccount[10];

        public BankAccount this[int index]
        {
            get
            {
                return Account[index];
            }
            set
            {
                Account[index] = value;
            }
        }

        public void Add(BankAccount other)
        {
            CheckAdd(other.Id);

            Account[counter] = other;
            counter++;

            if (length == counter)
            {
                Console.WriteLine("Creating new Account length.");
                length *= 2;
                BankAccount[] AccountSave = new BankAccount[length];
                Console.WriteLine("length{0}", length);

                for (int i = 0; i < counter; i++)
                {
                    AccountSave[i] = Account[i];
                }
                Account = AccountSave;
            }
        }

        public void AddRange(BankAccount[] other)
        {
            CheckAddRange(other);

            for (int i = 1; i < other.Length; i++)
            {
                Account[counter] = other[counter];
                counter++;

                if (length == counter)
                {
                    Console.WriteLine("Creating new Account length.");
                    length *= 2;
                    BankAccount[] AccountSave = new BankAccount[length];
                    Console.WriteLine("length{0}", length);

                    for (int b = 0; b < counter; b++)
                    {
                        AccountSave[b] = Account[b];
                    }
                    Account = AccountSave;
                }
            }
        }

        private void CheckAdd(string accountId)
        {
            for (int i = 0; i < counter; i++)
            {
                if (accountId == Account[i].Id)
                {
                    throw new Exception("There should not be more than 1 account with same name.");
                }
            }
        }

        private void CheckAddRange(BankAccount[] other)
        {
            for (int i = 1; i < other.Length; i++)
            {
                for (int b = 0; b < counter; b++)
                {
                    if (other[i].Id == Account[b].Id)
                    {
                        throw new Exception("There should not be more than 1 account with same name.");
                    }
                }
            }
        }

        public int Counter()
        {
            return counter;
        }
    }
}