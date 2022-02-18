using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContract
    {
        public long SiconContractId { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public string SpareText4 { get; set; } = null!;
        public string SpareText5 { get; set; } = null!;
        public string SpareText6 { get; set; } = null!;
        public string SpareText7 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public decimal SpareNumber4 { get; set; }
        public decimal SpareNumber5 { get; set; }
        public decimal SpareNumber6 { get; set; }
        public decimal SpareNumber7 { get; set; }
        public DateTime? SpareDateTime1 { get; set; }
        public DateTime? SpareDateTime2 { get; set; }
        public DateTime? SpareDateTime3 { get; set; }
        public DateTime? SpareDateTime4 { get; set; }
        public DateTime? SpareDateTime5 { get; set; }
        public DateTime? SpareDateTime6 { get; set; }
        public DateTime? SpareDateTime7 { get; set; }
        public string DeletedByUserId { get; set; } = null!;
        public DateTime? DeletedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool ContractStatus { get; set; }
        public string? ContractNumber { get; set; }
        public bool? IsBeenEdited { get; set; }
        public string? EditedBy { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long DocumentStatusId { get; set; }
        public string? Description { get; set; }
        public bool? ContractDeleted { get; set; }
        public string? CustomerOrderNumber { get; set; }
        public string? SopbillingDescription { get; set; }
        public bool? PurchaseOrderPrinted { get; set; }
        public decimal? TotalInvoicedToDate { get; set; }
        public decimal? TotalRemainingToBeInvoiced { get; set; }
        public long? NextDocumentNo { get; set; }
        public string? CustomerContact { get; set; }
    }
}
