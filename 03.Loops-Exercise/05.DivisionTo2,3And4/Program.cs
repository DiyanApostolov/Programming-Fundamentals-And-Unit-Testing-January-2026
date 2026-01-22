
int n = int.Parse(Console.ReadLine());

int counterDivideBy2 = 0;
int counterDivideBy3 = 0;
int counterDivideBy4 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
        counterDivideBy2++; 

    if (currentNumber % 3 == 0)
        counterDivideBy3++;

    if (currentNumber % 4 == 0)
        counterDivideBy4++;
}

double percentDivideBy2 = (double)counterDivideBy2 / n * 100;
double percentDivideBy3 = (double)counterDivideBy3 / n * 100;
double percentDivideBy4 = (double)counterDivideBy4 / n * 100;

Console.WriteLine($"{percentDivideBy2:F2}%");
Console.WriteLine($"{percentDivideBy3:F2}%");
Console.WriteLine($"{percentDivideBy4:F2}%");