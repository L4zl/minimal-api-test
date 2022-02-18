using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEppltransactionSearchVw
    {
        public int Archived { get; set; }
        public string CompanyName { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierAccountNumber { get; set; } = null!;
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal TaxValue { get; set; }
        public decimal? NetValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public long UniqueReferenceNumber { get; set; }
    }
}
