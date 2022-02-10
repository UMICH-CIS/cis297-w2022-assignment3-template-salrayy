using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summer Alrayyashi
/// CIS 297 Winter 2022
/// This class is the Checking Account class that is inherited from the Account class that calculates any necessary fees and charges.
/// </summary>

namespace BankApplication
{
    public class CheckingAccount : Account
    {
        //data member
        private decimal FeeCharged;
        //constructor
        public CheckingAccount(decimal Balance, decimal FeeCharged) : base(Balance)
        {
            setFeeAmount(FeeCharged);
        }
        //member functions
        void setFeeAmount(decimal FeeCharged)
        {
            if (FeeCharged >= 0)
            {
                this.FeeCharged = FeeCharged;
            }
            else { this.FeeCharged = 0; }
        }
        public override void Credit(decimal Balance)
        {
            base.Credit(Balance);
            base.Debit(this.FeeCharged);
        }
        public override bool Debit(decimal Balance)
        {
            if (base.Debit(Balance))
            {
                base.Debit(this.FeeCharged);
                return true;
            }
            return false;
        }

    }

    
}
