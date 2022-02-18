using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockItem
    {
        public long SiconWabstockItemId { get; set; }
        public long ItemId { get; set; }
        public bool? LabelRequiredOnPoreceive { get; set; }
        public bool? DefaultSingleLabelOnPoreceive { get; set; }
        public string? OverrideUomname { get; set; }
        public decimal OverrideMultipleOfStockUnit { get; set; }
        public bool? IgnoreQtyForComplexBarcode { get; set; }
        public bool? OverrideScanEnforcementForPick { get; set; }
        public bool? OverrideScanEnforcementForPack { get; set; }
        public decimal? InnerCartonQuantity { get; set; }
        public decimal? OuterCartonQuantity { get; set; }
        public decimal? UsualPalletStockUnitQty { get; set; }
        public decimal? UsualPalletBoxUnitQty { get; set; }
        public bool? IsEnableCatchWeight { get; set; }
        public bool? DontGroupSolinesWhenPicking { get; set; }
        public bool? AutoSetPickQuantityToReqQty { get; set; }
        public bool? HoldPick { get; set; }
    }
}
