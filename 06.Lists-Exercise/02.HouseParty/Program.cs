
int n = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ");

    string name = tokens[0];

    if (tokens[2] == "going!")  //"{name} is going!"
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestList.Add(name);
        }
    }
    else if (tokens[2] == "not") // "{name} is not going!"
    {
        if (guestList.Contains(name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

// Output
foreach (var name in guestList)
{
    Console.WriteLine(name);
}
