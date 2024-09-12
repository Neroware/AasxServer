using AdminShellNS.Models;
using AdminShellNS;
using System.Threading.Tasks;

namespace AasOperationInvocation 
{
    public class OperationInvoker : IOperationInvoker
    {
        public IOperationCommand Command { get; init; }
        private static long _asyncHandleCounter = 0;

        public OperationInvoker(IOperationCommand command)
        {
            Command = command;
        }

        public OperationResult Invoke()
        {
            return Command.Execute();
        }

        public Task<OperationResult> InvokeAsync(out OperationHandle operationHandle)
        {
            operationHandle = new() {
                HandleId = "" + _asyncHandleCounter,
                ExecutionState = ExecutionState.InitiatedEnum,
                Task = Command.ExecuteAsync("" + _asyncHandleCounter++)
            };
            return operationHandle.Task;
        }
    }
}