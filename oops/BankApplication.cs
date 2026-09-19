namespace oops
{
    public class BankApplication
    {
        private readonly BankAccount bankAccount;
        private INotification _notification;
        public BankApplication(BankAccount bankAccount, INotification notification)
        {
            this.bankAccount = bankAccount;
            Notification = notification;
        }
        public INotification Notification
        {
            get => _notification;
            set => _notification = value;
        }
        public void DepositMoney(int val)
        {
            bankAccount.AddToBankAccount(val);
            Notification.SendNotification();
        }
        public void WithdrawMoney(int val)
        {
            bankAccount.DeductBalance(val);
            Notification.SendNotification();
        }

        public void GetBalance()
        {
            Notification.UpdateMessage(bankAccount.GetBalance().ToString());
            Notification.SendNotification();
        }
    }
}