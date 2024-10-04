namespace Main_Task {
    internal class CheckingAccount : SavingsAccount {
        public CheckingAccount(string name = " " , double balance = 0 ) : base(name , balance) {
            IntRate = 1.50;
        }
        public override bool Withdraw(double amount) {
            return base.Withdraw(amount + IntRate);
        }
    }
}
