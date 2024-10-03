
using VowelsConsonants;

VowlesConsonants vowlesConsonants = new VowlesConsonants();

while (true)
{
    Console.WriteLine("\nEnter a string:");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }

    vowlesConsonants.CountInstances(input);
}