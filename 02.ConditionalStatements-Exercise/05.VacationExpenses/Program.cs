
string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfNigths = int.Parse(Console.ReadLine());

//"Spring", "Summer", "Autumn" and "Winter"
//"Hotel" and "Camping"

double priceForOneNigth = 0;
double discountPercent = 0;

if (season == "Spring")
{
    discountPercent = 20;

    if (accommodationType == "Hotel")
    {
        priceForOneNigth = 30;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneNigth = 10;
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        priceForOneNigth = 50;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneNigth = 30;
    }
}
else if (season == "Autumn")
{
    discountPercent = 30;

    if (accommodationType == "Hotel")
    {
        priceForOneNigth = 20;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneNigth = 15;
    }
}
else if (season == "Winter")
{
    discountPercent = 10;

    if (accommodationType == "Hotel")
    {
        priceForOneNigth = 40;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneNigth = 10;
    }
}

double priceForAllNigths = countOfNigths * priceForOneNigth;
double discount = priceForAllNigths * discountPercent / 100;

double finalPrice = priceForAllNigths - discount;

Console.WriteLine($"{finalPrice:F2}");