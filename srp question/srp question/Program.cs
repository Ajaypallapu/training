// See https://aka.ms/new-console-template for more information
/*public class GarageStation
{
    public void DoOpenGate()
    {
        //Open the gate functinality
    }

    public void PerformService(Vehicle vehicle)
    {
        //Check if garage is opened
        //finish the vehicle service
    }

    public void DoCloseGate()
    {
        //Close the gate functinality
    }
}*/
public interface IGarageUtility
{
    String  OpenGate();
    void CloseGate();
}
public class GarageStationUtility : IGarageUtility
{
    public String  OpenGate()
    {
        return "gate opened";
    }

    public void CloseGate()
    {
        Console.WriteLine("closing gate");
    }
}
public class GarageStation
{
    IGarageUtility _garageUtil;

    public GarageStation(IGarageUtility garageUtil)
    {
        this._garageUtil = garageUtil;
    }
    public String  OpenForService()
    {
         String s =_garageUtil.OpenGate();
        return s;
    }
    public void DoService()
    {
        //Check if service station is opened and then
        //finish the vehicle service
        if (_garageUtil.OpenGate().Equals("gate opened")) {
            Console.WriteLine("vehicle move inside");
        }
    }
    public void CloseGarage()
    {
        _garageUtil.CloseGate();
    }
}public class problem{
    static void Main(String[] args) {
        IGarageUtility aj = new GarageStationUtility();
        GarageStation ay = new GarageStation(aj);
        ay.DoService();
        ay.CloseGarage();




    }
}