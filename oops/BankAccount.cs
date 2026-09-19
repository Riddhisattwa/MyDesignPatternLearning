namespace oops
{
    public class BankAccount
    {
        private int id;
        private string name = string.Empty;
        private int balance;

        public BankAccount() { }

        public BankAccount(int id, string name, int balance)
        {
            this.id = id;
            this.name = name ?? string.Empty;
            this.balance = balance < 0 ? 0 : balance;
        }

        public void AddToBankAccount(int bal)
        {
            if (bal <= 0)
            {
                Console.WriteLine("Cannot deposit");
                return;
            }

            balance += bal;
        }

        public void DeductBalance(int bal)
        {
            if (bal <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount");
                return;
            }

            if (bal > balance)
            {
                Console.WriteLine("Low balance");
                return;
            }

            balance -= bal;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public string GetName()
        {
            return name;
        }

        public int GetID()
        {
            return id;
        }
    }
}
