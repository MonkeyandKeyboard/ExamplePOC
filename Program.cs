namespace ExamplePOC;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text to output (or press Enter for default): ");
        string? input = Console.ReadLine();
        string output = string.IsNullOrWhiteSpace(input) ? "HELLO WORLD" : input;
        Console.WriteLine(output);
    }
}
