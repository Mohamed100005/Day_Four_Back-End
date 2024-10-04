namespace Main_Task {
    internal class TrustAccount : SavingsAccount {
        private DateTime withDrawalTime = DateTime.Now;
        private int withDrawCount = 0;
        double Bonus { set; get; }
        public TrustAccount(string name = " ", double balance = 0, double inRate = 0) : base(name, balance) {
            Bonus = 50.0;
        }
        public override bool Deposit(double amount) {
            if (amount >= 5000) {
                return base.Deposit(amount + Bonus);
            }
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount) {
            if (DateTime.Now.Year != withDrawalTime.Year && DateTime.Now.Month == withDrawalTime.Month && DateTime.Now.Day == withDrawalTime.Day) {
                withDrawCount = 0;
            }
            if (withDrawCount <= 3) {
                if (amount < Balance * 0.2) {
                    withDrawalTime = DateTime.Now;
                    withDrawCount++;
                    return base.Withdraw(amount);
                }
            }
            return false;
        }
    }
}
