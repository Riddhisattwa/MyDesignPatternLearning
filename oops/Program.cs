namespace oops
{
    class Program
    {
        static void Main()
        {
            BankAccount b1 = new BankAccount(1, "riddhi", 100);
            Console.WriteLine("Initial balance: " + b1.GetBalance());
            //Using Notification
            Notification notification = new MailNotification(b1.GetBalance().ToString());
            notification.SendNotification();
            notification = new SmsNotification("123456781","1234567892",b1.GetBalance().ToString());
            notification.SendNotification();
            b1.AddToBankAccount(100);
            Console.WriteLine("Updated balance: " + b1.GetBalance());
            notification = new MailNotification(b1.GetBalance().ToString());
            notification.SendNotification();
            notification = new SmsNotification("1234567891","1234567892",b1.GetBalance().ToString());
            notification.SendNotification();


        }
    }
}