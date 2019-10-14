using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Person
    {
        private static int _id_counter = 0;
        public int Id { get; }
        public string Name { get; set;}
        public string SurName { get; set;}
        public string Nationality { get; set;}
        public string Password { get; set;}

        public Person()
        {
            Id = _id_counter++;
        }
    }
}
