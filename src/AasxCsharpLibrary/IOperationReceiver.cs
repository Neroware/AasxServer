using System;
using System.Threading.Tasks;
using AdminShellNS.Models;

namespace AdminShellNS
{
    public interface IOperationReceiver 
    {
        OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId);
        Task OnOperationInvokeAsync(OperationResult inoutResult, IOperation operation, int? timestamp, string requestId);
    }
}