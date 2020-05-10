using SRP.Cases.Case3.Right.Models;

namespace SRP.Cases.Case3.Right.Services

{
    public interface INotification
    {
         void SendNotification(ICustomer objCustomer);
    }
}