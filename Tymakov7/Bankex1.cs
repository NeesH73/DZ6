namespace Tymakov7
{
    enum Type
    {
        savings,
        current
    }
    class Bankex1
    {
        private int account_number;
        private double account_balance;
        private Type account_type;

        public int AccountNumber
        {
            get { return account_number; }
            set { account_number = value; }
        }
        public double AccountBalance
        {
            get { return account_balance; }
            set { account_balance = value; }
        }
        public Type AccountType
        {
            get { return account_type; }
            set { account_type = value; }
        }
        public Bankex1(int account_number, double account_balance, Type account_type)
        {
            this.account_number = account_number;
            this.account_balance = account_balance;
            this.account_type = account_type;
        }
    }
}
