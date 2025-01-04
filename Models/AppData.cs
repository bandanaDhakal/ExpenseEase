using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseEase.Models

{

    public class AppData

    {

        public List<User> Users { get; set; } = new();

        public List<Debt> Debts { get; set; } = new();

        public List<Transaction> Transactions { get; set; } = new();
        public decimal Balance
        {
            get
            {
                // Assuming Balance is the sum of all credits minus all debits
                return Transactions.Sum(t => t.Credit) - Transactions.Sum(t => t.Debit);
            }
        }

    }

}