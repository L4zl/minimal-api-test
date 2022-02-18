using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatEntry
    {
        public long IntrastatEntryId { get; set; }
        public string OrderReturnNo { get; set; } = null!;
        public DateTime? OrderReturnDate { get; set; }
        public long? EntrySourceId { get; set; }
        public string StockItemCode { get; set; } = null!;
        public string CommodityCode { get; set; } = null!;
        public bool ArrivalOrDespatch { get; set; }
        public decimal OrderReturnLineValue { get; set; }
        public long? TermsOfDeliveryId { get; set; }
        public long? NatureOfTransCodeId { get; set; }
        public decimal Weight { get; set; }
        public decimal SupplementaryUnits { get; set; }
        public long? ModeOfTransportId { get; set; }
        public short PrintSequenceNumber { get; set; }
        public DateTime? DateIntrastatPrinted { get; set; }
        public decimal ExchangeRate { get; set; }
        public string InvoiceCreditNoteNo { get; set; } = null!;
        public decimal StatisticalValue { get; set; }
        public short TaxMonth { get; set; }
        public short TaxYear { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string DestinationCountryCode { get; set; } = null!;
        public string OriginCountryCode { get; set; } = null!;
        public long IntrastatStatusId { get; set; }
        public long IntrastatEntryHeaderId { get; set; }
        public long? OrderReturnLineMovementId { get; set; }
        public string AccountRef { get; set; } = null!;
        public DateTime InvoiceDespatchDate { get; set; }
        public bool ValidEntry { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual EntrySource? EntrySource { get; set; }
        public virtual IntrastatEntryHeader IntrastatEntryHeader { get; set; } = null!;
        public virtual IntrastatStatus IntrastatStatus { get; set; } = null!;
        public virtual ModeOfTransport? ModeOfTransport { get; set; }
        public virtual NatureOfTransCode? NatureOfTransCode { get; set; }
        public virtual TermsOfDelivery? TermsOfDelivery { get; set; }
    }
}
