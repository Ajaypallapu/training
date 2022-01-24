// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Plan
{
    public int rate;
   public abstract void GetRate();
    public void calculateBill(int units)
    {
        Console.WriteLine(units * rate);
    }


}
class DomesticPlan : Plan
{
   public override void GetRate()
   {
        rate= 3;
   }
    
}
class CommercialPlan : Plan
{
 
    public override void GetRate()
    {
        rate= 7;
    }
}
class InstitutionalPlan : Plan
{
   //@override  
    public override void GetRate()
    {
        rate =5;
    }
}
class GetPlanFactory
{
   
    public Plan getPlan(String planType)
    {

        if (planType.Equals("DOMESTICPLAN"))
        {
            return new DomesticPlan();
        }
        else if (planType.Equals("COMMERCIALPLAN"))
        {
            return new CommercialPlan();
        }
        else if (planType.Equals("INSTITUTIONALPLAN"))
        {
            return new InstitutionalPlan();
        }
        else {
            return null;
        }
    }
}
class GenerateBill
{
    public static void Main(String []args)
    {
        GetPlanFactory planFactory = new GetPlanFactory();
        String planName = "COMMERCIALPLAN";
        Plan p = planFactory.getPlan(planName);
        int units = 5;
        p.GetRate();
        
        p.calculateBill(units);

        
    }
}