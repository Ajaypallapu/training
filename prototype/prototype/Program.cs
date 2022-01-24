// See https://aka.ms/new-console-template for more information

interface Prototype
{

    public Prototype getClone();

}
class EmployeeRecord : Prototype
{


   private int id;
private String name, designation;
private double salary;
private String address;
public EmployeeRecord(int id, String name, String designation, double salary, String address)
{

    this.id = id;
    this.name = name;
    this.designation = designation;
    this.salary = salary;
    this.address = address;
}

public void showRecord()
{

    Console.WriteLine(id + "\t" + name + "\t" + designation + "\t" + salary + "\t" + address);
}

    public Prototype getClone()
{

    return new EmployeeRecord(id, name, designation, salary, address);
}  
}
class PrototypeDemo
{
    public static void Main(String []args)
    {
        int eid = 5;
        String ename = "ajay";
        String edesignation = "junior software engineer";
        double esalary = 430000;
        String eaddress = "prakasam";
        EmployeeRecord e1 = new EmployeeRecord(eid, ename, edesignation, esalary, eaddress);

        e1.showRecord();
        EmployeeRecord e2 = (EmployeeRecord)e1.getClone();
        e2.showRecord();
    }
}
