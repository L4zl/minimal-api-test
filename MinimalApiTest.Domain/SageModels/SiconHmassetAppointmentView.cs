using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetAppointmentView
    {
        public long SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public long? SiconHmorderTypeId { get; set; }
        public long? OrderWarehouseId { get; set; }
        public string? DocumentStatus { get; set; }
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? WarehouseId { get; set; }
        public DateTime? DateFirstAvailableForHire { get; set; }
        public decimal? FixedAssetQuantity { get; set; }
        public long? SiconHmorderLineId { get; set; }
        public DateTime? RequestedFromDate { get; set; }
        public DateTime? RequestedToDate { get; set; }
        public int UndefinedHirePeriod { get; set; }
        public DateTime? AssetDespatchedDate { get; set; }
        public DateTime? AssetReceivedDate { get; set; }
        public long ItemId { get; set; }
        public DateTime? AppointmentStartDate { get; set; }
        public DateTime? AppointmentEndDate { get; set; }
        public long SiconAppointmentId { get; set; }
        public string? SiconAppointmentSubject { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
    }
}
