using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlaccountInformationView
    {
        public long MmsplaiPlsupplierAccountId { get; set; }
        public string MmsplaiSupplierAccountNumber { get; set; } = null!;
        public string MmsplaiSupplierAccountName { get; set; } = null!;
        public string MmsplaiCurrencyName { get; set; } = null!;
        public double? MmsplaiAccountBalance { get; set; }
        public double? MmsplaiCreditLimit { get; set; }
        public string MmsplaiAddressLine1 { get; set; } = null!;
        public string MmsplaiContactName { get; set; } = null!;
        public string MmsplaiPostCode { get; set; } = null!;
        public string? MmsplaiAccountIsOnHold { get; set; }
    }
}
