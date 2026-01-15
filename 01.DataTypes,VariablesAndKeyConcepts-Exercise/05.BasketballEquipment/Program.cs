// Input
int feeForOneYear = int.Parse(Console.ReadLine());

// Calculations
double sneakersPrice = feeForOneYear * 0.6; // -40%
double uniformPrice = sneakersPrice * 0.8; // -20%
double ballPrice = uniformPrice / 4; // друг вариант -> * 0.25
double accessoriesPrice = ballPrice / 5; // // друг вариант -> * 0.2

double finalPrice = feeForOneYear + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

// Output
Console.WriteLine(finalPrice);