using System;
using System.ServiceModel;
using Core;

namespace Service
{
    //This property indicates whether an instance of a service can handle one thread 
    //or multiple threads that execute concurrently
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