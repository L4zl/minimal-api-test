using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTransfer
    {
        public SiconStockTransfer()
        {
            SiconStockTransferHistories = new HashSet<SiconStockTransferHistory>();
        }

        public long SiconStockTransferId { get; set; }
        public long? SourceWarehouseId { get; set; }
        public long? DestinationWarehouseId { get; set; }
        public long? CurrentWarehouseId { get; set; }
        public string? TransferReference { get; set; }
        public int? Priority { get; set; }
        public int? Status { get; set; }
        public string? DestinationAddressPostalName { get; set; }
        public string? DestinationAddressLine1 { get; set; }
        public string? DestinationAddressLine2 { get; set; }
        public string? DestinationAddressLine3 { get; set; }
        public string? DestinationAddressLine4 { get; set; }
        public string? DestinationCity { get; set; }
        public string? DestinationPostCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? DespatchDate { get; set; }
        public int? TransferMethod { get; set; }
        public long? SiconStockTransferCourierId { get; set; }
        public long? SpareNumber1 { get; set; }
        public long? SpareNumber2 { get; set; }
        public long? SpareNumber3 { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpecialInstructions { get; set; }
        public long? SiconStockTransferDelCodeId { get; set; }
        public long? DestinationCustomerId { get; set; }
        public long? DestinationSupplierId { get; set; }
        public string? DestinationCounty { get; set; }
        public string? Description { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public string? DespatchSignedBy { get; set; }
        public byte[]? DespatchSignatureByte { get; set; }
        public bool? ReadyToPick { get; set; }

        public virtual ICollection<SiconStockTransferHistory> SiconStockTransferHistories { get; set; }
    }
}
