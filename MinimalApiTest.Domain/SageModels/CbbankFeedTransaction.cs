using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedTransaction
    {
        public CbbankFeedTransaction()
        {
            CbbankFeedAccountPostings = new HashSet<CbbankFeedAccountPosting>();
        }

        public long CbbankFeedTransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = null!;
        public int CbbankFeedTransactionTypeId { get; set; }
        public DateTime PostingDate { get; set; }
        public int CbbankFeedReconciliationStatusId { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string TransactionStatus { get; set; } = null!;
        public string TransactionGuid { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long CbaccountId { get; set; }
        public long? SageBankFeedTransactionId { get; set; }
        public string SageBankFeedTransactionType { get; set; } = null!;
        public bool IsApprovalRequired { get; set; }
        public string RuleName { get; set; } = null!;
        public long CbbankFeedProcessStatusId { get; set; }
        public long? AssociatedUrn { get; set; }
        public string PostingErrorMessage { get; set; } = null!;
        public string PayeeSortCode { get; set; } = null!;
        public string PayeeAccountNumber { get; set; } = null!;
        public string PostingCode { get; set; } = null!;
        public string PostingName { get; set; } = null!;
        public string PostingType { get; set; } = null!;

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual CbbankFeedProcessStatus CbbankFeedProcessStatus { get; set; } = null!;
        public virtual CbbankFeedReconciliationStatus CbbankFeedReconciliationStatus { get; set; } = null!;
        public virtual CbbankFeedTransactionType CbbankFeedTransactionType { get; set; } = null!;
        public virtual ICollection<CbbankFeedAccountPosting> CbbankFeedAccountPostings { get; set; }
    }
}
