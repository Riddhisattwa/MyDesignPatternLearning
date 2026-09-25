using Xunit;
using oops;

public class BankAccountTests
{
    [Fact]
    public void Constructor_ShouldInitializeProperties_AndClampNegativeBalance()
    {
        var account = new BankAccount(7, "Alice", -25);

        Assert.Equal(7, account.GetID());
        Assert.Equal("Alice", account.GetName());
        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void AddToBankAccount_ShouldIncreaseBalance_ForPositiveDeposit()
    {
        var account = new BankAccount(1, "Bob", 100);

        account.AddToBankAccount(50);

        Assert.Equal(150, account.GetBalance());
    }

    [Fact]
    public void DeductBalance_ShouldReduceBalance_WhenFundsAreAvailable()
    {
        var account = new BankAccount(2, "Charlie", 100);

        account.DeductBalance(40);

        Assert.Equal(60, account.GetBalance());
    }

    [Fact]
    public void DeductBalance_ShouldNotAllowOverdraft()
    {
        var account = new BankAccount(3, "Dana", 30);

        account.DeductBalance(50);

        Assert.Equal(30, account.GetBalance());
    }
}
