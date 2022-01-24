// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface Packing
{
    public String pack();
    public int price();
}
    
public abstract class Company : Packing
{
    public abstract String pack();
    public abstract  int price();
    
}  
public class Sony : Company
{
        public override  int price()
{
    return 20;
}
    public  override String pack()
{
    return "Sony CD";
}         
}
public class Samsung : Company
{
        public override int price()
{
    return 15;
}
    public override String pack()
{
    return "Samsung CD";
}         
}
public class CDType
{
    private List<Packing> items = new List<Packing>();
    public void addItem(Packing packs)
    {
        items.Add(packs);
    }
    public void getCost()
    {
        foreach(Packing packs in items)
        {
            packs.price();
        }
    }
    public void showItems()
    {
        foreach(Packing packing in items)
        {
            Console.Write("CD name : " + packing.pack());
            Console.WriteLine(", Price : " + packing.price());
        }
    }
}
public class CDBuilder
{
    public CDType buildSonyCD()
    {
        CDType cds = new CDType();
        cds.addItem(new Sony());
        return cds;
    }
    public CDType buildSamsungCD()
    {
        CDType cds = new CDType();
        cds.addItem(new Samsung());
        return cds;
    }
}
    public class BuilderDemo
    {
        public static void Main(String[] args)
        {
            CDBuilder cdBuilder = new CDBuilder();
            CDType cdType1 = cdBuilder.buildSonyCD();
            cdType1.showItems();

            CDType cdType2 = cdBuilder.buildSamsungCD();
            cdType2.showItems();
        }
    }