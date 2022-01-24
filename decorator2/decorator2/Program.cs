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

public  class FoodDecorator : Food
{
    private  Food newFood;
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
    public NonVegFood(Food newFood) : base(newFood)
    {
        
    }
    public String prepareFood()
    {
        
        return base.prepareFood() + "With Roasted Chiken and Chiken Curry";
    }
    public double foodPrice()
    {
        return  base.foodPrice() + 150.0;
    }
}
public class ChineeseFood : FoodDecorator
{
    public ChineeseFood(Food newFood):base(newFood)
    {

    }
    public String prepareFood()
    {
        Console.WriteLine("babu");
        return base.prepareFood() + "With Fried Rice and Manchurian";
    }
    public double foodPrice()
    {
        return base.foodPrice() + 65.0;
    }
}
public class DecoratorPatternCustomer
{
    
    public static void Main(String[] args)
    {
    
            Console.WriteLine("========= Food Menu ============ ");
            Console.WriteLine("            1. Vegetarian Food.   ");
            Console.WriteLine("            2. Non-Vegetarian Food.");
            Console.WriteLine("            3. Chineese Food.         ");
            Console.WriteLine("            4. Exit                        ");
            Console.WriteLine("Enter your choice: ");

        Food vf = new ChineeseFood((Food)new VegFood());

             Console.WriteLine(vf.prepareFood());
            Console.WriteLine(vf.foodPrice());

    }
}