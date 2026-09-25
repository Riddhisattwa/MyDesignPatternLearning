using System;

namespace designpatternlib.strategy;

public class CreditCardPaymentService : CardPaymentService, IPaymentService
{
    public override bool HasEmiApplicable()
    {
        return true;
    }

    public bool TryPay(double amount)
    {
        Console.WriteLine("Payment done using credit card and amount {0} is debited from your account",amount);
        return true;
    }
}
