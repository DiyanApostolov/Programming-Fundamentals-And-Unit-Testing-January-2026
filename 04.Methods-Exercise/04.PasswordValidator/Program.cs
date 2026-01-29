
string password = Console.ReadLine();

if (!CheckPassContains6To10Characters(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!CheckPassContainOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!CheckPassContainAtLeast2Digits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (CheckPasswordIsValid(password))
{
    Console.WriteLine("Password is valid");
}


// It should contain 6 – 10 characters (inclusive)
static bool CheckPassContains6To10Characters(string text)
{
    if (text.Length >= 6 && text.Length <= 10)
    {
        return true; 
    }

    return false;
}

// It should contain only letters and digits
static bool CheckPassContainOnlyLettersAndDigits(string text)
{
    for (int i = 0; i < text.Length; i++)
    {
        char currentSymbol = text[i];

        if (!char.IsLetterOrDigit(currentSymbol))
        {
            return false;
        }
    }

    return true;
}

// It should contain at least 2 digits 
static bool CheckPassContainAtLeast2Digits(string text)
{
    int counter = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char currentSymbol = text[i];

        if (char.IsDigit(currentSymbol))
        {
           counter++;
        }
    }

    if (counter >= 2)
    {
        return true;
    }

    return false;
}

static bool CheckPasswordIsValid(string text)
{
    if (CheckPassContains6To10Characters(text)
    && CheckPassContainOnlyLettersAndDigits(text)
    && CheckPassContainAtLeast2Digits(text))
    {
        return true;
    }

    return false;
}