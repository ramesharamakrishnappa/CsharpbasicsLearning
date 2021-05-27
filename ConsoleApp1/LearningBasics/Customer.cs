using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LearningBasics
{
    public class Customer
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.customerName = "ramesha";
            bank.Deposit(150000);
            bank.WithdrawAmmount(6000);
            bank.WithdrawAmmount(44000);
            bank.WithdrawAmmount(40000);
            bank.Deposit(50000);
            //Console.WriteLine($"Your balance is {bank.Balance} ");
        }

    }
}
