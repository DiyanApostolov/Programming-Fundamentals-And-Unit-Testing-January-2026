
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

PrintTotalPriceOfProduct(product, quantity);

static void PrintTotalPriceOfProduct(string productName, int quantity)
{
    double productPrice = 0;

    switch (productName)
    {
        case "coffee": productPrice = 1.50; break;
        case "water": productPrice = 1; break;
        case "coke": productPrice = 1.40; break;
        case "snacks": productPrice = 2; break;
    }

    double totalPrice = productPrice * quantity;

    Console.WriteLine($"{totalPrice:F2}");
}
