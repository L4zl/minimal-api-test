using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TshumanResource
    {
        public TshumanResource()
        {
            PcanalysisFieldValues = new HashSet<PcanalysisFieldValue>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
            PcprojectResourceLinks = new HashSet<PcprojectResourceLink>();
            TshumanResourceChargeRateLinks = new HashSet<TshumanResourceChargeRateLink>();
            TshumanResourceCostRateLinks = new HashSet<TshumanResourceCostRateLink>();
            TshumanResourcePayRateLinks = new HashSet<TshumanResourcePayRateLink>();
            TsresourceResourceLinkOwners = new HashSet<TsresourceResourceLink>();
            TsresourceResourceLinkResources = new HashSet<TsresourceResourceLink>();
        }

        public long TshumanResourceId { get; set; }
        public long TspersonId { get; set; }
        public string EmployeeReference { get; set; } = null!;
        public long TspaymentFrequencyTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string WorksNumber { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long TspaymentMethodId { get; set; }
        public long TsresourceStatusTypeId { get; set; }
        public string BankAccountNumber { get; set; } = null!;
        public string BankAccountName { get; set; } = null!;
        public string BankSortCode { get; set; } = null!;
        public string BankPaymentReference { get; set; } = null!;
        public long StandardTime { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool FilterResources { get; set; }
        public int? MmsuserId { get; set; }
        public long? CbaccountId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount? Cbaccount { get; set; }
        public virtual PlsupplierAccount? PlsupplierAccount { get; set; }
        public virtual TspaymentFrequencyType TspaymentFrequencyType { get; set; } = null!;
        public virtual TspaymentMethod TspaymentMethod { get; set; } = null!;
        public virtual Tsperson Tsperson { get; set; } = null!;
        public virtual TsresourceStatusType TsresourceStatusType { get; set; } = null!;
        public virtual ICollection<PcanalysisFieldValue> PcanalysisFieldValues { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
        public virtual ICollection<PcprojectResourceLink> PcprojectResourceLinks { get; set; }
        public virtual ICollection<TshumanResourceChargeRateLink> TshumanResourceChargeRateLinks { get; set; }
        public virtual ICollection<TshumanResourceCostRateLink> TshumanResourceCostRateLinks { get; set; }
        public virtual ICollection<TshumanResourcePayRateLink> TshumanResourcePayRateLinks { get; set; }
        public virtual ICollection<TsresourceResourceLink> TsresourceResourceLinkOwners { get; set; }
        public virtual ICollection<TsresourceResourceLink> TsresourceResourceLinkResources { get; set; }
    }
}
