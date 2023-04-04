namespace ChainOfResponsibility_Pattern_Sample;
public abstract class TransferMoney
{
    protected readonly TransferMoney _successor;

    protected TransferMoney(TransferMoney successor)
    {
        _successor = successor;
    }

    public abstract Response Execute(Request request);
}
