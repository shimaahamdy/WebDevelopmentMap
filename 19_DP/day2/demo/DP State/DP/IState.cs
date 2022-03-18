using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State.DP
{
    interface IState
    {
        ///Context 
        BankAccount BankAccount { get; set; }

        bool PerformGetLoan();
        decimal PerformGetInterest();
        void PerformDebit(decimal Amount);
        void PerformCredit(decimal Amount);
    }

    class RedState:IState
    {
        BankAccount bankAccount;
        public BankAccount BankAccount { get => bankAccount; set => bankAccount = value; }
        
        public RedState(BankAccount account)=> bankAccount = account;
        
        public bool PerformGetLoan() => false;
        public decimal PerformGetInterest() => 0;

        public void PerformDebit(decimal Amount)
        {
            throw new NotImplementedException();
        }

        public void PerformCredit(decimal Amount)
        {
            bankAccount.AccountBalance += Amount;
            if (bankAccount.AccountBalance > 0)
                bankAccount.State = new ClassicState(bankAccount);
        }
    }

    class ClassicState : IState
    {
        BankAccount bankAccount;
        public BankAccount BankAccount { get => bankAccount; set => bankAccount = value; }

        public ClassicState(BankAccount account) => bankAccount = account;

        public bool PerformGetLoan() => false;
        public decimal PerformGetInterest() => 100;

        public void PerformDebit(decimal Amount)
        {
            throw new NotImplementedException();
        }

        public void PerformCredit(decimal Amount)
        {
            throw new NotImplementedException();
        }
    }

    class SilverState : IState
    {
        BankAccount bankAccount;
        public BankAccount BankAccount { get => bankAccount; set => bankAccount = value; }

        public SilverState(BankAccount account)=> bankAccount = account;

        public decimal PerformGetInterest() => 0.1M * bankAccount.AccountBalance; 

        public bool PerformGetLoan() => true;

        public void PerformDebit(decimal Amount)
        {
            throw new NotImplementedException();
        }

        public void PerformCredit(decimal Amount)
        {
            throw new NotImplementedException();
        }
    }


}
