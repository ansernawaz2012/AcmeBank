using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeBank
{
    public class AccountType
    {
        public string AccountName { get; set; }

        public double OverdraftLimit { get; set; }

        public string CCType { get; set; }
    }
}
