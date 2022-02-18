using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomCostSessionTotal
    {
        public long BomCostSessionTotalId { get; set; }
        public long BomCostSessionId { get; set; }
        public long MsmCostHeadingTypeId { get; set; }
        public long MsmCostHeadingId { get; set; }
        public string CostHeadingName { get; set; } = null!;
        public decimal TotalOverheads { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalCostIncludingOverheads { get; set; }
        public decimal TotalMarkup { get; set; }
        public decimal TotalSalesValue { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomCostSession BomCostSession { get; set; } = null!;
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual MsmCostHeadingType MsmCostHeadingType { get; set; } = null!;
    }
}
