using System;

namespace designpatternlib.strategy;

public class PaymentContextProcessor
{
    private IPaymentService paymentService;

   // public PaymentContextProcessor(){}
    public PaymentContextProcessor(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }
    public void SetPaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    public bool doPayment(double amount)
    {
        return paymentService.TryPay(amount);
    }

}
