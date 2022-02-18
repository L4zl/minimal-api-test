using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistAllocateLineView
    {
        public long SoporderReturnLineId { get; set; }
        public string ItemCode { get; set; } = null!;
        public DateTime? PromisedDeliveryDate { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public string StockName { get; set; } = null!;
        public string LineAnalysisCode1 { get; set; } = null!;
        public string LineAnalysisCode2 { get; set; } = null!;
        public string LineAnalysisCode3 { get; set; } = null!;
        public string LineAnalysisCode4 { get; set; } = null!;
        public string LineAnalysisCode5 { get; set; } = null!;
        public string LineAnalysisCode6 { get; set; } = null!;
        public string LineAnalysisCode7 { get; set; } = null!;
        public string LineAnalysisCode8 { get; set; } = null!;
        public string LineAnalysisCode9 { get; set; } = null!;
        public string LineAnalysisCode10 { get; set; } = null!;
        public string LineAnalysisCode11 { get; set; } = null!;
        public string LineAnalysisCode12 { get; set; } = null!;
        public string LineAnalysisCode13 { get; set; } = null!;
        public string LineAnalysisCode14 { get; set; } = null!;
        public string LineAnalysisCode15 { get; set; } = null!;
        public string LineAnalysisCode16 { get; set; } = null!;
        public string LineAnalysisCode17 { get; set; } = null!;
        public string LineAnalysisCode18 { get; set; } = null!;
        public string LineAnalysisCode19 { get; set; } = null!;
        public string LineAnalysisCode20 { get; set; } = null!;
        public string DocumentNo { get; set; } = null!;
        public string CustomerDocumentNo { get; set; } = null!;
        public long SoporderReturnId { get; set; }
        public long DocumentStatusId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Priority { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public bool AccountIsOnHold { get; set; }
        public long ItemId { get; set; }
        public long? WarehouseItemId { get; set; }
        public decimal? FreeStock { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public string WarehouseName { get; set; } = null!;
        public long WarehouseId { get; set; }
        public string? SiJctransType { get; set; }
        public string? JobNumber { get; set; }
        public int IsPreallocated { get; set; }
    }
}
