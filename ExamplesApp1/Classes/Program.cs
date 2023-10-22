using ExamplesApp1.Classes;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace ExamplesApp1;
internal partial class Program
{
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
