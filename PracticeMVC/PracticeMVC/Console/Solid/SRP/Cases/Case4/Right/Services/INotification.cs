using SRP.Cases.Case3.Right.Models;

namespace SRP.Cases.Case4.Right.Services

{
    public interface INotification<T>
    {
         void SendNotification(ICustomer objCustomer);
    }
}