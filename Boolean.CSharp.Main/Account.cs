using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class Account
    {
        private List<(string Type, int Fund)> _history = new();
        public Guid Id { get; set; }
        public Guid AccountNumber { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }

        public int Balance = 0;
    }


}
