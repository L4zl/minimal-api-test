using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Blclause
    {
        public Blclause()
        {
            BlbillTemplateClauses = new HashSet<BlbillTemplateClause>();
            BlclauseAttributes = new HashSet<BlclauseAttribute>();
            BlclauseEvents = new HashSet<BlclauseEvent>();
        }

        public long BlclauseId { get; set; }
        public long? PccostItemTypeId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public long? TaxCodeId { get; set; }
        public long? BldetailOrSummaryTypeId { get; set; }
        public string BlclauseTypeKey { get; set; } = null!;
        public long? PccostItemId { get; set; }
        public bool IncludeNegativeEntries { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BldetailOrSummaryType? BldetailOrSummaryType { get; set; }
        public virtual PccostItem? PccostItem { get; set; }
        public virtual PccostItemType? PccostItemType { get; set; }
        public virtual ICollection<BlbillTemplateClause> BlbillTemplateClauses { get; set; }
        public virtual ICollection<BlclauseAttribute> BlclauseAttributes { get; set; }
        public virtual ICollection<BlclauseEvent> BlclauseEvents { get; set; }
    }
}
