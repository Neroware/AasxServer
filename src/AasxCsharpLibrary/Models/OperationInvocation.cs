using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AdminShellNS.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OperationInvocation
    {
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets SubmodelId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "submodelId")]
        public string SubmodelId { get; set; }

        /// <summary>
        /// Gets or Sets OperationIdShort
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "operationIdShort")]
        public string OperationIdShort { get; set; }

        /// <summary>
        /// Gets or Sets InputVariables
        /// </summary>
        
        [DataMember(Name = "inputVariables")]
        public List<IOperationVariable> InputVariables { get; set; }

        /// <summary>
        /// Gets or Sets InoutputVariables
        /// </summary>
        
        [DataMember(Name = "inoutputVariables")]
        public List<IOperationVariable> InoutputVariables { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        
        [DataMember(Name = "timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets IsAsync
        /// </summary>
        
        [DataMember(Name = "isAsync")]
        public bool IsAsync { get; set; }

        /// <summary>
        /// Gets or Sets HandleId
        /// </summary>
        
        [MaxLength(128)]
        [DataMember(Name = "handleId")]
        public string HandleId { get; set; }
    }
}

