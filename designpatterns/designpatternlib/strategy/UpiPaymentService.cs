using System;

namespace designpatternlib.strategy;

public class UpiPaymentService : IPaymentService
{
    public bool TryPay(double amount)
    {
        Console.WriteLine("Payment done using upi and amount {0} is debited from your account",amount);
        return true;
    }
}
