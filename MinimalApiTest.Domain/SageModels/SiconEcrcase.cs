using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcrcase
    {
        public long SiconEcrcaseId { get; set; }
        public long SiSmcaseId { get; set; }
        public string? SiconWoNumber { get; set; }
        public bool? PlaceOnHold { get; set; }
        public bool? RevisionChange { get; set; }
        public bool? BomAffected { get; set; }
        public bool? SetSheetAffected { get; set; }
        public bool? WorksOrderAffected { get; set; }
        public bool? PrototypeFollowUp { get; set; }
        public bool? Rejected { get; set; }
        public bool? DrawingChange { get; set; }
        public bool? UnlockBom { get; set; }
        public bool? UnlockItem { get; set; }
        public long? SiconEcnworkflowId { get; set; }
        public bool Ecncase { get; set; }
        public string? WhyChange { get; set; }
        public string? WhatChange { get; set; }
    }
}
