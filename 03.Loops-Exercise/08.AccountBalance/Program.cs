
string input = Console.ReadLine();

double accountBalance = 0;

while (input != "End")
{
    double currentAmount = double.Parse(input);

    accountBalance += currentAmount; // променям баланса в сметката

    if (currentAmount > 0)
    {
        Console.WriteLine($"Increase: {currentAmount:F2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(currentAmount):F2}");
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {accountBalance:F2}");