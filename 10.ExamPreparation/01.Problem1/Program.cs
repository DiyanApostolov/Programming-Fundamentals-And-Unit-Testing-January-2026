
//int number = int.Parse(Console.ReadLine());

//int sumFactorial = 0;

////4532
//while (number > 0)
//{
//    int lastDigit = number % 10;

//    if (lastDigit % 2 == 0)
//    {
//        int factorial = 1;

//        for (int i = 1; i <= lastDigit; i++)
//        {
//            factorial = factorial * i;
//        }

//        sumFactorial += factorial;
//    }

//    number /= 10;
//}

//Console.WriteLine(sumFactorial);

string number = Console.ReadLine();
int sumFactorial = 0;
//4532
for (int i = 0; i < number.Length; i++)
{
    int currentDigit = int.Parse(number[i].ToString());

    if (currentDigit % 2 == 0)
    {
        int factorial = 1;

        for (int j = 1; j <= currentDigit; j++)
        {
            factorial = factorial * j;
        }

        sumFactorial += factorial;
    }
}

Console.WriteLine(sumFactorial);