using System;
namespace MyAplication
{
    class ATM
    {
        static void Withdraw(int balance,int amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
            }
        }
        static void Main()
        {
            try
            {
                Withdraw(5000,7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }
        }
    }
}