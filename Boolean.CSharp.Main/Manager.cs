using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Manager
    {
        public Manager() { }

        public void ProcessOverdraftRequest(Customer customer)
        {
            if (customer._currentAccount.overdraftRequest)
            {
                customer._currentAccount.overdraftRequest = false;
                customer._currentAccount.overdraft = true;
                customer._currentAccount.overdraftBalance = 1000;
            }
        }
    }
}
