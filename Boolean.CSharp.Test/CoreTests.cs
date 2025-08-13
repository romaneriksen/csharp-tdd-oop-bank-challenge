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
            customer.CreateCurrentAccount();
            customer.CreateSavingsAccount();
            Assert.That(customer._currentAccount != null);
            Assert.That(customer._savingsAccount != null);

        }

    }
}