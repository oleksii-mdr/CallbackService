using System.ServiceModel;
using System.ServiceModel.Channels;
using Core;

namespace Client
{
    internal class Proxy : DuplexClientBase<IContract>
    {
        internal Proxy(object callbackInstance, Binding binding, EndpointAddress remoteAddress)
            : base(callbackInstance, binding, remoteAddress) { }       
    }
}
