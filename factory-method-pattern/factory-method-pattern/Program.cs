using factory_method_pattern.document;

internal class Program
{
    private static void Main(string[] args)
    {
        IDocumentFactory documentFactory = new DocumentFactory();
        Document resume = documentFactory.CreateDocument("Resume/Resume/Resume/Resume");
        Document report = documentFactory.CreateDocument("Report/Report/Report/Report");

        Console.WriteLine(resume);
        Console.WriteLine(report);
    }
}