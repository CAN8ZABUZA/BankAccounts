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
        public List<Transaction> Transactions { get; private set; }

        public Account(string IBAN, float Ammount, string Owner)
            : this()
        {
            this.IBAN = IBAN;
            this.Ammount = Ammount;
            this.Owner = Owner;
        }

        private Account()
        {
            Transactions = new List<Transaction>();
        }

        public Account AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            return this;
        }

        public Account AddTransactions(List<Transaction> transactions)
        {
            foreach(var transaction in transactions)
            {
                AddTransaction(transaction);
            }
            return this;
        }

        public Account DeleteTransaction(Transaction transaction)
        {
            if (Transactions.Contains(transaction))
            {
                Transactions.Remove(transaction);
            }
            return this;
        }

        public Account DeleteTransactions(List<Transaction> transactions)
        {
            foreach(var transaction in transactions)
            {
                DeleteTransaction(transaction);
            }
            return this;
        }

        public Account DeleteAllTransactions()
        {
            foreach(var transaction in Transactions)
            {
                DeleteTransaction(transaction);
            }
            return this;
        }

        public Account ChangeOwner(string owner)
        {
            Owner = owner;
            return this;
        }
    }
}
