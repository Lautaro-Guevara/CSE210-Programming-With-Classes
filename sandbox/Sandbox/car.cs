public class BankAccount
{
    private double _balance;
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    // Método para retirar dinero
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
        }
    }

    public void Display()
    {
        Console.WriteLine(_balance);
    }
}