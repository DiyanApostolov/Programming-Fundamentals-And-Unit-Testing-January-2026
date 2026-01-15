
int numberOfChickenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

double priceForChikenMenus = numberOfChickenMenus * 10.35;
double priceForFishMenus = numberOfFishMenus * 12.40;
double priceForVegetarianMenus = numberOfVegetarianMenus * 8.15;

double totalBill = priceForChikenMenus + priceForFishMenus + priceForVegetarianMenus;
double dessertPrice = totalBill * 0.2;
double deliveryPrice = 2.50;

double finalPrice = totalBill + dessertPrice + deliveryPrice;

Console.WriteLine(finalPrice);