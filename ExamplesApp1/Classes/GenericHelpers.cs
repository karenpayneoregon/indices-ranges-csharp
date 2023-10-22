using ExamplesApp1.Models;

namespace ExamplesApp1.Classes;
class GenericHelpers
{
    public static List<ElementContainer<T>> RangeDetails<T>(List<T> list) =>
        list.Select((element, index) => new ElementContainer<T>
        {
            Value = element,
            StartIndex = new Index(index),
            EndIndex = new Index(Enumerable.Range(0, list.Count).Reverse().ToList()[index], true),
            Index = index + 1
        }).ToList();
}

