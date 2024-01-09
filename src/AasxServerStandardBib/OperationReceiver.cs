using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;

namespace AasOperationInvocation
{
    public class OperationReceiver : IOperationReceiver
    {
        public OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

        public Task OnOperationInvokeAsync(OperationResult inoutResult, IOperation operation, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }
    }
}