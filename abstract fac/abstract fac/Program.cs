// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface Bank
{
    String getBankName();
}
class HDFC : Bank
{
    private String BNAME;
public HDFC()
{
    BNAME = "HDFC BANK";
}
public String getBankName()
{
    return BNAME;
}  
}
class ICICI : Bank
{
    private  String BNAME;
public ICICI(){
    BNAME = "ICICI BANK";
}
public String getBankName()
{
    return BNAME;
}  
}
class SBI : Bank
{
    private String BNAME;
public SBI()
{
    BNAME = "SBI BANK";
}
public String getBankName()
{
    return BNAME;
}  
}
public abstract class Loan
{
    protected double rate;
    public abstract void GetInterestRate(double rate);
    public void calculateLoanPayment(double loanamount, int years)
    {


        double EMI;
        int n;

        n = years * 12;
        rate = rate / 1200;
        EMI = ((rate * Math.Pow((1 + rate), n)) / ((Math.Pow((1 + rate), n)) - 1)) * loanamount;

        Console.WriteLine("your monthly EMI is " + EMI + " for the amount" + loanamount + " you have borrowed");
    }
}
class HomeLoan : Loan
{
     public override void GetInterestRate(double r)
{
    rate = r;
}  
}class BussinessLoan : Loan
{
    public override void GetInterestRate(double r)
{
    rate = r;
}  
  
}
class EducationLoan : Loan
{
     public override void GetInterestRate(double r)
{
     rate = r;
}  
}public abstract class AbstractFactory
{
    public abstract Bank GetBank(String bank);
    public abstract Loan GetLoan(String loan);
}
class BankFactory : AbstractFactory
{
   public override Bank GetBank(String bank)
{
    if (bank == null)
    {
        return null;
    }
    if (bank.Equals("HDFC"))
    {
        return new HDFC();
    }
    else if (bank.Equals("ICICI"))
    {
        return new ICICI();
    }
    else if (bank.Equals("SBI"))
    {
        return new SBI();
    }
    return null;
}
public override  Loan GetLoan(String loan)
{
    return null;
}  
}//End of the BankFactory class.  
class LoanFactory : AbstractFactory
{
           public override  Bank GetBank(String bank)
{
    return null;
}

public override  Loan GetLoan(String loan)
{
    if (loan == null)
    {
        return null;
    }
    if (loan.Equals("Home"))
    {
        return new HomeLoan();
    }
    else if (loan.Equals("Business"))
    {
        return new BussinessLoan();
    }
    else if (loan.Equals("Education"))
    {
        return new EducationLoan();
    }
    return null;
}  
     
}  

class FactoryCreator
{
    public static AbstractFactory getFactory(String choice)
    {
        if (choice.Equals("Bank"))
        {
            return new BankFactory();
        }
        else if (choice.Equals("Loan"))
        {
            return new LoanFactory();
        }
        return null;
    }
}
class AbstractFactoryPatternExample
{
    public static void Main(String []args)
    {
        String bankName = "ICICI";
        String loanName = "Home";
        AbstractFactory bankFactory = FactoryCreator.getFactory("Bank");
        Bank b = bankFactory.GetBank(bankName);
        double rate = 10;
        double loanAmount = 1000000;
        int years = 2;
        Console.WriteLine("you are taking the loan from " + b.getBankName());

        AbstractFactory loanFactory = FactoryCreator.getFactory("Loan");
        Loan l = loanFactory.GetLoan(loanName);
        l.GetInterestRate(rate);
        l.calculateLoanPayment(loanAmount, years);
    }
}