using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LearningBasics
{

    public class Bank

    {
        private int accountNumber = 1000000000;
        public string customerName;
        private double balance;


        public int AccountNumber
        {
            get
            {
                // accountNumber= accountNumber + 1;
                return accountNumber;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

        }

        public void WithdrawAmmount(double amount)
        {

            double tempbalance = balance - amount;
            if (tempbalance >= 0)
            {
                balance = balance - amount;
                Console.WriteLine($"Rs {amount} debited from your a/c {AccountNumber} and the current balance is Rs {balance}");
            }
            else
                Console.WriteLine($"you do not have sufficient balance to withdraw mentioned amount Rs {amount}");

        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine($"Deposit of Rs {amount} to the account number {AccountNumber} is successfull and your balance is {balance}");
            }
            else
                Console.WriteLine("please enter valid amount which should be greater than Zero(0)");
        }

    }


}
