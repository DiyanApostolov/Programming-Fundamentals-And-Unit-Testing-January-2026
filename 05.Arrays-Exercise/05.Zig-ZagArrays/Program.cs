
int n = int.Parse(Console.ReadLine());

int[] firstOutputArray = new int[n];
int[] secondsOutputArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] rowData = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

    if (i % 2 == 0) // четен индекс
    {
        firstOutputArray[i] = rowData[0];
        secondsOutputArray[i] = rowData[1];
    }
    else // нечетен индекс
    {
        firstOutputArray[i] = rowData[1];
        secondsOutputArray[i] = rowData[0];
    }
}

Console.WriteLine(string.Join(" ", firstOutputArray));
Console.WriteLine(string.Join(" ", secondsOutputArray));