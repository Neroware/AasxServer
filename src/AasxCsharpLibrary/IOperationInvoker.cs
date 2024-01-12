using System.Threading.Tasks;
using AdminShellNS.Models;

namespace AdminShellNS
{
    public interface IOperationInvoker 
    {
        IOperationCommand Command { get; init; }

        OperationResult Invoke();
        Task<OperationResult> InvokeAsync(out OperationHandle operationHandle);
    }
}