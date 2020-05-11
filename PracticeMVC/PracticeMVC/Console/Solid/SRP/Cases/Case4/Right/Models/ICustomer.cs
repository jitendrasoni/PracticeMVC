namespace SRP.Cases.Case4.Right.Models
{
  public  interface ICustomer
    {
        string EmailAddress { get; set; }
        string Message { get; set; }
        string Name { get; set; }
    }

    public interface ICustomerExtenstion : ICustomer
    {
     
        string NameExtenstion { get; set; }
    }
}