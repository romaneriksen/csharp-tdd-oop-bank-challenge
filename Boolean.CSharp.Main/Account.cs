using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class Account
    {
        private List<(DateOnly Date, string Type, int Fund, int Balance)> _history = new();
        public Guid Id { get; set; }
        public Guid AccountNumber { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }

        public int Balance = 0;

        public void Deposit(int fund)
        {
            Balance += fund;
            _history.Add((DateOnly.FromDateTime(DateTime.Today),"Deposit", fund, Balance));
        }

        public void Withdraw(int fund)
        {
            Balance -= fund;
            _history.Add((DateOnly.FromDateTime(DateTime.Today),"Withdraw", fund, Balance));
        }

        public string GenerateStatement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-15}{1,-15}{2,-15}{3,-15}", "Date", "Type", "Amount", "Balance");
            sb.AppendLine();
            foreach (var item in _history)
            {
                //sb.AppendLine($"{item.Date}    || {item.Type}    || {item.Fund}    || {item.Balance}");
                sb.AppendFormat("{0,-15}{1,-15}{2,-15}{3,-15}", item.Date, item.Type, item.Fund, item.Balance);
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
