using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;

namespace AasOperationInvocation 
{
    public class OperationCommand : IOperationCommand
    {
        private readonly IOperation _operation;
        private readonly int? _timestamp;
        private readonly string _requestId;
        public IOperationReceiver OperationReceiver { get; init; }

        public OperationCommand(IOperationReceiver operationReceiver, IOperation operation, int? timestamp, string requestId)
        {
            OperationReceiver = operationReceiver;
            _operation = operation;
            _timestamp = timestamp;
            _requestId = requestId;
        }

        public OperationResult Execute()
        {
            return OperationReceiver.OnOperationInvoke(_operation, _timestamp, _requestId);
        }

        public Task<OperationResult> ExecuteAsync(in OperationHandle operationHandle)
        {
            return OperationReceiver.OnOperationInvokeAsync(operationHandle, _operation, _timestamp, _requestId);
        }

    }

}