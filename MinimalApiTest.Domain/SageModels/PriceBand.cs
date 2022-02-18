using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PriceBand
    {
        public PriceBand()
        {
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlcustomerPriceMappings = new HashSet<SlcustomerPriceMapping>();
            StockItemPrices = new HashSet<StockItemPrice>();
        }

        public long PriceBandId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool ThisIsTheStandardBand { get; set; }
        public long? CurrencyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? PriceBandTypeId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsTimeBased { get; set; }
        public DateTime? ActiveDateTimeFrom { get; set; }
        public DateTime? ActiveDateTimeTo { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency? Currency { get; set; }
        public virtual PriceBandType? PriceBandType { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlcustomerPriceMapping> SlcustomerPriceMappings { get; set; }
        public virtual ICollection<StockItemPrice> StockItemPrices { get; set; }
    }
}
