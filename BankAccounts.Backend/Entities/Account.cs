using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Backend.Entities
{
    public class Account
    {
        public string IBAN { get; private set; }
        public float Ammount { get; private set; }
        public string Owner { get; private set; }
    }
}
