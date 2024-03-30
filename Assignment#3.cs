using System;

public class Account
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    public string AccountType { get; private set; }

    // Constructor for default checking account
    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        AccountType = "Checking";
    }

    // Constructor for custom account type
    public Account(string accountNumber, string accountType)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        AccountType = accountType;
    }

    // Deposit method
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} into account {AccountNumber}. New balance: {Balance}");
    }

    // Withdraw method
    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from account {AccountNumber}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    // Overloaded Deposit method with description
    public void Deposit(decimal amount, string description)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} into account {AccountNumber}. New balance: {Balance}. Description: {description}");
    }

    // Overloaded Withdraw method with description
    public void Withdraw(decimal amount, string description)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from account {AccountNumber}. New balance: {Balance}. Description: {description}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        // Creating different accounts using different constructors
        Account checkingAccount = new Account("123456");
        Account savingsAccount = new Account("789012", "Savings");

        // Depositing and withdrawing money
        checkingAccount.Deposit(100);
        checkingAccount.Withdraw(50);

        savingsAccount.Deposit(500, "Monthly savings");
        savingsAccount.Withdraw(100, "Emergency fund");
    }
}
