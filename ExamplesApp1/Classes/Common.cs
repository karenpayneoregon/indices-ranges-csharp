using System.Globalization;

namespace ExamplesApp1.Classes;
public static class Common
{
    public static List<string> MonthNames() =>
        DateTimeFormatInfo.CurrentInfo!.MonthNames[..^1].ToList();
}
