using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        //public CoreTests()
        //{
        //    _core = new Core();

        //}

        [Test]
        public void TestCreateAccounts()
        {
            Customer customer = new Customer();
            //customer.CreateCurrentAccount();
            //customer.CreateSavingsAccount();
            Assert.That(customer._currentAccount != null);
            Assert.That(customer._savingsAccount != null);

        }

        [Test]
        public void TestDepositAndWithdraw()
        {
            Customer customer = new Customer();
            customer.Deposit("current", 100);
            Assert.That(customer._currentAccount.Balance, Is.EqualTo(100));
            customer.Deposit("current", 300);
            Assert.That(customer._currentAccount.Balance, Is.EqualTo(400));
            customer.Withdraw("current", 200);
            Assert.That(customer._currentAccount.Balance, Is.EqualTo(200));
        }

        [Test]
        public void TestAccountStatement() 
        {
            Customer customer = new Customer();
            customer.Deposit("current", 100);
            customer.Deposit("current", 300);
            customer.Withdraw("current", 200);
            Assert.That(customer.GenerateStatement("current") != null);
            Console.WriteLine(customer.GenerateStatement("current"));
            
        }

    }
}