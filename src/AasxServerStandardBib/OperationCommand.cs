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
        private readonly string _submodelId;
        public IOperationReceiver OperationReceiver { get; init; }

        public OperationCommand(IOperationReceiver operationReceiver, IOperation operation, string submodelId, int? timestamp, string requestId)
        {
            OperationReceiver = operationReceiver;
            _operation = operation;
            _timestamp = timestamp;
            _requestId = requestId;
            _submodelId = submodelId;
        }

        public OperationResult Execute()
        {
            return OperationReceiver.OnOperationInvoke(_operation, _submodelId, _timestamp, _requestId);
        }

        public Task<OperationResult> ExecuteAsync(string handleId)
        {
            return OperationReceiver.OnOperationInvokeAsync(handleId, _operation, _submodelId, _timestamp, _requestId);
        }

    }

}