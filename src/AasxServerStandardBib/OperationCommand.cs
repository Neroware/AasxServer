using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;
using System.Collections.Generic;
using System.Linq;

namespace AasOperationInvocation 
{
    public class OperationCommand : IOperationCommand
    {
        private readonly IOperation _operation;
        private readonly OperationVariable[] _inputs;
        private readonly OperationVariable[] _inOuts;
        private readonly int? _timestamp;
        private readonly string _requestId;
        private readonly string _submodelId;
        public IOperationReceiver OperationReceiver { get; init; }

        public OperationCommand(IOperationReceiver operationReceiver, IOperation operation, IEnumerable<OperationVariable> inputs, IEnumerable<OperationVariable> inOuts, string submodelId, int? timestamp, string requestId)
        {
            OperationReceiver = operationReceiver;
            _operation = operation;
            _inputs = inputs.ToArray();
            _inOuts = inOuts.ToArray();
            _timestamp = timestamp;
            _requestId = requestId;
            _submodelId = submodelId;
        }

        public OperationResult Execute()
        {
            // TODO Currenty only supports properties!
            for (int i = 0; i < _inputs.Length && i < _operation.InputVariables.Count; i++) {
                if (_operation.InputVariables[i].Value is Property va && _inputs[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            for (int i = 0; i < _inOuts.Length && i < _operation.InoutputVariables.Count; i++) {
                if (_operation.InoutputVariables[i].Value is Property va && _inOuts[i].Value is Property arg) 
                    va.Value = arg.Value;
            }

            var result = OperationReceiver.OnOperationInvoke(_operation, _submodelId, _timestamp, _requestId);

            // TODO Currenty only supports properties!
            for (int i = 0; i < result.InoutputArguments.Count && i < _operation.InoutputVariables.Count; i++) {
                if (_operation.InoutputVariables[i].Value is Property va && result.InoutputArguments[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            for (int i = 0; i < result.OutputArguments.Count && i < _operation.OutputVariables.Count; i++) {
                if (_operation.OutputVariables[i].Value is Property va && result.OutputArguments[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            return result;
        }

        public async Task<OperationResult> ExecuteAsync(string handleId)
        {
            // TODO Currenty only supports properties!
            for (int i = 0; i < _inputs.Length && i < _operation.InputVariables.Count; i++) {
                if (_operation.InputVariables[i].Value is Property va && _inputs[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            for (int i = 0; i < _inOuts.Length && i < _operation.InoutputVariables.Count; i++) {
                if (_operation.InoutputVariables[i].Value is Property va && _inOuts[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
        
            var result = await OperationReceiver.OnOperationInvokeAsync(handleId, _operation, _submodelId, _timestamp, _requestId);
        
            // TODO Currenty only supports properties!
            for (int i = 0; i < result.InoutputArguments.Count && i < _operation.InoutputVariables.Count; i++) {
                if (_operation.InoutputVariables[i].Value is Property va && result.InoutputArguments[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            for (int i = 0; i < result.OutputArguments.Count && i < _operation.OutputVariables.Count; i++) {
                if (_operation.OutputVariables[i].Value is Property va && result.OutputArguments[i].Value is Property arg) 
                    va.Value = arg.Value;
            }
            return result;
        }

    }

}