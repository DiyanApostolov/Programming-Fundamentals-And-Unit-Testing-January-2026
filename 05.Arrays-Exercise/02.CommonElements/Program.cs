
int[] firstArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int[] secondArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

string output = "";

for (int i = 0; i < firstArray.Length; i++)
{
    int firstArrayCurrentElement = firstArray[i];

    // РЕШЕНИЕ С МЕТОДА .Contains
    if (secondArray.Contains(firstArrayCurrentElement))
    {
        output += $"{firstArrayCurrentElement} ";
    }

    // РЕШЕНИЕ С ВЛОЖЕНИ ЦИКЛИ

    //for (int j = 0; j < secondArray.Length; j++)
    //{
    //    int secondArrayCurrentElement = secondArray[j];

    //    if (firstArrayCurrentElement == secondArrayCurrentElement)
    //    {
    //        output += $"{firstArrayCurrentElement} ";
    //        break; // прекъсвам преждевременно, защото вече имам съвпадевние на елементите
    //    }
    //}
}

Console.WriteLine(output);
