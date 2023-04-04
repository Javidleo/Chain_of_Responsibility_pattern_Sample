namespace ChainOfResponsibility_Pattern_Sample.ChainOfResponsibility;
public class FinalTransfer : TransferMoney
{
    public FinalTransfer(TransferMoney successor) : base(successor)
    {
    }

    public override Response Execute(Request request)
    {
        request.FromCustomer.AccountValue -= request.Value;
        request.ToCustomer.AccountValue += request.Value;

        return new Response(
            $"transfer compeleted, sender value is" +
            $"{request.FromCustomer.AccountValue} " +
            $"and receiver value is " +
            $"{request.ToCustomer.AccountValue} ");
    }
}
