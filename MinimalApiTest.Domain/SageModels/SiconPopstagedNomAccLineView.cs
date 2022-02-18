using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPopstagedNomAccLineView
    {
        public long PoporderReturnLineId { get; set; }
        public long PoporderReturnId { get; set; }
        public string? DocumentNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int IsAccrualKeyValueChanged { get; set; }
        public long SiconPopstagedNomAccLineId { get; set; }
        public string AccruedDocumentNo { get; set; } = null!;
        public short AccruedPrintSequenceNumber { get; set; }
        public DateTime? AccruedDate { get; set; }
        public string AccruedNominalAccountRef { get; set; } = null!;
        public string AccruedNominalCostCentre { get; set; } = null!;
        public string AccruedNominalDepartment { get; set; } = null!;
        public string AccruedNarrative { get; set; } = null!;
        public decimal OutstandingAccrualValue { get; set; }
        public decimal GrniaccrualValue { get; set; }
        public long SiJcTrnId { get; set; }
    }
}
