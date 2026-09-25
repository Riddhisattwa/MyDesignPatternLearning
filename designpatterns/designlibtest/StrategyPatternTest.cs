using designpatternlib.strategy;

namespace designlibtest;

public class StrategyPatternTest
{
    [Fact]
    public void TestForStrategyUsageWithConstructorInjection()
    {
        IPaymentService creditcard = new CreditCardPaymentService();
        PaymentContextProcessor paymentContextProcessor = new PaymentContextProcessor(creditcard);
        Assert.True(paymentContextProcessor.doPayment(123.123));
    }
}
