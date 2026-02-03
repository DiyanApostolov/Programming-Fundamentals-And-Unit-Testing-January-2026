
int[] numbers = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstElement = numbers[0]; // пазим си първия елемент

    for (int j = 1; j < numbers.Length; j++) // обикаляме всички елементи от индекс 1 до края
    {
        numbers[j - 1] = numbers[j]; // копираме (местим) стойноста с един индекс напред
    }

    numbers[numbers.Length - 1] = firstElement; // вкарваме си пъврия елент в края на масива
}

foreach (int i in numbers)
{
    Console.Write(i + " ");
}