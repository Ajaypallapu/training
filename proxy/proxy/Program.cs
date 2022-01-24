// See https://aka.ms/new-console-template for more information
public interface OfficeInternetAccess
{
    public void grantInternetAccess();
}
public class RealInternetAccess : OfficeInternetAccess
{
    private String employeeName;
public RealInternetAccess(String empName)
{
    this.employeeName = empName;
}
    public void grantInternetAccess()
{
    Console.WriteLine("Internet Access granted for employee: " + employeeName);
}  
}
public class ProxyInternetAccess : OfficeInternetAccess
{
           private String employeeName;
           private RealInternetAccess realaccess;
           public ProxyInternetAccess(String employeeName)    
{
                  this.employeeName = employeeName;
}
           public void grantInternetAccess()
{
                   if (getRole(employeeName) > 4)
                   {
                           realaccess = new RealInternetAccess(employeeName);
                           realaccess.grantInternetAccess();
                   }
                   else
                   {
                            Console.WriteLine("No Internet access granted. Your job level is below 5");
                   }
           }
           public int getRole(String emplName)
           {  if (emplName.Equals("Ashwani Rajput"))
        {
            return 9;
        }
        else {
            return 1;
        }
           }  
}
public class ProxyPatternClient
{
    public static void Main(String []args)
    {
        OfficeInternetAccess access = new ProxyInternetAccess("Ashwani Rajput");
        access.grantInternetAccess();
    }
}

