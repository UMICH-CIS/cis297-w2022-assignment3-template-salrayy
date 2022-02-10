using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication
{
    public class checkingaccountt : Accountt
    {
        private int FeeCharged;

        public int FeeAmount
        {
            get => default;
            set
            {
            }
        }

        public void Debit()
        {
            throw new System.NotImplementedException();
        }

        public void Credit()
        {
            throw new System.NotImplementedException();
        }
    }
}