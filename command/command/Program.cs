// See https://aka.ms/new-console-template for more information
public interface ActionListenerCommand
{
    public void execute();
}
public class Document
{
    public void open()
    {
        Console.WriteLine("Document Opened");
    }
    public void save()
    {
        Console.WriteLine("Document Saved");
    }
}
public class ActionOpen : ActionListenerCommand
{
    private Document doc;
public ActionOpen(Document doc)
{
    this.doc = doc;
}
    public void execute()
{
    doc.open();
}  
}
public class ActionSave : ActionListenerCommand
{
   private Document doc;
public ActionSave(Document doc)
{
    this.doc = doc;
}
    public void execute()
{
    doc.save();
}  
}
public class CommandPatternClient
{
    public static void Main(String []args)
    {
        Document doc = new Document();

        ActionListenerCommand clickOpen = new ActionOpen(doc);
        ActionListenerCommand clickSave = new ActionSave(doc);

        MenuOptions menu = new MenuOptions(clickOpen, clickSave);

        menu.clickopen();
        menu.clicksave();
    }
}public class MenuOptions {
    private ActionListenerCommand clickOpen;
    private ActionListenerCommand clickSave;
    public MenuOptions(ActionListenerCommand clickOpen, ActionListenerCommand clickSave) {
        this.clickOpen = clickOpen;
        this.clickSave = clickSave;
    }public void clickopen() {
        clickOpen.execute();
    }public void clicksave() {
        clickSave.execute();
    }

}