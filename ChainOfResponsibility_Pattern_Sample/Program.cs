// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility_Pattern_Sample;
using ChainOfResponsibility_Pattern_Sample.ChainOfResponsibility;

Console.WriteLine("Chain of Responsibility Sample by https://barnamenevisan.org/Articles/Article8729.html");

Console.WriteLine("sender account value: ");
int fromCustomerValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("receiver account value: ");
int toCustomerValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("how much money you want to send?");
int value = int.Parse(Console.ReadLine()!);

var fromCustomer = new Customer()
{
    AccountValue = fromCustomerValue,
    IsActive = true,
    Password = "1234"
};

var toCustomer = new Customer()
{
    AccountValue = toCustomerValue,
    IsActive = true,
    Password = "1234"
};

var request = new Request()
{
    FromCustomer = fromCustomer,
    ToCustomer = toCustomer,
    Password = "1234",
    Value = value
};

var transfer = new CheckPassword(new CheckValue(new CheckIsActive(new FinalTransfer(null))));

var response = transfer.Execute(request);

Console.WriteLine(response);
Console.ReadKey();

