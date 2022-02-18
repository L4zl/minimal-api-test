using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomHeader
    {
        public long Id { get; set; }
        public string? BomReference { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
        public decimal StandardMaterialCost { get; set; }
        public bool? TopLevel { get; set; }
        public string? Standard { get; set; }
        public DateTime? Entered { get; set; }
        public DateTime? LastCosted { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Weight { get; set; }
        public string? Per { get; set; }
        public string? Carton { get; set; }
        public string? CartonPer { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal LabourCost { get; set; }
        public decimal MachineSet { get; set; }
        public decimal MachineRun { get; set; }
        public decimal SubContract { get; set; }
        public decimal ToolingCost { get; set; }
        public decimal TotalMatOverhead { get; set; }
        public decimal TotalLabourOverhead { get; set; }
        public decimal TotalMachineOverhead { get; set; }
        public decimal TotalOverheads { get; set; }
        public decimal TotalCost { get; set; }
        public decimal MarkUp { get; set; }
        public decimal QtyCostedFor { get; set; }
        public decimal SuggestedSellingPrice { get; set; }
        public decimal DefaultQty { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string? Custom1 { get; set; }
        public string? Custom2 { get; set; }
        public string? Custom3 { get; set; }
        public string? Custom4 { get; set; }
        public string? Custom5 { get; set; }
        public string? Custom6 { get; set; }
        public string? Custom7 { get; set; }
        public string? Custom8 { get; set; }
        public string? Custom9 { get; set; }
        public string? Custom10 { get; set; }
        public string? ImageForWoDocs { get; set; }
        public bool Phantom { get; set; }
        public string? Revision { get; set; }
        public decimal CostPcnt { get; set; }
        public DateTime? CompOpTimeStamp { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public byte[]? Timestamp { get; set; }
        public bool Private { get; set; }
        public bool OnHold { get; set; }
        public bool? ComponentTraceability { get; set; }
        public double? DefaultScrap { get; set; }
        public short VersionStatus { get; set; }
    }
}
