using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State.No_SP
{
     class BankAccount
    {
        public int ID { get; set; }
        public string? CustName { get; set; }
        
        decimal Balance;
        public decimal AccountBalance { get => Balance; }

        public AccountState State { get; protected set; }

        public BankAccount(decimal Amount)
        {
            this.Balance = Amount;
            
            StateTransition();
        }

        public bool GetLoan ()
        {
            switch (State)
            {
                case AccountState.Red:
                case AccountState.Classic:
                    return false;
                case AccountState.Silver:
                    return true;
            }
            return false;
        }

        public decimal GetInterest ()
        {
            switch (State)
            {
                case AccountState.Red:
                    return 0;
                case AccountState.Classic:
                    return 100;
                case AccountState.Silver:
                    return Balance * 0.1M;
            }
            return 0;
        }

        public void Debit (decimal Amount)
        {
            this.Balance -= Amount;

            StateTransition();
        }

        protected void StateTransition ()
        {
            if (Balance < 0)
                this.State = AccountState.Red;
            else if (Balance < 10_000)
                this.State = AccountState.Classic;
            else
                this.State = AccountState.Silver;
        }

        public void Credit (decimal Amount)
        {
            this.Balance += Amount;
            StateTransition();

        }

    }
}
