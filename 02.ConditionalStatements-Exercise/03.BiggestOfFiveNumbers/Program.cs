
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());
int fourthNum = int.Parse(Console.ReadLine());
int fifthNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)
{
    Console.WriteLine(firstNum);
}
else if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)
{
    Console.WriteLine(secondNum);
}
else if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)
{
    Console.WriteLine(thirdNum);
}
else if (fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum)
{
    Console.WriteLine(fourthNum);
}
else
{
    Console.WriteLine(fifthNum);
}
