using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankPerson
{
    public class BankArray
    {
        private int counter = 0;
        private int length = 10;
        private string path = @"C:\Users\Valera\source\repos\Bank\BankArray.txt";

        private BankAccount[] Account = new BankAccount[10];
        private Person[] SomePerson = new Person[10];

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
            CheckName(other.Id);
            StreamWriter writeId = new StreamWriter(path, true);
            writeId.Write($"{other.Id} ");
            writeId.WriteLine(other.MoneyAmount);
            writeId.Close();

            Account[counter] = other;
            counter++;

            CheckLength();
        }

        public void AddRange(BankAccount[] other)
        {
            CheckNameAddRange(other);

            for (int i = 1; i < other.Length; i++)
            {
                Account[counter] = other[i];
                counter++;

                CheckLength();

                StreamWriter writeId = new StreamWriter(path, true);
                writeId.Write($"{other[i].Id} ");
                writeId.WriteLine(other[i].MoneyAmount);
                writeId.Close();
            }
        }

        private void CheckName(string accountId)
        {
            for (int i = 0; i < counter; i++)
            {
                if (accountId == Account[i].Id)
                {
                    throw new Exception("There should not be more than 1 account with same name.");
                }
            }
        }

        private void CheckNameAddRange(BankAccount[] other)
        {
            for (int i = 1; i < other.Length; i++)
            {
                CheckName(other[i].Id);
            }
        }

        private void CheckLength()
        {
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

        public void ReadIdMoney()
        {
            string path = @"C:\Users\Valera\source\repos\Bank\BankArray.txt";
            StreamReader readIdMoney = new StreamReader(path);

            Console.WriteLine(readIdMoney.ReadToEnd());
            readIdMoney.Close();
        }

        public int Counter()
        {
            return counter;
        }
    }
}