using System.ServiceModel;

namespace Core
{
    [ServiceContract(CallbackContract = typeof(IContractCallback))]
    public interface IContract
    {
        [OperationContract]
        void Foo();
    }
}
