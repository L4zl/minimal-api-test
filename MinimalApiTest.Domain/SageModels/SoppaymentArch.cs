using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppaymentArch
    {
        public SoppaymentArch()
        {
            SoppaymentInvCredLineArches = new HashSet<SoppaymentInvCredLineArch>();
        }

        public long SoppaymentId { get; set; }
        public long SoporderReturnId { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public long PaymentInvoiceStatusId { get; set; }
        public long? TaxCodeId { get; set; }
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual PaymentInvoiceStatus PaymentInvoiceStatus { get; set; } = null!;
        public virtual SoporderReturnArch SoporderReturn { get; set; } = null!;
        public virtual SystaxRate? TaxCode { get; set; }
        public virtual ICollection<SoppaymentInvCredLineArch> SoppaymentInvCredLineArches { get; set; }
    }
}
