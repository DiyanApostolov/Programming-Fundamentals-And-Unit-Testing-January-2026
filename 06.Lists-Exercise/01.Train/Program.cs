

List<int> train = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToList();

int capacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "end")
{
    string[] tokens = input.Split(" ");

    if (tokens[0] == "Add")
    {
        int passangers = int.Parse(tokens[1]);

        train.Add(passangers);
    }
    else
    {
        int passangersToAdd = int.Parse(tokens[0]);

        for (int i = 0; i < train.Count; i++) 
        { 
            if (train[i] + passangersToAdd <= capacity)
            {
                train[i] = train[i] + passangersToAdd;
                break;
            }
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", train));
