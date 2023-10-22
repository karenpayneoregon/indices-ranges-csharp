namespace ExamplesApp1.Models;
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // only for this demo
    public override string ToString() => $"{Id,-4}{FirstName,-10}{LastName,-15}";

}
