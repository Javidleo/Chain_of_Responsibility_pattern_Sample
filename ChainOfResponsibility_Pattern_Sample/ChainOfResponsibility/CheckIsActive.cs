namespace ChainOfResponsibility_Pattern_Sample.ChainOfResponsibility;
public class CheckIsActive : TransferMoney
{
    public CheckIsActive(TransferMoney successor) : base(successor)
    {
    }

    public override Response Execute(Request request)
    {
        if (request.FromCustomer.IsActive is false)
            return new Response("sender is deactivated");

        if (request.ToCustomer.IsActive is false)
            return new Response("receiver is deactivated");

        return (_successor.Execute(request));
    }
}
