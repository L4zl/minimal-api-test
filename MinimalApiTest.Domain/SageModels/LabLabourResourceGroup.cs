using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class LabLabourResourceGroup
    {
        public LabLabourResourceGroup()
        {
            LabLabourResources = new HashSet<LabLabourResource>();
        }

        public long LabLabourResourceGroupId { get; set; }
        public long MsmCostHeadingId { get; set; }
        public string GroupReference { get; set; } = null!;
        public string? Description { get; set; }
        public bool PieceWork { get; set; }
        public decimal? PieceWorkQuantity { get; set; }
        public decimal CostRate { get; set; }
        /// <summary>
        /// Primary Key for Nominal Account
        /// </summary>
        public long? NominalAccountId { get; set; }
        /// <summary>
        /// Nominal Account Number
        /// </summary>
        public string NominalAccountNumber { get; set; } = null!;
        /// <summary>
        /// Nominal Cost Centre
        /// </summary>
        public string NominalAccountCostCentre { get; set; } = null!;
        /// <summary>
        /// Nominal Department
        /// </summary>
        public string NominalAccountDepartment { get; set; } = null!;
        public bool Archived { get; set; }
        /// <summary>
        /// Overhead Recovery Percentage
        /// </summary>
        public decimal OverheadRecoveryPercentage { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal EfficiencyPercentage { get; set; }
        public long? OverheadNominalAccountId { get; set; }
        public string? OverheadNominalAccountNumber { get; set; }
        public string? OverheadNominalAccountCostCentre { get; set; }
        public string? OverheadNominalAccountDepartment { get; set; }
        public bool AllowCostRateOverride { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual ICollection<LabLabourResource> LabLabourResources { get; set; }
    }
}
