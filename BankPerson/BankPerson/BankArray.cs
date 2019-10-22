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

        private int counterAdmin = 0;
        private int counterPerson = 0;

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

        public void AddPerson(string name, string password)
        {
            if (counterAdmin == 1)
            {
                SomePerson[counterPerson] = new Person();
                SomePerson[counterPerson].Name = name;
                SomePerson[counterPerson].Password = password;
                counterPerson++;
            }
            else
            {
                throw new Exception("Only admin user can add person.");
            }
        }

        public void Add(BankAccount other, string userName)
        {
            CheckName(other.Id);

            StreamWriter writeId = new StreamWriter(path, true);
            writeId.Write($"{other.Id} ");
            writeId.WriteLine(other.MoneyAmount);
            writeId.Close();

            Account[counter] = other;

            int personNumber = Person(userName);
            SomePerson[personNumber].PersonAccount[SomePerson[personNumber].Counter] = other;
            SomePerson[personNumber].CounterPlus();

            CheckLength();
        }

        public void AddRange(BankAccount[] other, string userName)
        {
            CheckNameAddRange(other);

            for (int i = 2; i < other.Length; i++)
            {
                Account[counter] = other[i];
                counter++;

                CheckLength();

                StreamWriter writeId = new StreamWriter(path, true);
                writeId.Write($"{other[i].Id} ");
                writeId.WriteLine(other[i].MoneyAmount);
                writeId.Close();
            }

            for (int i = 2; i < other.Length; i++)
            {
                int personNumber = Person(userName);
                SomePerson[personNumber].PersonAccount[SomePerson[personNumber].Counter] = other[i];
                SomePerson[personNumber].CounterPlus();
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
            for (int i = 2; i < other.Length; i++)
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

        public int AdminCounter()
        {
            return counterAdmin;
        }

        public void AdminPlus()
        {
            counterAdmin++;
        }

        public int Person(string userName)
        {
            int a = 0;

            for (int i = 0; i < counterPerson; i++)
            {
                if (SomePerson[i].Name == userName)
                {
                    a = i;
                }
            }
            return a;
        }
    }
}