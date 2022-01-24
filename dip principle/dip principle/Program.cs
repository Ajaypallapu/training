// See https://aka.ms/new-console-template for more information
 /*public class BAL{
  private readonly DAl dal ;
  public BAL(){
  dal = new DAL();
  }public void Save(object details){
  dal.Save(details);
  }
  }
  public class DAl {
  public void Save(object details){
 
  }
  }*/

public class BAL
{
    private readonly DAL dal;
    public BAL()
    {
        dal = new DAL();
    }
    public void Save(object details)
    {
        dal.Save(details);
    }
}
public interface ajay {
    void Save(object details);
}
public class DAL : ajay
{
    public void Save(object details)
    {
        Console.WriteLine("save details");
    }
    static void Main(String[] args) {
        ajay aj = new DAL();
        aj.Save(new BAL());
    }
}