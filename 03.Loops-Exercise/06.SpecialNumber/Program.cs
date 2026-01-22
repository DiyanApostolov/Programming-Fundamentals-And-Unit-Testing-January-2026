
int number = int.Parse(Console.ReadLine());

int temp = number;
bool isSpecialNumber = true;

while (temp > 0)
{
    int lastNumber = temp % 10; // взимам последната цифра

    if (number % lastNumber != 0) // проверявам дали се дели без остатък
    {
        isSpecialNumber = false;
        break;
    }

    temp /= 10; // премахвам последната цифра
}

if (isSpecialNumber)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}