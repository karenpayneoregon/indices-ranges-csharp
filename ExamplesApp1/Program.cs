using ExamplesApp1.Models;

using static ExamplesApp1.Classes.Common;
using static ExamplesApp1.Classes.GenericHelpers;

namespace ExamplesApp1;

internal partial class Program
{
    static void Main(string[] args)
    {
        DictionaryIndexing();
        Console.WriteLine();
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

        List<ElementContainer<Person>> personContainer = RangeDetails(PeopleList());

        Console.WriteLine($"Id  Person                    Index  Start  End");
        foreach (var item in personContainer)
        {
            Console.WriteLine($"{item.Value,-10} {item.Index,-4} {item.StartIndex,3} {item.EndIndex,7}");
        }
    }

    private static void DictionaryIndexing()
    {
        Print();

        var dictionary =
            PeopleList()
                .ToDictionary(
                    keySelector: p => p.Id, 
                    elementSelector: p => p);

        var personContainer = RangeDetails(dictionary);
        foreach (var item in personContainer)
        {
            Console.WriteLine($"{item.Value.Value,-10} {item.Index,-4} {item.StartIndex,3} {item.EndIndex,7}");
        }

    }
}