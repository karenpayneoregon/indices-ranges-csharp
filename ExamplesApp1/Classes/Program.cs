﻿using ExamplesApp1.Classes;
using ExamplesApp1.Models;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace ExamplesApp1;
internal partial class Program
{
    private static List<Person> PeopleList()
    {
        List<Person> people = new()
        {
            new() { Id = 1, FirstName = "Jim", LastName = "Gallagher" },
            new() { Id = 2, FirstName = "Clare", LastName = "Gallagher" },
            new() { Id = 3, FirstName = "Mary", LastName = "Gallagher" }
        };

        return people;
    }
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample: Indexing";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }

    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }

    private static void ExitPrompt()
    {
        Console.WriteLine();
        Render(new Rule($"[green1]Press a key to exit[/]")
            .RuleStyle(Style.Parse("white"))
            .Centered());

        Console.ReadLine();
    }
    private static void Print([CallerMemberName] string? methodName = null)
    {
        AnsiConsole.MarkupLine($"[green1]{methodName.SplitCamelCase()}[/]");
        Console.WriteLine();
    }
}
