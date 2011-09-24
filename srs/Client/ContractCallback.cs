using System;
using Core;

namespace Client
{
    internal class ContractCallback : IContractCallback
    {
        public void OnFooCallback()
        {
            Console.WriteLine("\tCallback returned from the server");
        }
    }
}
