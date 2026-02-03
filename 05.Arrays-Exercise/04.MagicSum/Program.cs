
int[] numbers = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length - 1; i++) // Пропускам последния индекс (елемент)
{
    int currentElement = numbers[i];

    //14 20 60 13 7 19 8
    for (int j = i + 1; j < numbers.Length; j++) // Обикаляме всички елементи надясно от текущия
    {
        int nextRigthElement = numbers[j];

        if (currentElement + nextRigthElement == controlNumber)
        {
            Console.WriteLine($"{currentElement} {nextRigthElement}");
            break;
        }
    } 
}