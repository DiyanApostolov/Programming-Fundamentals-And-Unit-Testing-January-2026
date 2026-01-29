
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int factorialFirstNumber = CalculateFactorial(firstNumber);
int factorialSecondNumber = CalculateFactorial(secondNumber);

int result = factorialFirstNumber / factorialSecondNumber;

Console.WriteLine(result);

int CalculateFactorial(int number)
{
    int factorial = 1;

    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }

    return factorial;
}