using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State.DP
{
    class BankAccount
    {
        public int ID { get; set; }
        public string? CustName { get; set; }

        decimal Balance;
        public decimal AccountBalance { get => Balance; internal set => Balance = value; }

        ///Composition , Abstraction not concerete Implementation
        internal IState State;
        
        public BankAccount(decimal Amount)
        {
            if (Amount < 0)
                this.State = new RedState(this);
            else if (Amount > 10_000)
                this.State = new ClassicState(this);
            else
                this.State = new SilverState(this);
        }

        ///Delegation
        public bool GetLoan()
        {
            return State.PerformGetLoan();
        }
        public decimal GetInterest()
        {
            return State.PerformGetInterest();
        }

        public void Credit(decimal Amount) => State.PerformCredit(Amount);

        public void Debit(decimal Amount)=> State.PerformDebit(Amount);
    }
}
