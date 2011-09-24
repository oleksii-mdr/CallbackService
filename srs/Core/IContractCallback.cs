using System.ServiceModel;

namespace Core
{
    [ServiceContract]
    public interface IContractCallback
    {
        [OperationContract]
        void OnFooCallback();
    }
}
