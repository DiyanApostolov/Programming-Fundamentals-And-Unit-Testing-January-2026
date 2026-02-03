
int[] inputArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

while(inputArray.Length > 1)
{
    int[] condesedArray = new int[inputArray.Length - 1];

    //5 0 4 1 2 
    for (int i = 0; i < inputArray.Length - 1; i++) // искам да стигнна до предпоследния индекс
    {
        int currentSum = inputArray[i] + inputArray[i + 1];
        condesedArray[i] = currentSum;
    }

    inputArray = condesedArray;
}

Console.WriteLine(inputArray[0]);