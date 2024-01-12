using System.Threading.Tasks;
using AdminShellNS.Models;

namespace AdminShellNS 
{
    public interface IOperationCommand
    {
        IOperationReceiver OperationReceiver { get; init; }
        
        OperationResult Execute();
        Task<OperationResult> ExecuteAsync(in OperationHandle operationHandle);
    }
}