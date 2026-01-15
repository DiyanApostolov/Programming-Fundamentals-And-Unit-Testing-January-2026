
//Input
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int hoursForWork = int.Parse(Console.ReadLine());

// Calculatios
double nylonPrice = 1.5;
double paintPrice = 14.5;
double thinnerPrice = 5;
double bagsPrice = 0.40;

double priceForNylon = (amountOfNylon + 2) * nylonPrice; 
double priceForPaint = amountOfPaint * 1.1 * paintPrice;
double priceForThinner = quantityOfThinner * thinnerPrice;

double priceForAllMaterials = priceForNylon + priceForPaint + priceForThinner + bagsPrice;
double priceForOneHourWork = priceForAllMaterials * 0.3;
double priceForCraftsmen = hoursForWork * priceForOneHourWork;

double finalPrice = priceForAllMaterials + priceForCraftsmen;

// Output
Console.WriteLine(finalPrice);