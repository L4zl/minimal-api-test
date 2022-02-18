using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ToolToolingResource
    {
        public ToolToolingResource()
        {
            ToolToolingResourceActivities = new HashSet<ToolToolingResourceActivity>();
        }

        public long ToolToolingResourceId { get; set; }
        public long MsmCostHeadingId { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        /// <summary>
        /// Cost Rate
        /// </summary>
        public decimal CostRate { get; set; }
        public decimal Quantity { get; set; }
        public long ToolToolingResourceGroupId { get; set; }
        public int FullServiceHours { get; set; }
        public int OrdinaryServiceHours { get; set; }
        public int CalibrationHours { get; set; }
        public short? ServiceInterval { get; set; }
        public long ServiceIntervalPeriodId { get; set; }
        public short? CalibrationInterval { get; set; }
        public long CalibrationIntervalPeriodId { get; set; }
        public string? Dimensions { get; set; }
        public string? Location { get; set; }
        public string? OriginalCertificate { get; set; }
        public string? Range { get; set; }
        public string? AssetSerialNumber { get; set; }
        public string? SourceCalibration { get; set; }
        public string? Type { get; set; }
        /// <summary>
        /// Overhead Recovery Percentage
        /// </summary>
        public decimal? OverheadRecoveryPercentage { get; set; }
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

        public virtual MsmPeriodFrequency CalibrationIntervalPeriod { get; set; } = null!;
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual MsmPeriodFrequency ServiceIntervalPeriod { get; set; } = null!;
        public virtual ToolToolingResourceGroup ToolToolingResourceGroup { get; set; } = null!;
        public virtual ICollection<ToolToolingResourceActivity> ToolToolingResourceActivities { get; set; }
    }
}
