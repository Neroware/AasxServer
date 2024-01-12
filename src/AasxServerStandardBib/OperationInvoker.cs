using System.Collections.Generic;
using AdminShellNS.Models;
using AdminShellNS;
using System.Threading.Tasks;

namespace AasOperationInvocation 
{
    public class OperationInvoker : IOperationInvoker
    {
        public IOperationCommand Command { get; init; }

        private static readonly Dictionary<string, OperationHandle> _asyncHandles = [];
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
                HandleId = "" + _asyncHandleCounter++,
                ExecutionState = ExecutionState.InitiatedEnum
            };
            _asyncHandles.Add(operationHandle.HandleId, operationHandle);
            operationHandle.Task = Command.ExecuteAsync(operationHandle.HandleId);
            return operationHandle.Task;
        }

        public static OperationResult GetAsyncResult(string handleId)
        {
            OperationHandle operationHandle = _asyncHandles[handleId];

            // Remove if terminated
            if ((int) operationHandle.ExecutionState > 1) {
                _asyncHandles.Remove(handleId);
                return operationHandle.Task.GetAwaiter().GetResult();
            }
            
            return new OperationResult() {
                RequestId = operationHandle.RequestId,
                ExecutionState = operationHandle.ExecutionState
            };
        }

        public static void UpdateExecutionState(string handleId, ExecutionState executionState)
        {
            _asyncHandles[handleId].ExecutionState = executionState;
        }
    }
}