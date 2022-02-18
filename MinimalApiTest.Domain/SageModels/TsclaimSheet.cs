using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsclaimSheet
    {
        public TsclaimSheet()
        {
            TsclaimRecords = new HashSet<TsclaimRecord>();
            TsexpensesRecordSheetStatuses = new HashSet<TsexpensesRecordSheetStatus>();
        }

        public long TsclaimSheetId { get; set; }
        public string ClaimNumber { get; set; } = null!;
        public string ChequeNumber { get; set; } = null!;
        public long ClaimantId { get; set; }
        public long TsclaimSheetStatusTypeId { get; set; }
        public long TsreimbursmentMethodTypeId { get; set; }
        public string Reference { get; set; } = null!;
        public long? PlsupplierAccountId { get; set; }
        public long? BankId { get; set; }
        public long AuthorisationBehaviourId { get; set; }
        public long RejectBehaviourId { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; } = null!;
        public long TsexpenseClaimStatusTypeId { get; set; }
        public long? TsexpensesPostingStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long Urn { get; set; }
        public string User { get; set; } = null!;
        public int UserNumber { get; set; }
        public long? SourceId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string EnteredBy { get; set; } = null!;
        public decimal ToBaseCurrencyRate { get; set; }
        public long SyscurrencyId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Tsperson Claimant { get; set; } = null!;
        public virtual PlsupplierAccount? PlsupplierAccount { get; set; }
        public virtual Sysmodule? Source { get; set; }
        public virtual Syscurrency Syscurrency { get; set; } = null!;
        public virtual TsexpenseClaimStatusType TsexpenseClaimStatusType { get; set; } = null!;
        public virtual TsexpensesPostingStatus? TsexpensesPostingStatus { get; set; }
        public virtual TspaymentMethod TsreimbursmentMethodType { get; set; } = null!;
        public virtual ICollection<TsclaimRecord> TsclaimRecords { get; set; }
        public virtual ICollection<TsexpensesRecordSheetStatus> TsexpensesRecordSheetStatuses { get; set; }
    }
}
