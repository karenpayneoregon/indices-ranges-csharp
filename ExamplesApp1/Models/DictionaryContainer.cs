namespace ExamplesApp1.Models;

internal class DictionaryContainer<K, V>
{
    public KeyValuePair<K, V> Value { get; set; }
    public Index StartIndex { get; set; }
    public Index EndIndex { get; set; }
    public int Index { get; set; }
}