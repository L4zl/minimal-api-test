using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OpOperationResourceType
    {
        public OpOperationResourceType()
        {
            BomOperationResources = new HashSet<BomOperationResource>();
            OpOperationResources = new HashSet<OpOperationResource>();
        }

        public long OpOperationResourceTypeId { get; set; }
        public string Code { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomOperationResource> BomOperationResources { get; set; }
        public virtual ICollection<OpOperationResource> OpOperationResources { get; set; }
    }
}
