
List<int> field = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToList();

int[] bobmInfo = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToArray();

int bomb = bobmInfo[0];
int power = bobmInfo[1];

while (field.Contains(bomb))
{
    int bombIndex = field.IndexOf(bomb); // намиртам индекса на бомбата

    int startIndex = bombIndex - power;
    int endIndex = bombIndex + power;

    if (startIndex < 0) // провевявам дали индекса е отрицателен
    {
        startIndex = 0;
    }

    if (endIndex >= field.Count) // поверявам дали индекса е >= на елементите в листа
    {
        endIndex = field.Count - 1; 
    }

    for (int i = startIndex; i <= endIndex; i++)
    {
        field[i] = 0; // занулявам стойностите на тези индекси
    }
}

Console.WriteLine(field.Sum());