
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

string sign = FindResultSign(firstNumber, secondNumber, thirdNumber);

Console.WriteLine(sign);

//negative, positive or zero
static string FindResultSign (int num1, int num2, int num3)
{
    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        return "zero";
    }
    else if (num1 > 0 && num2 > 0 && num3 > 0)
    {
        return "positive"; 
    }
    else if (num1 < 0 && num2 < 0 && num3 < 0)
    {
        return "negative";
    }
    else if (num1 < 0)
    {
        if (num2 < 0 && num3 > 0)
        {
            return "positive";
        }
        else if (num2 > 0 && num3 < 0)
        {
            return "positive";
        }
        else if (num2 > 0 && num3 > 0)
        {
            return "negative";
        }
    }
    else if (num2 < 0)
    {
        if (num1 < 0 && num3 > 0)
        {
            return "positive";
        }
        else if (num1 > 0 && num3 < 0)
        {
            return "positive";
        }
        else if (num1 > 0 && num3 > 0)
        {
            return "negative";
        }
    }
    else if (num3 < 0)
    {
        if (num1 < 0 && num2 > 0)
        {
            return "positive";
        }
        else if (num1 > 0 && num2 < 0)
        {
            return "positive";
        }
        else if (num1 > 0 && num2 > 0)
        {
            return "negative";
        }
    }

    return "";
}