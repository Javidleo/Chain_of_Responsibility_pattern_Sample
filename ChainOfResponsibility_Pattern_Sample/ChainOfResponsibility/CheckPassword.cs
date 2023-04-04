namespace ChainOfResponsibility_Pattern_Sample.ChainOfResponsibility;
public class CheckPassword : TransferMoney
{
    public CheckPassword(TransferMoney successor) : base(successor)
    {
    }

    public override Response Execute(Request request)
    {
        if (request.FromCustomer.Password == request.Password)
            return (_successor.Execute(request));

        return new Response("invalid Password");
    }
}
