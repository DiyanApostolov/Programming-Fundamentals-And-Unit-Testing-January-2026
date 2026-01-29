
int number = int.Parse(Console.ReadLine());

int result = GetMultipleOfEvenAndOdds(Math.Abs(number));

Console.WriteLine(result);

static int GetSumOfEvenDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int lastDigit = num % 10; // take last digit

        if (lastDigit % 2 == 0) // check is even
        {
            sum += lastDigit;
        }

        num /= 10; // remove last digit
    }

    return sum;
}

static int GetSumOfOddDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int lastDigit = num % 10; // take last digit

        if (lastDigit % 2 != 0) // check id odd
        {
            sum += lastDigit;
        }

        num /= 10; // remove last digit
    }

    return sum;
}

static int GetMultipleOfEvenAndOdds(int num)
{
    int sumOfEvenDigits = GetSumOfEvenDigits(num);
    int sumOfOddDigfits = GetSumOfOddDigits(num);

    return sumOfEvenDigits * sumOfOddDigfits;
}
