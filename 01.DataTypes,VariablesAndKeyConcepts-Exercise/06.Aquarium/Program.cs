
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentOccupied = double.Parse(Console.ReadLine());

int aquariumVolume = length * width * height;
double volumeInLiters = (double)aquariumVolume / 1000; // кастваме към double, за да не загубим точност

double neededLiters = volumeInLiters * (1 - percentOccupied / 100);

Console.WriteLine($"{neededLiters:F2}");