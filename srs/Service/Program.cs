using System;
using System.ServiceModel;
using Core;

namespace Service
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("===SERVER===");

            var uri = new Uri(LocalSettings.URI);
            var binding = new NetTcpBinding();
            var host = new ServiceHost(typeof(WcfService), uri);
            host.AddServiceEndpoint(typeof(IContract), binding, "");
            host.Open();
            
            Console.WriteLine("Hosting started...");
            Console.Read();
        }
    }
}
