using Boolean.CSharp.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Customer
    {
        public CurrentAccount _currentAccount;
        public SavingsAccount _savingsAccount;
        public bool _hasGoodCredit = true;
        public Customer(Branch branch) 
        {
            _currentAccount = new CurrentAccount(branch);
            _savingsAccount = new SavingsAccount(branch);
        }
    
        //public void CreateCurrentAccount()
        //{
        //    _currentAccount = new CurrentAccount();
        //}
        //public void CreateSavingsAccount()
        //{
        //    _savingsAccount = new SavingsAccount();
        //}

        public void Deposit(string account, int funds)
        {
            if (account.ToLower() == "current")
            {
                _currentAccount.Deposit(funds);
            }
            _savingsAccount.Deposit(funds);
        }
        public void Withdraw(string account, int funds)
        {
            if (account.ToLower() == "current")
            {
                _currentAccount.Withdraw(funds);
            }
            _savingsAccount.Withdraw(funds);

        }

        public string GenerateStatement(string account)
        {
            if (account.ToLower() == "current")
            {
                return _currentAccount.GenerateStatement();
            }
            return _savingsAccount.GenerateStatement();
        }

        public int CalculateBalance(string account)
        {
            if (account.ToLower() == "current")
            {
                return _currentAccount.CalculateBalance();
            }
            return _savingsAccount.CalculateBalance();
        }

        public void RequestOverdraft()
        {
            _currentAccount.overdraftRequest = true;
        }
    }
}
