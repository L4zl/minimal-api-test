using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Temsetting
    {
        public long TemsettingId { get; set; }
        public bool? AutoSendSalesInvoices { get; set; }
        public bool? AutoSendPurchaseOrders { get; set; }
        public bool? AutoImportSalesOrders { get; set; }
        public bool? AutoImportPurchInvoices { get; set; }
        public bool? CheckPriceTolerance { get; set; }
        public decimal PriceTolerancePercentage { get; set; }
        public long? TempriceToleranceBasisId { get; set; }
        public bool? AskUpdateEmailAddress { get; set; }
        public long OrdInvReceivedStatMessId { get; set; }
        public long OrdInvAcceptedStatMessId { get; set; }
        public long OrdInvRejectedStatMessId { get; set; }
        public long OrdInvDeletedStatMessId { get; set; }
        public bool? AutoReleaseReceipts { get; set; }
        public string MessageSubject { get; set; } = null!;
        public string MessageBody { get; set; } = null!;
        public string Mapiprofile { get; set; } = null!;
        public string Mapipassword { get; set; } = null!;
        public string MailFolderName { get; set; } = null!;
        public string MailFolderIndexNo { get; set; } = null!;
        public long? TemactionOnRetrievalId { get; set; }
        public string MoveToFolderName { get; set; } = null!;
        public string MoveToFolderIndexNo { get; set; } = null!;
        public short InboxPollPeriodInMins { get; set; }
        public bool WarnIfNonXmlinInbox { get; set; }
        public bool CollectingMessages { get; set; }
        public bool WelcomeMessageCreated { get; set; }
        public long? TemoutputOptionId { get; set; }
        public string CompanyTeMailAddress { get; set; } = null!;
        public string CoreCurrencyIsocode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TemstatusMessage OrdInvAcceptedStatMess { get; set; } = null!;
        public virtual TemstatusMessage OrdInvDeletedStatMess { get; set; } = null!;
        public virtual TemstatusMessage OrdInvReceivedStatMess { get; set; } = null!;
        public virtual TemstatusMessage OrdInvRejectedStatMess { get; set; } = null!;
        public virtual TemactionOnRetrieval? TemactionOnRetrieval { get; set; }
        public virtual TemoutputOption? TemoutputOption { get; set; }
        public virtual TempriceToleranceBasis? TempriceToleranceBasis { get; set; }
    }
}
