using System;

namespace designpatternlib.strategy;

public abstract class CardPaymentService
{
    public abstract bool HasEmiApplicable();
}
