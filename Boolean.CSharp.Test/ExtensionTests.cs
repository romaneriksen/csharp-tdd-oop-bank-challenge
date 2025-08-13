using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        //private Extension _extension;
        //public ExtensionTests()
        //{
        //    _extension = new Extension();
        //}
        [Test]
        public void TestBalanceFromHistory()
        {
            Customer customer = new Customer(Branch.Oslo);
            customer.Deposit("current", 100);
            customer.Deposit("current", 300);
            customer.Withdraw("current", 200);
            Assert.That(customer.CalculateBalance("current"), Is.EqualTo(200));
        }

        [Test]
        public void TestAssociatedBranch() 
        {
            Customer customer = new Customer(Branch.Oslo);
            Assert.That(customer._currentAccount.Branch, Is.EqualTo(Branch.Oslo));
        }

        [Test]
        public void TestOverDraft() 
        {
            Customer customer = new Customer(Branch.Oslo);
            Manager manager = new Manager();
            customer.RequestOverdraft();
            Assert.That(customer._currentAccount.overdraftRequest, Is.EqualTo(true));
            manager.ProcessOverdraftRequest(customer);
            Assert.That(customer._currentAccount.overdraft, Is.EqualTo(true));
            Assert.That(customer._currentAccount.overdraftRequest, Is.EqualTo(false));
            Assert.That(customer._currentAccount.overdraftBalance > 0);

        }
    }
}
