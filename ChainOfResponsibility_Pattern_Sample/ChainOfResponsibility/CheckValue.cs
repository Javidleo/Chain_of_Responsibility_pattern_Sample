namespace ChainOfResponsibility_Pattern_Sample.ChainOfResponsibility;
public class CheckValue : TransferMoney
{
    public CheckValue(TransferMoney successor) : base(successor)
    {
    }

    public override Response Execute(Request request)
    {
        if (request.FromCustomer.AccountValue >= request.Value)
            return (_successor.Execute(request));

        return new Response("your account value is not enough to handle this operation");
    }
}
