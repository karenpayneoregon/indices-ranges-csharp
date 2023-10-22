using ExamplesApp1.Models;

using static ExamplesApp1.Classes.Common;
using static ExamplesApp1.Classes.GenericHelpers;

namespace ExamplesApp1;

internal partial class Program
{
    static void Main(string[] args)
    {
        MonthsIndexing();
        Console.WriteLine();
        PersonIndexing();
        ExitPrompt();

    }
    private static void MonthsIndexing()
    {
        Print();

        List<ElementContainer<string>> monthContainer = RangeDetails(MonthNames());

        foreach (var item in monthContainer)
        {
            Console.WriteLine($"{item.Value,-10}{item.Index,-4}{item.EndIndex}");
        }

    }
    private static void PersonIndexing()
    {
        Print();

        List<Person> people = new()
        {
            new() { Id = 1, FirstName = "Jim", LastName = "Gallagher"},
            new () { Id = 2, FirstName = "Clare", LastName = "Gallagher"},
            new () { Id = 3, FirstName = "Mary", LastName = "Gallagher"}
        };

        List<ElementContainer<Person>> personContainer = RangeDetails(people);

        Console.WriteLine($"Id  Person                    Index  Start  End");
        foreach (var item in personContainer)
        {
            Console.WriteLine($"{item.Value,-10} {item.Index,-4} {item.StartIndex,3} {item.EndIndex,7}");
        }
    }
}