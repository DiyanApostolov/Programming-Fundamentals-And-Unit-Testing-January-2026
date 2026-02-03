
int[] numbers = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = numbers[i];

    bool isTopInteger = true;

    for (int j = i+1; j < numbers.Length; j++)
    {
        int nextRigthNumber = numbers[j];

        if (nextRigthNumber >= currentNumber)
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        Console.Write(currentNumber + " ");
    }
}
