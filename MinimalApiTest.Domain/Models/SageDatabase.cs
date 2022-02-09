namespace MinimalApiTest.Domain.Models
{
    public partial class SageDatabase
    {
        public long SageDatabaseId { get; set; }
        public string Description { get; set; } = null!;
        public string? ConnectString { get; set; }
        public string DatabaseName { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string? SageUsername { get; set; }
        public string? SagePassword { get; set; }
        public string? DatabasePassword { get; set; }
        public string? PlaceOfRegistration { get; set; }
        public string? RegisteredOffice { get; set; }
        public string? CustomPrintText { get; set; }
        public string? CompanyRegisteredNumber { get; set; }
        public string? ConnectionType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? InvoiceEmailBodyText { get; set; }
        public string? InvoiceEmailSubjectText { get; set; }
        public string? PurchaseOrderEmailBodyText { get; set; }
        public string? PurchaseOrderEmailSubjectText { get; set; }
        public string? SalesOrderEmailBodyText { get; set; }
        public string? SalesOrderEmailSubjectText { get; set; }
        public string? QuoteEmailBodyText { get; set; }
        public string? QuoteEmailSubjectText { get; set; }
        public string? ProFormaEmailBodyText { get; set; }
        public string? ProFormaEmailSubjectText { get; set; }
        public string? CompanyLogoPath { get; set; }
        public string? LayoutsFilePath { get; set; }
        public string? DocumentNoPrefix { get; set; }
        public bool SystemBaseCurrency { get; set; }
        public string? SalesOrderTermsAndConditionsPage { get; set; }
        public string? SalesOrderSignaturePage { get; set; }
        public long? SalesOrderAcknowledgementReport { get; set; }
        public long? SalesOrderAcknowledgementReportInternal { get; set; }
        public long? SalesOrderQuoteReport { get; set; }
        public long? Poreport { get; set; }
        public string? PotermsAndConditionsPage { get; set; }
        public long? InvoiceReport { get; set; }
        public long? SalesOrderAcknowledgementReportDetailed { get; set; }
        public long? SalesOrderQuoteReportDetailed { get; set; }
        public long? PoreportDetailed { get; set; }
        public long? ProFormaReport { get; set; }
        public long? DefaultTaxRateId { get; set; }
        public long? DefaultNonTaxRateId { get; set; }
        public string? DirectDeliveryWarehouse { get; set; }
        public string? DefaultStockItemWarehouse { get; set; }
        public string? NonStockItemCode { get; set; }
        public long? CompanyId { get; set; }
        public bool UseWebApi { get; set; }
        public bool? PotermsAndConditionsLandscape { get; set; }
        public bool OdbcremoteServer { get; set; }
        public long? YearStartMonth { get; set; }
        public decimal? SalesOrderMinimumGrossMarginForOrderSelfApproval { get; set; }
        public decimal? SalesOrderMinimumMarginForSelfApproval { get; set; }
        public string? GremailBodyText { get; set; }
        public string? GremailSubjectText { get; set; }
        public long? MileageDefaultCostingItem { get; set; }
        public bool SalesOrderApproveIfOverPriceBook { get; set; }
        public bool SuspendPosting { get; set; }
        public long? ExpenseVoucherReport { get; set; }
        public long? ProjectRequisitionReport { get; set; }
        public long? PassengerRateMileageExpenseCategoryId { get; set; }
        public long? QuoteRequestReport { get; set; }
        public string? PoquoteEmailBodyText { get; set; }
        public string? PoquoteEmailSubjectText { get; set; }
        public string? ProjectRequisitionEmailSubjectText { get; set; }
        public string? ProjectRequisitionEmailBodyText { get; set; }
        public long? SalesOrderReturnReport { get; set; }
        public long? SalesOrderReturnReportDetailed { get; set; }
        public string? SopreturnEmailBodyText { get; set; }
        public string? SopreturnEmailSubjectText { get; set; }
        public string? Sopattachment { get; set; }
        public string? WebApiusername { get; set; }
        public string? WebApipassword { get; set; }
        public byte[]? CompanyLogo { get; set; }
    }
}
