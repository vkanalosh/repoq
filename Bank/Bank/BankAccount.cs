using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        public string Id { get;}

        public decimal MoneyAmount { get; set;}

        public BankAccount(string id)
        {
            Id = id;
        }
    }
}