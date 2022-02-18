using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomRecord
    {
        public BomRecord()
        {
            BomBuildPackages = new HashSet<BomBuildPackage>();
            BomBuildProducts = new HashSet<BomBuildProduct>();
            BomCostSessions = new HashSet<BomCostSession>();
            BomDrawings = new HashSet<BomDrawing>();
            WopOrders = new HashSet<WopOrder>();
        }

        public long BomRecordId { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BomVersion { get; set; } = null!;
        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedByUserName { get; set; } = null!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByUserName { get; set; } = null!;
        public bool IsOnHold { get; set; }
        public long? BomReasonForHoldId { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public string ChangeReference { get; set; } = null!;
        public long BomVersionStatusId { get; set; }
        public string QualityStandard { get; set; } = null!;
        public bool Suspended { get; set; }
        public string UserRevisionNumber { get; set; } = null!;
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public bool ComponentTraceability { get; set; }
        public bool? CheckedOut { get; set; }
        public string? CheckedOutBy { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public long? CheckedOutBomRecordId { get; set; }
        public string? BomFamilyIdentifier { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomReasonForHold? BomReasonForHold { get; set; }
        public virtual BomVersionStatus BomVersionStatus { get; set; } = null!;
        public virtual BomImage BomImage { get; set; } = null!;
        public virtual ICollection<BomBuildPackage> BomBuildPackages { get; set; }
        public virtual ICollection<BomBuildProduct> BomBuildProducts { get; set; }
        public virtual ICollection<BomCostSession> BomCostSessions { get; set; }
        public virtual ICollection<BomDrawing> BomDrawings { get; set; }
        public virtual ICollection<WopOrder> WopOrders { get; set; }
    }
}
