using System;
using System.ServiceModel;
using Core;

namespace Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    internal class WcfService : IContract
    {
        public void Foo()
        {
            Console.WriteLine("Client connected");                        
            Console.WriteLine("\tReturning callback to the client");            
            
            var callback = OperationContext.Current.GetCallbackChannel<IContractCallback>();
            callback.OnFooCallback();
            
            Console.WriteLine("Callback returned");
            Console.WriteLine("DONE");   
        }
    }
}