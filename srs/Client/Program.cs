using System;
using System.ServiceModel;
using System.Threading;
using Core;

namespace Client
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("===CLIENT===");
            Console.WriteLine("Waiting until server is running");
            Thread.Sleep(3000);
            Console.WriteLine("Client is trying to connect");

            var callback = new ContractCallback();
            var binding = new NetTcpBinding();
            var client = new Proxy(callback, binding, new EndpointAddress(LocalSettings.URI));
            var proxy = client.ChannelFactory.CreateChannel();

            Console.WriteLine("Connection OPENED");
            proxy.Foo();
            client.Close();
            Console.WriteLine("Connection CLOSED");
            Console.WriteLine("DONE");   

            Console.Read();
        }       
    }
}
