namespace Library;

public class Person
{
    private int Edad { get; set; }
    private string Name { get; set; }

    public Person(int edad, string name)
    {
        this.Edad = edad;
        this.Name = name;
    }

    public int GetAge()
    {
        return this.Edad;
    }

    public string GetName()
    {
        return this.Name;
    }
}