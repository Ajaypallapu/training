// See https://aka.ms/new-console-template for more information
public interface Tv {
    void Reach();
}
public class Sonyremote: Tv {
    public  void Reach() {
        Console.WriteLine("sony remote working");
    }
}
public class Samsungremote : Tv {
    public void Reach() {
        Console.WriteLine("samsung remote working");
    }
}class Bridge {
   public  void ReachTo(Tv obj) {
        obj.Reach();
    }
}class Legacy {
    static void Main(String[] args) {
        Bridge aj = new Bridge();
        Sonyremote a = new Sonyremote();
        Samsungremote b = new Samsungremote();
        aj.ReachTo(a);
        aj.ReachTo(b);

    }
}
