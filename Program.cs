
string[] FindElements(string[] inputArray, int countSymbol)
{
    int countOutput = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= countSymbol)
            countOutput++;
    }
    string[] outputArray = new string[countOutput];
    int indexOutput = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= countSymbol)
        {
            outputArray[indexOutput] = inputArray[i];
            indexOutput++;
        }
    }
    return outputArray;
}

void PrintArray(string[] arrayForPrint) 
{
    Console.Write("[ ");
    for (int i = 0; i < arrayForPrint.Length - 1; i++)
    {
        Console.Write($"\"{arrayForPrint[i]}\", ");
    }
    Console.Write($"\"{arrayForPrint[arrayForPrint.Length-1]}\" ]");
    Console.WriteLine();
}


int countSymbol = 3;
string[] inputArray = {"Hello", "1234", "123", "Here", "you", "are", "I'm", "glad", "to", "you"};

string[] outputArray = FindElements(inputArray, countSymbol);

PrintArray(outputArray);

