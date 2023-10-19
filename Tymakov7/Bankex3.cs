using System;

namespace Tymakov7
{
    class Bankex3
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
        public void DepositMoney(double amount)
        {
            account_balance += amount;
            Console.WriteLine($"Счет пополнен на - {amount} , текущий баланс -{account_balance} ");
        }
        public void WithdrawMoney(double amount)
        {
            if (amount <= account_balance)
            {
                account_balance -= amount;
                Console.WriteLine($"Со счета было снято - {amount} , текущий баланс - {account_balance}");
            }
            else
            {
                Console.WriteLine("На балансе недостаточно средств");
            }
        }
        public Bankex3(Type account_type)
        {
            account_number = generationnumber;
            account_balance = 0;
            this.account_type = account_type;
        }

    }
}

