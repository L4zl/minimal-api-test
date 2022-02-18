using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomCostSession
    {
        public BomCostSession()
        {
            BomCostSessionTotals = new HashSet<BomCostSessionTotal>();
            BomCosts = new HashSet<BomCost>();
        }

        public long BomCostSessionId { get; set; }
        public long BomRecordId { get; set; }
        public long BomBuildPackageId { get; set; }
        public long? CheckedOutBomBuildPackageId { get; set; }
        public string BomReference { get; set; } = null!;
        public long BomVersionStatusId { get; set; }
        public string BomVersion { get; set; } = null!;
        public string UserRevisionNumber { get; set; } = null!;
        public string CostedBy { get; set; } = null!;
        public DateTime DateTimeCosted { get; set; }
        public decimal QtyCosted { get; set; }
        public decimal TotalOverheads { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalCostIncludingOverheads { get; set; }
        public decimal TotalMarkup { get; set; }
        public decimal TotalSalesValue { get; set; }
        public decimal AccountsSellingPrice { get; set; }
        public decimal CalculatedUnitCost { get; set; }
        public decimal SuggestedSellingPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public decimal AverageMarkup { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal AverageMarginPercentage { get; set; }
        public bool Phantom { get; set; }
        public string CostingFamilyGuid { get; set; } = null!;
        public bool TopLevelCostSession { get; set; }
        public long BomBuildPackageTypeId { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string Comment { get; set; } = null!;
        public string CostingLog { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildPackage BomBuildPackage { get; set; } = null!;
        public virtual BomBuildPackageType BomBuildPackageType { get; set; } = null!;
        public virtual BomRecord BomRecord { get; set; } = null!;
        public virtual BomVersionStatus BomVersionStatus { get; set; } = null!;
        public virtual ICollection<BomCostSessionTotal> BomCostSessionTotals { get; set; }
        public virtual ICollection<BomCost> BomCosts { get; set; }
    }
}
