using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ExamplesApp1.Classes;
internal static class StringExtensions
{
    [DebuggerStepThrough]
    public static string SplitCamelCase(this string sender) =>
        string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
            .Select(m => m.Value));
}
