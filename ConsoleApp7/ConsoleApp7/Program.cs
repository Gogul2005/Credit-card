using System;

class Transaction
{
    static void Main(string[] args)
    {
        string transactionID = "TXN1234ABCD9";
        decimal amount = 1000000.75m;
        bool isInternational = true;
        decimal customerRating = 4.75m;
        DateTime transactionTimestamp = DateTime.Now;
        int rewardPoints = 2500000;

        Console.WriteLine($"ID: {transactionID}");
        Console.WriteLine($"Amount: ₹{amount}");
        Console.WriteLine($"International: {isInternational}");
        Console.WriteLine($"Rating: {customerRating}");
        Console.WriteLine($"Timestamp: {transactionTimestamp}");
        Console.WriteLine($"Reward Points: {rewardPoints}");
    }
}
