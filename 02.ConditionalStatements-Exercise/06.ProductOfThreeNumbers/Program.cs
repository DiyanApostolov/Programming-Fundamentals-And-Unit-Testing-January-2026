
double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());

if (n1 == 0 || n2 == 0 || n3 == 0) // проверяваме дали някое от числата е 0
{
    Console.WriteLine("zero");
}
else
{
    int negativeNumbersCount = 0;

    if (n1 < 0) 
        negativeNumbersCount++;

    if (n2 < 0) 
        negativeNumbersCount++;

    if (n3 < 0) 
        negativeNumbersCount++;

    if (negativeNumbersCount % 2 == 0) // ако е четно число брояча, резултата след умниженеито е положителен
    {
        Console.WriteLine("positive");
    }
    else // ако е НЕчетно число брояча, резултата след умниженеито е отрицателен
    {
        Console.WriteLine("negative");
    }
}