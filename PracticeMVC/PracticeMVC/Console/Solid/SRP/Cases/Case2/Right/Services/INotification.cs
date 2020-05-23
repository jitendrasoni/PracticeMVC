using SRP.Cases.Case2.Right.Models;

namespace SRP.Cases.Case2.Right.Services
{
    public interface INotification
    {
         void SendNotification(ICustomer objCustomer);
    }
}