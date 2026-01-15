
int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string outfit = "";
string shoes = "";

if (timeOfDay == "Morning")
{
    switch (degrees)
    {
        case >= 10 and <= 18:
            outfit = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case > 18 and <= 24:
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case >= 25:
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
    }
}
else if (timeOfDay == "Afternoon")
{
    switch (degrees)
    {
        case >= 10 and <= 18:
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case > 18 and <= 24:
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case >= 25:
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
    }
}
else if (timeOfDay == "Evening")
{
    outfit = "Shirt";
    shoes = "Moccasins";
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
