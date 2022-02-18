using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabsopdespatchReceipt
    {
        public long SiconWabsopdespatchReceiptId { get; set; }
        public long SopdespatchReceiptId { get; set; }
        public long NumberOfBoxes { get; set; }
        public string AlternateDespatchNoteReference { get; set; } = null!;
    }
}
