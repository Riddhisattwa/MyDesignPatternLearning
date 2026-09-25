using System;

namespace designpatternlib.strategy;

public class DebitCardPaymentService : CardPaymentService, IPaymentService
{
    public override bool HasEmiApplicable()
    {
        return false;
    }

    public bool TryPay(double amount)
    {
        Console.WriteLine("Payment done using debit card and amount {0} is debited from your account",amount);
        return true;
    }
}
