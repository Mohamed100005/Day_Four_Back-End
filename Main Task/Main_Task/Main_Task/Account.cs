namespace Main_Task {
    internal class Account {
        public string Name { get; set; }
        public double Balance { get; set; }
        public Account(string name = " ", double balance = 0) {
            Name = name;
            Balance = balance;
        }
        public virtual bool Deposit(double amount) {
            if (amount > 0) {
                Balance += amount;
                return true;
            }
            return false;
        }
        public virtual bool Withdraw(double amount) {
            if (amount > 0 && Balance - amount > 0) {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public double GetBalance() {
            return Balance;
        }
        public static Account operator +(Account left, Account right) {
            Account account = new();
            account.Balance = left.Balance + right.Balance;
            return account;
        }
    }
}
