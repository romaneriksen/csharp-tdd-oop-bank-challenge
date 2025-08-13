using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class CurrentAccount : Account
    {
        public bool overdraft { get; set; } = false;
        public bool overdraftRequest { get; set; } = false;
        public int overdraftBalance { get; set; }

        public CurrentAccount(Branch branch) : base(branch) { }
        
    }
}
