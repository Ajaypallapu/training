// See https://aka.ms/new-console-template for more information
public interface Strategy
{

    public float calculation(float a, float b);

}
public class Addition : Strategy
{

    public float calculation(float a, float b)
{
     return a + b;
}  
  
}
public class Subtraction  : Strategy
{

    public float calculation(float a, float b)
{
    return a - b;
}  
  
}
public class Multiplication : Strategy
{

  
    public float calculation(float a, float b)
{
    return a * b;
}  
}
public class Context
{

    private Strategy strategy;

    public Context(Strategy strategy)
    {
        this.strategy = strategy;
    }

    public float executeStrategy(float num1, float num2)
    {
        return strategy.calculation(num1, num2);
    }
}
public class StrategyPatternDemo
{

    public static void Main(String[] args)
    {
        float value1 = 2;
        float value2 = 3;
        Context context = new Context(new Addition());
        context = new Context(new Subtraction());
        context = new Context(new Multiplication());
        Console.WriteLine("Addition = " + context.executeStrategy(value1, value2));
        Console.WriteLine("Subtraction = " + context.executeStrategy(value1, value2));
        Console.WriteLine("Multiplication = " + context.executeStrategy(value1, value2));
    }
}