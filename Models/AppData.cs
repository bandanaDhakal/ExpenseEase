
namespace ExpenseEase.Models
{
    public class AppData
    {
        public List<User> Users { get; set; } = new();
        public List<Debt> Debts { get; set; } = new();
        public List<Transaction> Transactions { get; set; } = new();

        // Add UserBalance to keep track of the user's balance
        public decimal UserBalance { get; set; }

        // Calculate the overall balance (sum of all credits minus all debits)
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