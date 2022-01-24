// See https://aka.ms/new-console-template for more information
public interface Target
{
    string GetRequest();
}
class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request using adaptee class";
    }
}
class Adapter : Target
{
    private readonly Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is '{this.adaptee.GetSpecificRequest()}'";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        Target target = new Adapter(adaptee);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.");

        Console.WriteLine(target.GetRequest());
    }
}
