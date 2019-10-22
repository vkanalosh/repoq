using System;
using System.Collections.Generic;
using System.Text;

namespace BankPerson
{
    public class Handle
    {
        private BankArray ArrayBank = new BankArray();

        int counterAdmin = 0;

        public void HandleLogin()
        {
            string admin = "admin";

            Console.WriteLine("Write login.");
            string login = Console.ReadLine();

            Console.WriteLine("Write password.");
            string password = Console.ReadLine();

            if ((login == admin) && (password == admin))
            {
                ArrayBank.AdminPlus();
            }

            if (ArrayBank.AdminCounter() > 1)
            {
                throw new Exception("By default there should be 1 person in the system with login admin and password admin.");
            }

            Console.WriteLine("Login successful.");
        }

        public void HandleAddPerson(string name, string password)
        {
            ArrayBank.AddPerson(name, password);
        }

        public void HandleAdd(string userName, string accountId)
        {
            BankAccount account = new BankAccount(accountId);
            account.MoneyAmount = 0;

            ArrayBank.Add(account, userName);
        }

        public void HandleAddRange(string[] arguments)
        {
            string userName = arguments[1];
            BankAccount[] account = new BankAccount[arguments.Length];

            for (int i = 2; i < arguments.Length; i++)
            {
                account[i] = new BankAccount(arguments[i]);
                account[i].MoneyAmount = 0;

            }
            ArrayBank.AddRange(account, userName);
        }

        public void HandlePut(string accountId, decimal money)
        {
            int accountNumberPut = GetById(accountId);
            ArrayBank[accountNumberPut].MoneyAmount += money;
            Console.WriteLine("Account with ID {0} have {1} money.", ArrayBank[accountNumberPut].Id, ArrayBank[accountNumberPut].MoneyAmount);
        }

        public void HandleWidthdraw(string accountId, decimal money)
        {
            int accountNumberWidthdraw = GetById(accountId);

            if (ArrayBank[accountNumberWidthdraw].MoneyAmount < money)
            {
                throw new Exception("not enough money.");
            }
            else
            {
                ArrayBank[accountNumberWidthdraw].MoneyAmount -= money;
                Console.WriteLine("Account with ID {0} have {1} money", ArrayBank[accountNumberWidthdraw].Id, ArrayBank[accountNumberWidthdraw].MoneyAmount);
            }
        }

        public void HandleSend(string senderAccount, string recepientAccount, decimal money)
        {
            int senderAccountNumber = GetById(senderAccount);
            int recepientAccountNumber = GetById(recepientAccount);


            if (ArrayBank[senderAccountNumber].MoneyAmount > money)
            {
                ArrayBank[recepientAccountNumber].MoneyAmount += money;
                ArrayBank[senderAccountNumber].MoneyAmount -= money;
                Console.WriteLine("recepient = {0}\nsender = {1}", ArrayBank[recepientAccountNumber].MoneyAmount, ArrayBank[senderAccountNumber].MoneyAmount);
            }
            else
            {
                throw new Exception("not enough money.");
            }
        }

        public void HandleList(string userName)
        {
            if (userName == "admin")
            {
                if (ArrayBank.AdminCounter() > 1)
                {
                    throw new Exception("Only admin can watch all accounts.");
                }

                for(int i = 0; i < ArrayBank.PersonCounter(); i++)
                {
                    Person person = new Person();
                    person = ArrayBank.Person(i);

                    Console.WriteLine($"Person {person.Name}");

                    for(int j = 0; j < person.Counter; j++)
                    {
                        Console.WriteLine($"{ArrayBank.Person(i).PersonAccount[j].Id} {ArrayBank.Person(i).PersonAccount[j].MoneyAmount}");
                    }
                }
            }
            else
            {
                int personNumber = ArrayBank.Person(userName);
                Person person = new Person();
                person = ArrayBank.Person(personNumber);

                for (int i = 0; i < person.Counter; i++)
                {
                    Console.WriteLine($"{ArrayBank.Person(personNumber).PersonAccount[i].Id} {ArrayBank.Person(personNumber).PersonAccount[i].MoneyAmount}");
                }
            }
        }

        private int GetById(string accountId)
        {
            for (int i = 0; i < ArrayBank.Counter(); i++)
            {
                if (accountId == ArrayBank[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}