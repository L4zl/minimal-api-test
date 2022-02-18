using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcpendingTransaction
    {
        public long SiconIcpendingTransactionId { get; set; }
        public string? TransType { get; set; }
        public string TransMode { get; set; } = null!;
        public long? TransId { get; set; }
        public int? TranIndex { get; set; }
        public int? CompanyNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? CurrencyIso { get; set; }
        public bool? Vatrated { get; set; }
        public long? TradingAccountId { get; set; }
        public string? TradingAccountRef { get; set; }
        public string? NlfromRef { get; set; }
        public string? NlfromCc { get; set; }
        public string? NlfromDept { get; set; }
        public string? NlfromName { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? TaxValue { get; set; }
        public short? TaxCodeNo { get; set; }
        public decimal? PercentageOfOriginal { get; set; }
        public bool? IsPosted { get; set; }
        public long TaxCodeFromId { get; set; }
        public decimal TaxRateFrom { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? NltoRef { get; set; }
        public string? NltoCc { get; set; }
        public string? NltoDept { get; set; }
        public string? NltoName { get; set; }
        public long TaxCodeToId { get; set; }
        public decimal TaxRateTo { get; set; }
        public bool IsReturn { get; set; }
    }
}
