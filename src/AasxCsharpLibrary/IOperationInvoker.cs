using AdminShellNS.Models;

namespace AdminShellNS
{
    public interface IOperationInvoker 
    {
        IOperationCommand Command { get; init; }

        OperationResult Invoke();
        void InvokeAsync(OperationHandle operationHandle);

    }
}