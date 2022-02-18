﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabwaveOrderView
    {
        public long SiconWabwaveId { get; set; }
        public long WaveTypeId { get; set; }
        public string PickNumber { get; set; } = null!;
        public long SiconWabwaveOrderId { get; set; }
        public int? AllocationId { get; set; }
        public long LineTypeId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public decimal AllocatedQuantity { get; set; }
        public long SoporderReturnLineId { get; set; }
        public string SellingUnitDescription { get; set; } = null!;
        public decimal StockUnitMultiple { get; set; }
        public string PickingListComment { get; set; } = null!;
        public DateTime? HeaderPromisedDeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public string DespatchNoteComment { get; set; } = null!;
        public int PickStatus { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long SoporderReturnId { get; set; }
        public long? AssignedToSiconWabuserId { get; set; }
    }
}