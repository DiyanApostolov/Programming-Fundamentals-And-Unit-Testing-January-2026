
int stopNumber = int.Parse(Console.ReadLine());

int nextNumber = int.Parse(Console.ReadLine());

int lastNumber = 0;

while (nextNumber != stopNumber)
{
    lastNumber = nextNumber; // пазя си текущото число

    nextNumber = int.Parse(Console.ReadLine());
}

double finalNumber = lastNumber * 1.2; // +20%

Console.WriteLine(finalNumber);