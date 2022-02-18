using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscategoryComponent
    {
        public TscategoryComponent()
        {
            InverseParentCategoryComponent = new HashSet<TscategoryComponent>();
            TsclaimRecordTscategories = new HashSet<TsclaimRecord>();
            TsclaimRecordTscategoryGroups = new HashSet<TsclaimRecord>();
        }

        public long TscategoryComponentId { get; set; }
        public long? ParentCategoryComponentId { get; set; }
        public long TscategoryComponentTypeId { get; set; }
        public long TscategoryCompStatusTypeId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? NominalAccountNumber { get; set; }
        public string? NominalCostCentre { get; set; }
        public string? NominalDepartment { get; set; }
        public long? SystaxCodeId { get; set; }
        public decimal UnitRate { get; set; }
        public bool? UnitBased { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TscategoryComponent? ParentCategoryComponent { get; set; }
        public virtual TscategoryCompStatusType TscategoryCompStatusType { get; set; } = null!;
        public virtual TscategoryCompType TscategoryComponentType { get; set; } = null!;
        public virtual ICollection<TscategoryComponent> InverseParentCategoryComponent { get; set; }
        public virtual ICollection<TsclaimRecord> TsclaimRecordTscategories { get; set; }
        public virtual ICollection<TsclaimRecord> TsclaimRecordTscategoryGroups { get; set; }
    }
}
