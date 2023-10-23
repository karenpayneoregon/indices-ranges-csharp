using ExamplesApp1.Models;

namespace ExamplesApp1.Classes;
class GenericHelpers
{
    public static List<ElementContainer<T>> RangeDetails<T>(List<T> list) =>
        list.Select((element, index) => new ElementContainer<T>
        {
            Value = element,
            StartIndex = new(index),
            EndIndex = new(list.Count - index - 1, true),
            Index = index + 1
        }).ToList();

    public static List<DictionaryContainer<K,V>> RangeDetails<K,V>(Dictionary<K,V> list) =>
        list.Select((element, index) => new DictionaryContainer<K,V>
        {
            Value = element,
            StartIndex = new(index),
            EndIndex = new(list.Count - index - 1, true),
            Index = index + 1
        }).ToList();
}