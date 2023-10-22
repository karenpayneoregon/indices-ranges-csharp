namespace ExamplesApp1.Models;
public class ElementContainer<T>
{
    public T Value { get; set; }
    public Index StartIndex { get; set; }
    public Index EndIndex { get; set; }
    public int Index { get; set; }
    public override string ToString() => $"{Index,-5:D2}{Value}";
}
