using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class LabLabourResource
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public long LabLabourResourceId { get; set; }
        public long MsmCostHeadingId { get; set; }
        /// <summary>
        /// Resource Reference
        /// </summary>
        public string Reference { get; set; } = null!;
        /// <summary>
        /// Resource Description
        /// </summary>
        public string? Description { get; set; }
        public bool PieceWork { get; set; }
        public decimal? PieceWorkQuantity { get; set; }
        public decimal CostRate { get; set; }
        public long LabLabourResourceGroupId { get; set; }
        /// <summary>
        /// Overhead Recovery Percentage
        /// </summary>
        public decimal OverheadRecoveryPercentage { get; set; }
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
        public long? OverheadNominalAccountId { get; set; }
        public string OverheadNominalAccountNumber { get; set; } = null!;
        public string OverheadNominalAccountCostCentre { get; set; } = null!;
        public string OverheadNominalAccountDepartment { get; set; } = null!;
        public bool Archived { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public decimal EfficiencyPercentage { get; set; }
        public bool AllowCostRateOverride { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual LabLabourResourceGroup LabLabourResourceGroup { get; set; } = null!;
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
    }
}
