using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sopsetting
    {
        public long SopsettingId { get; set; }
        public bool AutoGenOrderReturnNos { get; set; }
        public bool ShowOrderNoOnConfirm { get; set; }
        public short OrderLineItemTypes { get; set; }
        public bool AmendAnalysisCodes { get; set; }
        public bool AmendNominalCodes { get; set; }
        public bool AllowPaymentWithOrder { get; set; }
        public bool UserLogonAsOrderTaker { get; set; }
        public bool RevenueNominalAcctSameAs { get; set; }
        public bool UseSameCcdeptAsCustomer { get; set; }
        public bool UseSameCcdeptForIssues { get; set; }
        public bool UseSameCcdeptForAsset { get; set; }
        public bool AllowCashOrders { get; set; }
        public long? CashOrderAccountId { get; set; }
        public bool ArePricesTaxInclusive { get; set; }
        public bool? AllocateStkOnOrderEntry { get; set; }
        public bool? UpdateStockOnDespatch { get; set; }
        public bool RecordCancelledOrdLines { get; set; }
        public bool PrintPickingLists { get; set; }
        public bool AddInvCredToSalesLedger { get; set; }
        public bool AutoPrintPickingLists { get; set; }
        public bool PrintOrderAcknowledges { get; set; }
        public bool PrintDespatchNotes { get; set; }
        public string? FullyPaidInvoiceText { get; set; }
        public bool GenerateIntrastatEntries { get; set; }
        public long? TermsOfDeliveryId { get; set; }
        public long? NatureOfTransCodeId { get; set; }
        public DateTime? OrdRtnsLastArchivedUpTo { get; set; }
        public string? LastArchiveRunBy { get; set; }
        public DateTime? LastArchiveRunOn { get; set; }
        public bool PrintTraceNosOnPickLists { get; set; }
        public bool PrintTraceNosOnOrderAcks { get; set; }
        public bool PrintTraceNosOnDespNotes { get; set; }
        public bool PrintTraceNosOnInvoices { get; set; }
        public string? LastPurgeArchiveRunBy { get; set; }
        public DateTime? LastPurgeArchiveRunOn { get; set; }
        public DateTime? ArchiveLastPurgedUpTo { get; set; }
        public long? ModeOfTransportId { get; set; }
        public bool UseCashAddrAsDelAddr { get; set; }
        public string? LastProveBalancesRunBy { get; set; }
        public DateTime? LastProveBalancesRunOn { get; set; }
        public bool AllowAmendPickingLists { get; set; }
        public long DefaultFreeTextConfirmIntent { get; set; }
        public long DefaultServLabConfirmIntent { get; set; }
        public bool ShowUnallocatedOnPickingList { get; set; }
        public bool ShowUnallocDespOnDespatchNote { get; set; }
        public bool ShowUnInvoicedOnInvoice { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long SoppartialAllocationTypeId { get; set; }
        public bool AllowProspectQuotes { get; set; }
        public long? ProspectQuoteAccountId { get; set; }
        public bool UseInvoiceDateWithDespatchAtInvoice { get; set; }
        public bool InclTermsOfDeliveryOnIntrastat { get; set; }
        public bool InclStatisticalValOnIntrastat { get; set; }
        public long IntrastatDateTypeId { get; set; }
        public long SoprcinvoiceOptionId { get; set; }
        public bool UseSoprcinvoiceOption { get; set; }
        public long SopprintEuzeroRatedSalesOptionId { get; set; }
        public bool InvoicePaymentImmediately { get; set; }
        public bool UseCardProcessing { get; set; }
        public bool AmendHeaderAnalysisCodes { get; set; }
        public string TaxDiscountInvoiceText { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public string? LastInvoicingDeleteRunBy { get; set; }
        public DateTime? LastInvoicingDeleteRunOn { get; set; }
        public DateTime? InvoicingLastDeletedUpTo { get; set; }
        public bool UseCrossSellingItems { get; set; }
        public bool ShowFrequentItems { get; set; }
        public bool ShowRecentItems { get; set; }
        public bool ShowPreferredItems { get; set; }
        public int NoOfDaysForFreqItems { get; set; }
        public int MinNoOfLinesForFreqItems { get; set; }
        public int NoOfDaysForRecentItems { get; set; }
        public long SopinvoiceCisrctextId { get; set; }
        public long SopcreditCisrctextId { get; set; }

        public virtual SlcustomerAccount? CashOrderAccount { get; set; }
        public virtual ConfirmationIntentType DefaultFreeTextConfirmIntentNavigation { get; set; } = null!;
        public virtual ConfirmationIntentType DefaultServLabConfirmIntentNavigation { get; set; } = null!;
        public virtual IntrastatDateType IntrastatDateType { get; set; } = null!;
        public virtual ModeOfTransport? ModeOfTransport { get; set; }
        public virtual NatureOfTransCode? NatureOfTransCode { get; set; }
        public virtual SlcustomerAccount? ProspectQuoteAccount { get; set; }
        public virtual SopcreditCisrctext SopcreditCisrctext { get; set; } = null!;
        public virtual SopinvoiceCisrctext SopinvoiceCisrctext { get; set; } = null!;
        public virtual SoppartialAllocationType SoppartialAllocationType { get; set; } = null!;
        public virtual SopprintEuzeroRatedSalesOption SopprintEuzeroRatedSalesOption { get; set; } = null!;
        public virtual SoprcinvoiceOption SoprcinvoiceOption { get; set; } = null!;
        public virtual TermsOfDelivery? TermsOfDelivery { get; set; }
    }
}
