
int firstAthlete = int.Parse(Console.ReadLine());
int secondAthlete = int.Parse(Console.ReadLine());
int thirdAthlete = int.Parse(Console.ReadLine());

int sumTimeInSeconds = firstAthlete + secondAthlete + thirdAthlete;

int minutes = sumTimeInSeconds / 60; // целочислено деление
int seconds = sumTimeInSeconds % 60; // модулно деление

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}


