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
        public Customer() { }
    
        public void CreateCurrentAccount()
        {
            _currentAccount = new CurrentAccount();
        }
        public void CreateSavingsAccount()
        {
            _savingsAccount = new SavingsAccount();
        }
    }
}
