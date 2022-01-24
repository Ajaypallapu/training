public abstract class Handler {
    public Handler rsHandler;
    public Handler  NextHandler(Handler rsHandler) {
        this.rsHandler =rsHandler;
        return rsHandler;
    }
    public abstract void dispatch(int requestedAmount);
}
public class TwoThous : Handler { 
    public  override void  dispatch(int requestedAmount) {
        int dispatchedamount = requestedAmount / 2000;
        if (dispatchedamount > 0) {
            Console.WriteLine(dispatchedamount + "two thousand notes to be dispached ");
        }
        int pendingAmount = requestedAmount % 2000;
        if (pendingAmount > 0)
        {
            rsHandler.dispatch(pendingAmount);
        }
    }
}
public class FiveHund : Handler
{
    public  override void  dispatch(int requestedAmount)
    {
        int dispatchedamount = requestedAmount / 500;
        if (dispatchedamount > 0)
        {
            Console.WriteLine(dispatchedamount+"five hundred notes to be dispached ");
        }
        int pendingAmount = requestedAmount % 500;
        if (pendingAmount > 0)
        {
            rsHandler.dispatch(pendingAmount);
        }
    }
}
public class OneHund : Handler
{
    public override void dispatch(int requestedAmount)
    {
        int dispatchedamount = requestedAmount / 100;
        if (dispatchedamount > 0)
        {
            Console.WriteLine(dispatchedamount + "One hundred notes to be dispached ");
        }
        int pendingAmount = requestedAmount % 100;
        if (pendingAmount > 0)
        {
            rsHandler.dispatch(pendingAmount);
        }
    }
}


public class ATM
    {
        TwoThous aj = new TwoThous();
        FiveHund ay = new FiveHund();
    OneHund ak = new OneHund();
        public ATM()
        {
            aj.NextHandler(ay).NextHandler(ak);
        }
        public void withdraw(int requstedAmount)
        {
            aj.dispatch(requstedAmount);
        }
    }
    class program
    {
        static void Main(String[] args)
        {
            ATM atm = new ATM();
            atm.withdraw(4600);
        }
    }
