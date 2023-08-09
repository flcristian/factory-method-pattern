using factory_method_pattern.document;

internal class Program
{
    private static void Main(string[] args)
    {
        Document resume = new Resume();
        Document report = new Report();

        Console.WriteLine(resume);
        Console.WriteLine(report);
    }
}