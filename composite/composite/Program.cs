// See https://aka.ms/new-console-template for more information
interface Epamer {
    void Designation();
}class CEO : Epamer {
    public void Designation() {
        Console.WriteLine("I am Dobkin CEO of Epam");
    }
}class Manager1 : CEO, Epamer {
    public void Designation() {
        Console.WriteLine("I am syam , my boss is Dobkin");
    }
}
class Manager2 : CEO, Epamer
{
    public void Designation()
    {
        Console.WriteLine("I am ram , my boss is Dobkin");
    }
}class Hr : Manager1, Epamer {
    public void Designation() {
        Console.WriteLine("I am tiwary , my boss is syam");
    }
}
public class program {
    static void Main(String[] args) {
        CEO aj = new CEO();
        Manager1 ay = new Manager1();
        Hr ak = new Hr();
        List<Epamer> a = new List<Epamer>();
        a.Add(aj);
        a.Add(ay);
        a.Add(ak);
        foreach (Epamer i in a) {
            i.Designation();
        }

    }
}