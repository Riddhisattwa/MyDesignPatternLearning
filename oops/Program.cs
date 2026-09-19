namespace oops
{
    class Program
    {
        static void Main()
        {
            BankAccount b1 = new BankAccount(1, "riddhi", 100);
            Console.WriteLine("Initial balance: " + b1.GetBalance());
            //Using Notification
            INotification notification = new MailNotification(b1.GetBalance().ToString());
            notification.SendNotification();
            notification = new SmsNotification("123456781","1234567892",b1.GetBalance().ToString());
            notification.SendNotification();
            b1.AddToBankAccount(100);
            Console.WriteLine("Updated balance: " + b1.GetBalance());
            notification = new MailNotification(b1.GetBalance().ToString());
            notification.SendNotification();
            notification = new SmsNotification("1234567891","1234567892",b1.GetBalance().ToString());
            notification.SendNotification();

            //using Loose coupling now
            Console.WriteLine("Using Loose Coupling---------");
            BankApplication bankApplication = new BankApplication(b1, new SmsNotification("1234567891","1234567892"));
            bankApplication.GetBalance();
            bankApplication.DepositMoney(2500);
            bankApplication.GetBalance();
            bankApplication.WithdrawMoney(100);
            bankApplication.Notification = new MailNotification();
            bankApplication.GetBalance();


        }
    }
}