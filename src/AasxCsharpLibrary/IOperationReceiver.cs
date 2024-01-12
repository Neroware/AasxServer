using System.Threading.Tasks;
using AdminShellNS.Models;

namespace AdminShellNS
{
    public interface IOperationReceiver 
    {
        OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId);
        Task<OperationResult> OnOperationInvokeAsync(string handleId, IOperation operation, int? timestamp, string requestId);
    }
}