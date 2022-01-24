// See https://aka.ms/new-console-template for more information
public class Originator
{

    private String state;

    public void setState(String state)
    {
        this.state = state;
    }

    public String getState()
    {
        return state;
    }

    public Memento saveStateToMemento()
    {
        return new Memento(state);
    }

    public void getStateFromMemento(Memento Memento)
    {
        state = Memento.getState();
    }
}
public class Memento
{

    private String state;

    public Memento(String state)
    {
        this.state = state;
    }
    public String getState()
    {
        return state;
    }

}
public class Caretaker
{

    private List<Memento> mementoList = new List<Memento>();

    public void add(Memento state)
    {
        mementoList.Add(state);
    }

    public Memento get(int index)
    {
        return mementoList[index];
    }

}
public class MementoPatternDemo
{

    public static void Main(String[]args)
    {

        Originator originator = new Originator();

        Caretaker careTaker = new Caretaker();

        originator.setState("State #1");
        careTaker.add(originator.saveStateToMemento());
        originator.setState("State #2");
        careTaker.add(originator.saveStateToMemento());
        originator.setState("State #3");
        careTaker.add(originator.saveStateToMemento());
        originator.setState("State #4");

        Console.WriteLine("Current State: " + originator.getState());
        originator.getStateFromMemento(careTaker.get(2));
        Console.WriteLine("previous saved State: " + originator.getState());
        originator.getStateFromMemento(careTaker.get(1));
        Console.WriteLine("first to previous  saved State: " + originator.getState());
        originator.getStateFromMemento(careTaker.get(0));
        Console.WriteLine("second to previous  State: " + originator.getState());
    }

}