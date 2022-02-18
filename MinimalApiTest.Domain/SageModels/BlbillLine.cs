using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillLine
    {
        public BlbillLine()
        {
            BlbillLineInvoiceCreditLines = new HashSet<BlbillLineInvoiceCreditLine>();
            BlbillLinePostings = new HashSet<BlbillLinePosting>();
            BlbilledTransactions = new HashSet<BlbilledTransaction>();
        }

        public long BlbillLineId { get; set; }
        public long BlbillId { get; set; }
        public long BlbillLineTypeId { get; set; }
        public int LineSequenceNo { get; set; }
        public long? BlcontractId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitValue { get; set; }
        public long? SystaxRateId { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public long? PcprojectCostItemId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalAccountCostCentre { get; set; } = null!;
        public string NominalAccountDepartment { get; set; } = null!;
        public decimal TotalNetValue { get; set; }
        public decimal TotalTaxValue { get; set; }
        public long? PcunitOfMeasureId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long BlamountOrPercentageId { get; set; }
        public long BldiscountOrSurchargeId { get; set; }
        public decimal UnitDiscountPercent { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlamountOrPercentage BlamountOrPercentage { get; set; } = null!;
        public virtual Blbill Blbill { get; set; } = null!;
        public virtual BlbillLineType BlbillLineType { get; set; } = null!;
        public virtual Blcontract? Blcontract { get; set; }
        public virtual BldiscountOrSurcharge BldiscountOrSurcharge { get; set; } = null!;
        public virtual PcprojectItem? PcprojectCostItem { get; set; }
        public virtual PcunitOfMeasure? PcunitOfMeasure { get; set; }
        public virtual SystaxRate? SystaxRate { get; set; }
        public virtual ICollection<BlbillLineInvoiceCreditLine> BlbillLineInvoiceCreditLines { get; set; }
        public virtual ICollection<BlbillLinePosting> BlbillLinePostings { get; set; }
        public virtual ICollection<BlbilledTransaction> BlbilledTransactions { get; set; }
    }
}
