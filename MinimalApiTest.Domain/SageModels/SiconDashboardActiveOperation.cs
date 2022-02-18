using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDashboardActiveOperation
    {
        public string? EmployeeName { get; set; }
        public long? SiJcEmpId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? ActualQuantity { get; set; }
        public string? Woname { get; set; }
        public string? Wonumber { get; set; }
        public string? Description { get; set; }
        public int? Sequence { get; set; }
        public decimal? Pccomplete { get; set; }
        public decimal? QuantityCompleted { get; set; }
        public string? OperationType { get; set; }
        public string? Name { get; set; }
        public string? Id { get; set; }
        public decimal? TotalQuantity { get; set; }
        public long SiOperationId { get; set; }
        public bool Rework { get; set; }
    }
}
