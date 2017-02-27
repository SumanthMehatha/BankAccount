using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        private int accNumber;
        private string accHolder;
        private double balance;

        public Account(int accNumber, string accHolder)
        {
            this.accNumber = accNumber;
            this.accHolder = accHolder;
        }

        public Account(int accNumber, string accHolder, double balance)
        {
            this.accNumber = accNumber;
            this.accHolder = accHolder;
            this.balance = balance;
        }

        public void Print()
        {
            Console.WriteLine(this.accHolder);
            Console.WriteLine(this.accNumber);
            Console.WriteLine(this.balance);
        }

        public void Deposit(double b)
        {
            balance += b;
        }

        public void Withdraw(double b)
        {
            balance -= b;
        }

        public void CheckBalance()
        {
            Console.WriteLine(this.balance);
        }
    }

    public class Bank
    {
        public static void Main()
        {
            Account a1 = new Account(11, "Satya Nadella");
            a1.Deposit(10000);
            a1.Print();
            a1.Deposit(44);
            a1.CheckBalance();
            a1.Withdraw(2);
            a1.CheckBalance();
            Console.ReadLine();
            
        }
    }
}
