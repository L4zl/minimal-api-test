using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoptoReorderSopline
    {
        public long PoptoReorderSoplineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string SoporderNo { get; set; } = null!;
        public DateTime? SoporderDate { get; set; }
        public string CustomerAccountRef { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public DateTime? PromisedDeliveryDate { get; set; }
        public decimal QuantityRequired { get; set; }
        public long PopreorderLineStatusId { get; set; }
        public long PoptoReorderWarehouseId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool AccountOnHold { get; set; }
        public bool OrderOnHold { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopreorderLineStatus PopreorderLineStatus { get; set; } = null!;
        public virtual PoptoReorderWarehouse PoptoReorderWarehouse { get; set; } = null!;
        public virtual SoporderReturn? SoporderReturn { get; set; }
        public virtual SoporderReturnLine? SoporderReturnLine { get; set; }
    }
}
