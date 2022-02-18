using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbcloudBankAccount
    {
        public long CbcloudBankAccountId { get; set; }
        public string BankCloudBankAccountId { get; set; } = null!;
        public long CbaccountId { get; set; }
        public DateTime? LastTransactionDownloadDateTime { get; set; }
        public long LastTransactionDownloadId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
    }
}
