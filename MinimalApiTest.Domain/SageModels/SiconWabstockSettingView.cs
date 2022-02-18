using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockSettingView
    {
        public long StockItemId { get; set; }
        public string StockCode { get; set; } = null!;
        public string StockName { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string ProductGroupCode { get; set; } = null!;
        public string ProductGroupDescription { get; set; } = null!;
        public bool? LabelRequiredOnPoreceive { get; set; }
        public bool? DefaultSingleLabelOnPoreceive { get; set; }
        public string? OverrideUomname { get; set; }
        public bool? IgnoreQtyForComplexBarcode { get; set; }
        public bool? OverrideScanEnforcementForPick { get; set; }
        public bool? OverrideScanEnforcementForPack { get; set; }
        public decimal? InnerCartonQuantity { get; set; }
        public decimal? OuterCartonQuantity { get; set; }
        public decimal? UsualPalletStockUnitQty { get; set; }
        public bool? IsEnableCatchWeight { get; set; }
        public bool? DontGroupSolinesWhenPicking { get; set; }
        public bool? HoldPick { get; set; }
        public long? SiconWabstockItemId { get; set; }
    }
}
