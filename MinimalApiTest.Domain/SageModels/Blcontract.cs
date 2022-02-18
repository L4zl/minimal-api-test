using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Blcontract
    {
        public Blcontract()
        {
            BlbillLines = new HashSet<BlbillLine>();
            Blevents = new HashSet<Blevent>();
        }

        public long BlcontractId { get; set; }
        public long SlcustomerId { get; set; }
        public long PcprojectItemId { get; set; }
        public decimal PriceQuoted { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ValueBilled { get; set; }
        public decimal QuantityBilled { get; set; }
        public decimal BillableValue { get; set; }
        public bool ConsolidateBills { get; set; }
        public long PcunitOfMeasureId { get; set; }
        public bool IsContractTemplate { get; set; }
        public string SalesOrderNumber { get; set; } = null!;
        public decimal OutstandingToBill { get; set; }
        public DateTime? LastOutstandingToBillRunDate { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public decimal ToBaseCurrencyRate { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
        public virtual PcunitOfMeasure PcunitOfMeasure { get; set; } = null!;
        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
        public virtual ICollection<Blevent> Blevents { get; set; }
    }
}
