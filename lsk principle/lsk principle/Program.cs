// See https://aka.ms/new-console-template for more information
/*class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Orange();
        Console.WriteLine(apple.GetColor());
    }
}
public class Apple
{
    public virtual string GetColor()
    {
        return "Red";
    }
}
public class Orange : Apple
{
    public override string GetColor()
    {
        return "Orange";
    }
}*/

class Program
{
    static void Main(string[] args)
    {
        Fruit fruit = new Orange();
        Console.WriteLine(fruit.GetColor());
        fruit = new Apple();
        Console.WriteLine(fruit.GetColor());
    }
}
public abstract class Fruit
{
    public abstract string GetColor();
}
public class Apple : Fruit
{
    public override string GetColor()
    {
        return "Red";
    }
}
public class Orange : Fruit
{
    public override string GetColor()
    {
        return "Orange";
    }
}