using System.Threading.Tasks;
using AdminShellNS.Models;

namespace AdminShellNS
{
    public interface IOperationReceiver 
    {
        OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId);
        Task<OperationResult> OnOperationInvokeAsync(OperationHandle operationHandle, IOperation operation, int? timestamp, string requestId);
    }
}