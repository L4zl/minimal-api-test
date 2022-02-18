using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TssimpleExpense
    {
        public long TssimpleExpenseId { get; set; }
        public long UserId { get; set; }
        public string Reference { get; set; } = null!;
        public string Activity { get; set; } = null!;
        public DateTime DateIncurred { get; set; }
        public decimal GrossAmount { get; set; }
    }
}
