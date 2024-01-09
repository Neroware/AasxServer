using System.Collections.Generic;
using AasxServerStandardBib.Exceptions;
using AdminShellNS.Models;
using AdminShellNS;

namespace AasOperationInvocation 
{
    public class OperationInvoker : IOperationInvoker
    {
        private static readonly Dictionary<string, OperationResult> _asyncStates = new();
        public IOperationCommand Command { get; init; }

        public static OperationResult GetAsyncResult(string handleId)
        {
            if (!_asyncStates.ContainsKey(handleId)) {
                throw new NotFoundException("No invocation at this handle");
            }
            var result = _asyncStates[handleId];
            if (result.ExecutionState != ExecutionState.Initiated && result.ExecutionState != ExecutionState.Running) {
                _asyncStates.Remove(handleId);
            }
            return result;
        }

        public OperationInvoker(IOperationCommand command) 
        {
            Command = command;
        }

        public OperationResult Invoke()
        {
            return Command.Execute();
        }

        public async void InvokeAsync(OperationHandle operationHandle)
        {
            OperationResult operationResult = new() {
                RequestId = operationHandle.RequestId,
                ExecutionState = ExecutionState.Initiated
            };
            _asyncStates.Add(operationHandle.HandleId, operationResult);
            await Command.ExecuteAsync(operationResult);
        }
    }
}