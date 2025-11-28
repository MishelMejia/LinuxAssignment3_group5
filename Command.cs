public class Command
{
    public string name { get; set; }
    public string description { get; set; }
    public string category { get; set; }
    public string example { get; set; }

    public void Print()
    {
        System.Console.WriteLine($"Command: {name}");
        System.Console.WriteLine($"Description: {description}");
        System.Console.WriteLine($"Category: {category}");
        System.Console.WriteLine($"Example: {example}\n");
    }
}
