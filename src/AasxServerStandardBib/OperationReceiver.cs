using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;

namespace AasOperationInvocation
{
    public class OperationReceiver : IOperationReceiver
    {
        public OperationResult GetResult(string handleId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

        public OperationResult OnOperationInvoke(IOperation operation, string submodelId, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

        public Task<OperationResult> OnOperationInvokeAsync(string handleId, IOperation operation, string submodelId, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

    }
}