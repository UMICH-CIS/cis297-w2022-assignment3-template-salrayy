using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summer Alrayyashi
/// CIS 297 Winter 2022
/// This class is the Account class that  retrieves the current balance and if the credit or debit limit has been exceeded.
/// </summary>

namespace BankApplication
{
    public class Account
    {
        private decimal balance;
        public decimal Balance
        {
            get
            { return balance; }

            set
            { balance = value; }
        }

        public Account(decimal initialBalance)
        {
            if (initialBalance >= 0.0m)
            {
                Balance = initialBalance;
            }
            else
            {
                throw new Exception();
            }

        }

        public virtual void Credit(decimal Amount)
        {
            balance += Amount;
        }

        public virtual bool Debit(decimal Amount)
        {
            if (Amount > balance)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                balance -= Amount;
                return true;
            }

        }

    }

}
