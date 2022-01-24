// See https://aka.ms/new-console-template for more information
public interface Food
{
    public String prepareFood();
    public double foodPrice();
}
public class VegFood : Food
{
    public virtual String prepareFood()
{
    return "Veg Food";
} 

public double foodPrice()
{
    return 50.0;
}  
}  

public abstract class FoodDecorator : Food
{
    private Food newFood;
public FoodDecorator(Food newFood)
{
    this.newFood = newFood;
}
    public String prepareFood()
{
    return newFood.prepareFood();
}
public double foodPrice()
{
    return newFood.foodPrice();
}  
}  
public class NonVegFood : FoodDecorator
{
    public NonVegFood(Food newFood)
{
    super(newFood);
}
public String prepareFood()
{
    return super.prepareFood() + " With Roasted Chiken and Chiken Curry  ";
}
public double foodPrice()
{
    return super.foodPrice() + 150.0;
}  
}
public class ChineeseFood : FoodDecorator
{
  public ChineeseFood(Food newFood)
{
    super(newFood);
}
public String prepareFood()
{
    return super.prepareFood() + " With Fried Rice and Manchurian  ";
}
public double foodPrice()
{
    return super.foodPrice() + 65.0;
}  
}  
public class DecoratorPatternCustomer
{
    private static int choice;
    public static void Main(String []args)   {
        do
        {
            Console.WriteLine("========= Food Menu ============ ");
            Console.WriteLine("            1. Vegetarian Food.   ");
            Console.WriteLine("            2. Non-Vegetarian Food.");
            Console.WriteLine("            3. Chineese Food.         ");
            Console.WriteLine("            4. Exit                        ");
            Console.WriteLine("Enter your choice: ");
             choice = 2;
            switch (choice)
            {
                case 1:
                    {
                        VegFood vf = new VegFood();
                        Console.WriteLine(vf.prepareFood());
                        Console.WriteLine(vf.foodPrice());
                    }
                    break;

                case 2:
                    {
                        Food f1 = new NonVegFood((Food)new VegFood());
                        Console.WriteLine(f1.prepareFood());
                        Console.WriteLine(f1.foodPrice());
                    }
                    break;
                case 3:
                    {
                        Food f2 = new ChineeseFood((Food)new VegFood());
                        Console.WriteLine(f2.prepareFood());
                        Console.WriteLine(f2.foodPrice());
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Other than these no food available");
                    }
                    return;
            }//end of switch  

        } while (choice != 4);  
    }  
}  