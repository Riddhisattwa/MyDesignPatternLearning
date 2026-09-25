using System;

namespace designpatternlib.strategy;

public interface IPaymentService
{
    bool TryPay(double amount);
}
