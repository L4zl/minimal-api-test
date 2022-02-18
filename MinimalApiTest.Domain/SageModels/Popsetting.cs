using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Popsetting
    {
        public long PopsettingId { get; set; }
        public bool AutoGenOrderReturnNos { get; set; }
        public bool? ShowQtyGoodsReceived { get; set; }
        public bool AmendAnalysisCodes { get; set; }
        public bool AmendNominalCodes { get; set; }
        public bool? UserLogonAsOrderTaker { get; set; }
        public bool OrdersNeedAuthorisation { get; set; }
        public decimal AuthorisationThreshold { get; set; }
        public bool? StockNominalAcctSameAs { get; set; }
        public bool UseSameCcdeptAsSupplier { get; set; }
        public string? VariancesNomAccountRef { get; set; }
        public string? VariancesNomCostCentre { get; set; }
        public string? VariancesNomDepartment { get; set; }
        public bool AnalysePostingsByCcdept { get; set; }
        public bool? MarkTextAsReceived { get; set; }
        public bool? MarkServLabAsReceived { get; set; }
        public bool? MatchInvCredToOrdRetOnly { get; set; }
        public bool UseDisputedInvoicing { get; set; }
        public bool AllowOtherSupplierTrans { get; set; }
        public bool RecordCancelledOrdLines { get; set; }
        public bool AutoPrintCopyOrders { get; set; }
        public bool GenerateIntrastatEntries { get; set; }
        public long? TermsOfDeliveryId { get; set; }
        public long? NatureOfTransCodeId { get; set; }
        public DateTime? OrderListLastUpdated { get; set; }
        public DateTime? OrdRtnsLastArchivedUpTo { get; set; }
        public string? LastArchiveRunBy { get; set; }
        public DateTime? LastArchiveRunOn { get; set; }
        public bool UseCataloguePrice { get; set; }
        public string? LastPurgeArchiveRunBy { get; set; }
        public DateTime? LastPurgeArchiveRunOn { get; set; }
        public DateTime? ArchiveLastPurgedUpTo { get; set; }
        public long? ModeOfTransportId { get; set; }
        public string? LastProveBalancesRunBy { get; set; }
        public DateTime? LastProveBalancesRunOn { get; set; }
        public bool AllowManualDirectDelivery { get; set; }
        public bool AllowDirectDeliveryToCustomer { get; set; }
        public bool AllowDirectDeliveryToSupplier { get; set; }
        public bool AllowDirectDelToAnyAddress { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? PriceDifferenceNlaccountId { get; set; }
        public bool UpdatePriceOnGoodsReceipt { get; set; }
        public bool PricesSetAtGoodsReceipt { get; set; }
        public bool? UseOrderExchangeRateForPrices { get; set; }
        public long PoporderGenerationTypeId { get; set; }
        public bool UseSinglePoforDirectDelivery { get; set; }
        public bool InclTermsOfDeliveryOnIntrastat { get; set; }
        public bool InclStatisticalValOnIntrastat { get; set; }
        public long IntrastatDateTypeId { get; set; }
        public bool InclTextInAccruals { get; set; }
        public bool InclServLabInAccruals { get; set; }
        public bool? IncludeBackToBackInOrderGeneration { get; set; }
        public bool ExcludeDirectDeliveryForCustomer { get; set; }
        public bool ExcludeViaStockForCustomer { get; set; }
        public bool ExcludeDirectDeliveryForOrder { get; set; }
        public bool ExcludeViaStockForOrder { get; set; }
        public long DefaultServLabConfirmIntent { get; set; }
        public long DefaultFreeTextConfirmIntent { get; set; }
        public bool? AllowUnauthorisedOrderProcessing { get; set; }
        public bool? AmendHeaderAnalysisCodes { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool? CommittedIncludesGoodsReceived { get; set; }
        public bool CheckBudgetsOnAuthorise { get; set; }
        public bool RequisitionMandatoryNominalCodes { get; set; }
        public bool RequisitionNominalsInBudget { get; set; }
        public bool RequisitionMandatorySupplier { get; set; }
        public bool RequisitionAuthoriserAmend { get; set; }

        public virtual ConfirmationIntentType DefaultFreeTextConfirmIntentNavigation { get; set; } = null!;
        public virtual ConfirmationIntentType DefaultServLabConfirmIntentNavigation { get; set; } = null!;
        public virtual IntrastatDateType IntrastatDateType { get; set; } = null!;
        public virtual ModeOfTransport? ModeOfTransport { get; set; }
        public virtual NatureOfTransCode? NatureOfTransCode { get; set; }
        public virtual PoporderGenerationType PoporderGenerationType { get; set; } = null!;
        public virtual NlnominalAccount? PriceDifferenceNlaccount { get; set; }
        public virtual TermsOfDelivery? TermsOfDelivery { get; set; }
    }
}
