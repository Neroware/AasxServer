using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;

namespace AasOperationInvocation
{
    public class OperationReceiver : IOperationReceiver
    {
        public OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

        public async Task<OperationResult> OnOperationInvokeAsync(string handleId, IOperation operation, int? timestamp, string requestId)
        {
            // Console.WriteLine("Task initiated...");
            // OperationInvoker.UpdateExecutionState(handleId, ExecutionState.InitiatedEnum);

            // Console.WriteLine("Task running...");
            // OperationInvoker.UpdateExecutionState(handleId, ExecutionState.RunningEnum);
            // await Task.Delay(5000);

            // Console.WriteLine("Task done...");
            // OperationInvoker.UpdateExecutionState(handleId, ExecutionState.CompletedEnum);

            // return new OperationResult() { ExecutionState = ExecutionState.CompletedEnum };

            throw new NotImplementedException("invoking operations not yet supported");
        }

    }
}