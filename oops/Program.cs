namespace oops
{
    class Program
    {
        static void Main()
        {
            BankAccount b1 = new BankAccount(1, "riddhi", 100);
            Console.WriteLine("Initial balance: " + b1.GetBalance());
            b1.AddToBankAccount(100);
            Console.WriteLine("Updated balance: " + b1.GetBalance());
        }
    }
}