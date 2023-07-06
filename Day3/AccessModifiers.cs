using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class AccessModifiers
    {
        //public class
        public class Person
        {
            public string Name;
            public int Age;

            public void SayHello()
            {
                Console.WriteLine("Hello, my name is " + Name);
            }
        }

        //private class
        public class BankAccount
        {
            private decimal balance;

            public void Deposit(decimal amount)
            {
                balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
            }
        }
    }
}
