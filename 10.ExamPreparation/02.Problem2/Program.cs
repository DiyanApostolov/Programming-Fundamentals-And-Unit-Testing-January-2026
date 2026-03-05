
int[] numbers = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

int rightMiddleIndex = numbers.Length / 2;
int leftMiddleIndex = rightMiddleIndex - 1;

int rightMiddleNumber = numbers[rightMiddleIndex];
int leftMiddleNumber = numbers[leftMiddleIndex];

double averageValue = (rightMiddleNumber + leftMiddleNumber) / 2.0;

Console.WriteLine($"{averageValue:F2}");
