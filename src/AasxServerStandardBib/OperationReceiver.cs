using System;
using System.Threading.Tasks;
using AdminShellNS.Models;
using AdminShellNS;
using Org.BouncyCastle.Asn1.Cms;

namespace AasOperationInvocation
{
    public class OperationReceiver : IOperationReceiver
    {
        public OperationResult OnOperationInvoke(IOperation operation, int? timestamp, string requestId)
        {
            throw new NotImplementedException("invoking operations not yet supported");
        }

        public Task<OperationResult> OnOperationInvokeAsync(OperationHandle operationHandle, IOperation operation, int? timestamp, string requestId)
        {
            // Console.WriteLine("Task initiated...");
            // operationHandle.ExecutionState = ExecutionState.InitiatedEnum;

            // Console.WriteLine("Task running...");
            // operationHandle.ExecutionState = ExecutionState.RunningEnum;
            // await Task.Delay(5000);

            // Console.WriteLine("Task done...");
            // operationHandle.ExecutionState = ExecutionState.CompletedEnum;

            // return new OperationResult() { ExecutionState = ExecutionState.CompletedEnum };

            throw new NotImplementedException("invoking operations not yet supported");
        }

    }
}