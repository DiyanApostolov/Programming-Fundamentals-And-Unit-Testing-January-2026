
// Input 
string input = Console.ReadLine();

// invoke method
int count = FindVowelsCount(input);

// Output
Console.WriteLine(count);

int FindVowelsCount(string text){

    int vowelsCount = 0;

    for (int i = 0; i < text.Length; i++) 
    {
        char symbol = text[i];

        switch (symbol)
        {
            case 'a' or 'o' or 'u' or 'e' or 'i': 
                vowelsCount++; 
                break;
            case 'A' or 'O' or 'U' or 'E' or 'I':
                vowelsCount++;
                break;
        }
    }

    return vowelsCount;
}