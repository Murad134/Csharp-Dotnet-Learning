using System;

abstract class Payment
{
    public abstract void Pay(decimal amount);

    public void GenerateReceipt()
    {
        Console.WriteLine("Receipt Generated");
    }
}

class CreditCardPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by Credit Card");
    }
}

class BkashPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by bKash");
    }
}

class Program
{
    static void Main()
    {
        Payment payment = new BkashPayment();

        payment.Pay(1500);
        payment.GenerateReceipt();
    }
}