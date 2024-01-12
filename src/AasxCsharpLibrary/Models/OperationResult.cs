using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AdminShellNS.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class OperationResult
    {
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets OutputArguments
        /// </summary>
        
        [DataMember(Name = "outputArguments")]
        public List<OperationVariable> OutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets InoutputArguments
        /// </summary>
        
        [DataMember(Name = "inoutputArguments")]
        public List<OperationVariable> InoutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        
        [MaxLength(1024)]
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionState
        /// </summary>

        [DataMember(Name = "executionState")]
        public ExecutionState ExecutionState { get; set; }

    }
}
