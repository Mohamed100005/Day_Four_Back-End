namespace Main_Task {
    internal class SavingsAccount : Account {
        public double IntRate { set; get; }
        public SavingsAccount(string name = " ", double balance = 0, double intRate = 0) : base(name, balance) {
            IntRate = intRate;
        }
        public override bool Withdraw(double amount) {
            return base.Withdraw(amount + IntRate);
        }
    }
}
