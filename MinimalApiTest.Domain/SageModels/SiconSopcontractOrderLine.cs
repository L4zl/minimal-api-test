using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopcontractOrderLine
    {
        public long SiconSopcontractOrderLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public decimal? ContractPeriod { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public DateTime? BillCoverFromDate { get; set; }
        public DateTime? BillCoverToDate { get; set; }
        public short? FrequencyValue { get; set; }
        public long? FrequencyTimeUnitId { get; set; }
        public long? SopcustDeliveryAddressId { get; set; }
        public bool? ProRata { get; set; }
        public bool? GeneratedFromContract { get; set; }
        public long? SiconContractLineId { get; set; }
        public bool? ForContractAmendment { get; set; }
        public short? RenewalInvoiceFrequencyValue { get; set; }
        public short? RenewalDuration { get; set; }
        public bool? ExtendedTerm { get; set; }
        public short? ContractDuration { get; set; }
        public short BillCoverDuration { get; set; }
        public short? InitialContractDuration { get; set; }
        public short? ExtendedContractDuration { get; set; }
        public long? ReasonForLeavingId { get; set; }
        public DateTime? ProRataDate { get; set; }
        public decimal? UnitBookPrice { get; set; }
        public bool? IsRollingContract { get; set; }
        public decimal? UnitDiscountValue { get; set; }
        public bool? OneOffChargeCredit { get; set; }
        public bool? ForContractPriceAmendment { get; set; }
        public bool? ForContractRenewal { get; set; }
        public string SopdocumentNo { get; set; } = null!;
        public long SopdocumentTypeId { get; set; }
        public short SopprintSequenceNo { get; set; }
        public bool? SelectedForCancellation { get; set; }
        public long? BranchId { get; set; }
        public bool? DirectDebitCollection { get; set; }
        public long? PriceFrequencyTimeUnitId { get; set; }
        public long? AssociatedSlcustAccId { get; set; }
        public long? SiconCrmpersonId { get; set; }
        public long? SiconCrmcompanyId { get; set; }
        public long? AssociatedSiconCrmcompanyId { get; set; }
    }
}
