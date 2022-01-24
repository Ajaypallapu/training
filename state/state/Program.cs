// See https://aka.ms/new-console-template for more information
public interface Connection
{

    public void open();
    public void close();
    public void log();
    public void update();
}
public class Accounting : Connection
{

    
       public void open()
{
    Console.WriteLine("open database for accounting");
}

       public void close()
{
        Console.WriteLine("close the database");
}

       public void log()
{
        Console.WriteLine("log activities");
}


       public void update()
{
        Console.WriteLine("Accounting has been updated");
}  
}public class Sales : Connection
{


       public void open()
{
        Console.WriteLine("open database for sales");
}
       public void close()
{
        Console.WriteLine("close the database");
}


       public void log()
{
        Console.WriteLine("log activities");
}


       public void update()
{
        Console.WriteLine("Sales has been updated");
}  
  
}public class Management : Connection
{

    
       public void open()
{
        Console.WriteLine("open database for Management");
}

       public void close()
{
        Console.WriteLine("close the database");
}


       public void log()
{
        Console.WriteLine("log activities");
}


       public void update()
{
        Console.WriteLine("Management has been updated");
}  
  
}  public  class Controller
{

    public static Accounting acct;
    public static Sales sales;
    public static Management management;

    private static Connection con;

   public  Controller()
    {
        acct = new Accounting();
        sales = new Sales();
        management = new Management();
    }

    public void setAccountingConnection()
    {
        con = acct;
    }
    public void setSalesConnection()
    {
        con = sales;
    }
    public void setManagementConnection()
    {
        con = management;
    }
    public void open()
    {
        con.open();
    }
    public void close()
    {
        con.close();
    }
    public void log()
    {
        con.log();
    }
    public void update()
    {
        con.update();
    }


}
 public class StatePatternDemo
{

     Controller controller ;
     StatePatternDemo(String con)
    {
        controller = new Controller();

        //the following trigger should be made by the user  
        if (con.Equals("management"))
            controller.setManagementConnection();
        if (con.Equals("sales"))
            controller.setSalesConnection();
        if (con.Equals("accounting"))
            controller.setAccountingConnection();
        controller.open();
        controller.log();
        controller.close();
        controller.update();
    }


    public static void Main(String []args)
    {

        new StatePatternDemo("sales");

    }

}
