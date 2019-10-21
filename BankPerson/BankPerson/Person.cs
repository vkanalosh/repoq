using System;
using System.Collections.Generic;
using System.Text;

namespace BankPerson
{
    public class Person
    {
        public BankAccount[] PersonAccount = new BankAccount[10];

        public BankAccount this[int index]
        {
            get
            {
                return PersonAccount[index];
            }
            set
            {
                PersonAccount[index] = value;
            }
        }

        public BankAccount Return(int index)
        {
            return PersonAccount[index];
        }

        private static int _id_counter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Nationality { get; set; }
        public string Password { get; set; }

        public Person()
        {
            Id = _id_counter++;
        }
    }
}