using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AdminShellNS.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class OperationHandle
    {
        /// <summary>
        /// Gets and Inits Task
        /// </summary>
        
        public Task<OperationResult> Task { get; init; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets HandleId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "handleId")]
        public string HandleId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionState
        /// </summary>
        [DataMember(Name = "executionState")]
        public ExecutionState ExecutionState { get; set; }
    }
}
