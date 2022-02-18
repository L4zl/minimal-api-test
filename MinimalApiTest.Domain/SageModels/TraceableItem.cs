using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableItem
    {
        public TraceableItem()
        {
            StktraceItemBatchAttributes = new HashSet<StktraceItemBatchAttribute>();
            TraceableBinItems = new HashSet<TraceableBinItem>();
        }

        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public long UniqueDuplicateNo { get; set; }
        public string? AdditionalReference { get; set; }
        public DateTime? SellByDate { get; set; }
        public DateTime? UseByDate { get; set; }
        public long TraceableItemStatusId { get; set; }
        public long StockItemId { get; set; }
        public decimal GoodsInQuantity { get; set; }
        public decimal GoodsOutQuantity { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public string PurchaseOrderNo { get; set; } = null!;
        public string SupplierGrnno { get; set; } = null!;
        public long TraceableTypeId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string SupplierRef { get; set; } = null!;
        public long SourceAreaTypeId { get; set; }
        public string Barcode { get; set; } = null!;
        public DateTime? LastActivityDate { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public bool LabelPrinted { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SourceAreaType SourceAreaType { get; set; } = null!;
        public virtual StockItem StockItem { get; set; } = null!;
        public virtual TraceableItemStatus TraceableItemStatus { get; set; } = null!;
        public virtual TraceableType TraceableType { get; set; } = null!;
        public virtual ICollection<StktraceItemBatchAttribute> StktraceItemBatchAttributes { get; set; }
        public virtual ICollection<TraceableBinItem> TraceableBinItems { get; set; }
    }
}
