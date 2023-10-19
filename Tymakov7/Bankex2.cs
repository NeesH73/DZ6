namespace Tymakov7
{
    class Bankex2
    {

        private static int generationnumber = 1;
        private int account_number;
        private double account_balance;
        private Type account_type;

        public int AccountNumber
        {
            get { return account_number; }
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
        private void GenerationNumber()
        {
            generationnumber++;
        }
        public Bankex2(double account_balance, Type account_type)
        {
            account_number = generationnumber;
            this.account_balance = account_balance;
            this.account_type = account_type;
            GenerationNumber();
        }
    }
}
