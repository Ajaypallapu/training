// See https://aka.ms/new-console-template for more information
public interface ApnaChatRoom
{

    public void showMsg(String msg, Participant p);

}
public class ApnaChatRoomImpl : ApnaChatRoom
{
    //get current date time   

    public void showMsg(String msg, Participant p)
    {

        Console.WriteLine(p.getName() + "'gets message: " + msg);
    }
}
public abstract class Participant
{
    public abstract void sendMsg(String msg);
    public abstract void setname(String name);
    public abstract String getName();
}
public class User1 : Participant
{


    private String name;
private ApnaChatRoom chat;


    public override void sendMsg(String msg)
{
    chat.showMsg(msg, this);

}


    public override void setname(String name)
{
    this.name = name;
}

    public override String getName()
{
    return name;
}

public User1(ApnaChatRoom chat)
{
    this.chat = chat;
}     
      
}
public class User2 : Participant
{


    private String name;
private ApnaChatRoom chat;


    public override void sendMsg(String msg)
{
    chat.showMsg(msg, this);

}


    public override void setname(String name)
{
    this.name = name;
}


    public override String getName()
{
    return name;
}

public User2(ApnaChatRoom chat)
{
    this.chat = chat;
}  
  
      
      
}
public class MediatorPatternDemo
{

    public static void Main(String []args)
    {

        ApnaChatRoom chat = new ApnaChatRoomImpl();

        User1 u1 = new User1(chat);
        u1.setname("Ashwani Rajput");
        u1.sendMsg("Hi Ashwani! how are you?");


        User2 u2 = new User2(chat);
        u2.setname("Soono Jaiswal");
        u2.sendMsg("I am Fine ! what about you?");
    }

}