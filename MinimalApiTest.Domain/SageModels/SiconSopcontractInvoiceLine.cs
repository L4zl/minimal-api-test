using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopcontractInvoiceLine
    {
        public long SiconSopcontractInvoiceLineId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long SopinvoiceCreditLineId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public short? FrequencyValue { get; set; }
        public long? FrequencyTimeUnitId { get; set; }
        public long? SopcustDeliveryAddressId { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Processed { get; set; }
        public long? SiconContractLineId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiconCrmpersonId { get; set; }
        public long? SiconCrmcompanyId { get; set; }
    }
}
