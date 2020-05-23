using SRP.Cases.Case3.Right.Models;

namespace SRP.Cases.Case3.Right.Services

{
    public interface IRegister<t>
    {
        void RegisterInstance(t registerInstance);
    }
}